
using Magnus.Views.Admin.ImportSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Core.Mappings
{
    public static class AdminMapping
    {
        public static AdminClientView MapToClient(ImportMappingFileView importMappingFileView)
        {
            return new AdminClientView
            {
                ClientID = importMappingFileView.ClientID,
                ClientName = importMappingFileView.ClientName
            };
        }
        public static FileView MapToFile(ImportMappingFileView importMappingFileView)
        {
            return new FileView
            {
                FileTypeID= importMappingFileView.FileTypeID,
                FileType= importMappingFileView.FileType
            };
        }
        public static CategoryView MapToCategory(ImportMappingHeaderCategoryView importMappingHeaderCategoryView)
        {
            return new CategoryView
            {
               Category= importMappingHeaderCategoryView.Category
            };
        }
        public static HeaderView MapToHeader(ImportMappingHeaderCategoryView importMappingHeaderCategoryView)
        {
            return new HeaderView
            {
                Header= importMappingHeaderCategoryView.Header,
                HeaderID= importMappingHeaderCategoryView.HeaderID
            };
        }
    }
}
