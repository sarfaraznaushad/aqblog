using AQBlog.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AQBlog.Client.Services
{

    public class MasterService : IMasterService
    {
        private IHttpService httpService;
        private ILocalStorageService localStorageService;
        private NavigationManager navigationManager;
        public MasterService(IHttpService httpService,
            ILocalStorageService localStorageService,
            NavigationManager navigationManager)
        {
            this.httpService = httpService;
            this.localStorageService = localStorageService;
            this.navigationManager = navigationManager;
        }

        public async Task<List<MasterDetailMetaData>> GetMaster()
        {
            var master = await this.httpService.Get<List<MasterDetailMetaData>>("blog/FnGetMaster");
            return master;
        }

        public async Task AddMaster(AddMasterMetaData master)
        {
            await this.httpService.Post<AddMasterMetaData>("blog/AcAddMaster", master);
        }

        public async Task<List<MasterMetaData>> GetMasterByCode(string masterCode)
        {
            var master = await this.httpService.Get<List<MasterMetaData>>("blog/FnManageMaster?masterCode=" + masterCode);
            return master;
        }

        public async Task<AddMasterMetaData> GetMasterById(string id)
        {
            var master = await this.httpService.Get<AddMasterMetaData>("blog/FnGetMasterById?id=" + id);
            return master;
        }
    }

    public interface IMasterService
    {
        Task<List<MasterDetailMetaData>> GetMaster();
        Task AddMaster(AddMasterMetaData master);
        Task<List<MasterMetaData>> GetMasterByCode(string masterCode);
        Task<AddMasterMetaData> GetMasterById(string id);
    }
}
