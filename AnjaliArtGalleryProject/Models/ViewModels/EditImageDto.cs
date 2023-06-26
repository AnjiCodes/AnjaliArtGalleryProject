using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnjaliArtGalleryProject.Models.ViewModels
{
    public class EditImageDto : NewImageDto
    {
        public ImageDto SelectedImage { get; set; }
        
    }

}