using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engage.Views.Files
{
    public class FileDetailsView
    {
        public int Id { get; set; }
        public string fileData { get; set; }
        public string fileType { get; set; }
        public string fileName { get; set; }
        public string originalFileName { get; set; }
    }
}
