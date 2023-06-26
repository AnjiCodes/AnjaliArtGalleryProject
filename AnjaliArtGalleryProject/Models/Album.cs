using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnjaliArtGalleryProject.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        
    }
    public class AlbumDto
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
    }
}