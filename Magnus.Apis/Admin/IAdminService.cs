using Magnus.Views.Admin.ImportSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engage.Views.Files;
namespace Magnus.APIs.Admin
{
    public interface IAdminService
    {
        Task<IEnumerable<ImportMappingFileView>> GetImportMappingFileAsync();
        Task<IEnumerable<ImportMappingHeaderCategoryView>> GetImportMappingHeaderCategoryAsync(int fileTypeId);
        Task<bool> AddNewImportMappingsAsync(ImportMappingView importMappingViewList);
        Task<List<FileDetailsView>> GetFileAsync(List<string> fileNames);

    }
}
