using CobiWebSite.Model.FrameWork;
using CobiWebSite.Model.Project;
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
    public class NewsBase :BaseEntity
    {
        

        [Display(Name = "نوع خبر ")]
        public string Type { get; set; }

        [Display(Name = "رو تیتر")]
        public string? Rowtitle { get; set; }

        [Display(Name = "لید خبر")]
        public string? Rowmainnews { get; set; }

        [Display(Name = "اولویت نمایش")]
        public int? Showpriority { get; set; }

        [Display(Name = "تاریخ شروع")]
        public DateTime Startdate { get; set; }

        [Display(Name = "تاریخ پایان")]
        public DateTime Enddate { get; set; }

        [Display(Name = "تصویر اصلی")]
        public string AttachpicturemainUrl { get; set; }

        [Display(Name = "تصاویر")]
        public string AttachpicturesUrl { get; set; }


        [Display(Name = "نمایش پروفایل")]
        public bool Showprofile { get; set; }

        [Display(Name = "اخبار برگزیده")]
        public string Slectnews { get; set; }

        [Display(Name = "متن اصلی")]
        [Required]
        public string Mainnews { get; set; }

        [Display(Name = "کلمات کلیدی")]
        public string Keywordnews { get; set; }


        [Display(Name = "توضیحات")]
        public string Description { get; set; }


        [Display(Name = "فعال")]
        public Boolean IsActive { get; set; }

       


        
        //public int GroupNewsId { get; set; }

        //[ForeignKey("GroupNews")]
        //public int GroupNewsId { get; set; }
       // public List<GroupNews> GroupNews { get; set; }
       [ForeignKey("GroupNewsId")]
        public virtual  GroupNews GroupNews { get; set; }


        // [Display(Name = "نوع خبر")]
        //  [ForeignKey("TypeNewsBase")]

        //public int NewsRelatedId { get; set; }
        [ForeignKey("NewseRelatedId")]
        public virtual NewseRelated NewseRelated { get; set; }


        [ForeignKey("TypeNewsBaseId")]


        public virtual TypeNewsBase TypeNewsBase { get; set; }




    }
}
