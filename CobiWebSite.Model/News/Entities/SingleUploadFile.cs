using CobiWebSite.Model.FrameWork;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.Model.News.Entities
{
    public class SingleUploadFile :BaseEntity
    {
        [Required(ErrorMessage = "Please enter file name")]
        public string FileName { get; set; }
        [Required(ErrorMessage = "Please select file")]
        [NotMapped]
        public IFormFile File { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
