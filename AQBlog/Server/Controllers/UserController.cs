using AQBlog.Domain.Abstract;
using AQBlog.Domain.Infrastructure;
using AQBlog.Model;
using AQBlog.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace AQBlog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserDetailRepository userDetailRepo;
        private readonly IConfiguration configuration;
        private readonly IConfigurationSection jwtSettings;
        public UserController(
            IUserDetailRepository userDetailRepo,
            IConfiguration configuration)
        {
            this.userDetailRepo = userDetailRepo;
            this.configuration = configuration;
            this.jwtSettings = this.configuration.GetSection("JwtSettings");
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> LoginUser(UserLoginMetaData userLogin)
        {
            try
            {
                var userDetail = await Task.Run(() => this.userDetailRepo.FindByFilterDefinition(x => x.UserName == userLogin.UserName)
                            .FirstOrDefault());

                if (userDetail == null)
                    throw new Exception("Invalid credential");

                var password = Encryption.Encrypt(userLogin.Password, userDetail.SaltPassword);

                if (password != userDetail.Password)
                    throw new Exception("Invalid credential");

                var signingCredentials = GetSigningCredentials();
                var claims = GetClaims(userDetail);
                var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                return Ok(new AuthResponseMetaData { IsAuthenticated = true, Token = token });
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(jwtSettings["securityKey"]);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private List<Claim> GetClaims(UserDetail user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.UserData,JsonSerializer.Serialize(user))
            };

            return claims;
        }
        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken(
                issuer: jwtSettings["validIssuer"],
                audience: jwtSettings["validAudience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expiryInMinutes"])),
                signingCredentials: signingCredentials);

            return tokenOptions;
        }
    }
}
