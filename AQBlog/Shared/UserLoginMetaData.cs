namespace AQBlog.Shared
{
    public class UserLoginMetaData
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class AuthResponseMetaData
    {
        public bool IsAuthenticated { get; set; }
        public string Token { get; set; }
    }
}
