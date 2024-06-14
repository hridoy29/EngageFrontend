using Engage.Views.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnus.Views.CaseDetails.GalleryPreview
{
    public class GalleryDataView
    {
        public int Id { get; set; }
        public string SelectedImage { get; set; }
        public List<FileDetailsView> Images { get; set; }
        public string SelectedFileType { get; set; }
    }
}
