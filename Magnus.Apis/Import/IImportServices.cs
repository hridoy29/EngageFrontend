using Magnus.Views.Import;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.APIs.Import
{
    public interface IImportServices
    {
        public Task<ImportMultiselectView> GetAllMultiSelect();
    }
}
