using CobiWebSite.Model.FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.Model.Project
{
    public class ProjectBase :BaseEntity

    {
        [Display(Name = "کد پروژه")]
        public int CodeProject { get; set; }

        [Display(Name = "عنوان پروژه")]
        public string TypeProject { get; set; }

        

        [Display(Name = "درصد پیشرفت")]
        [Required]
        public int PersProgress { get; set; }

        [Display(Name = "زیربنا")]
        public int Foundation { get; set; }


        [Display(Name = "ظرفیت کل ")]
        [Required]
        public int TotalCapacity  { get; set; }

        [Display(Name = "تاریخ شروع")]
        [Required]
        public DateTime Startdate { get; set; }

        [Display(Name = "تاریخ پایان")]
        public DateTime Enddate { get; set; }

        [Display(Name = "واحد")]
        public string UnitProject { get; set; }

        [Display(Name = "تصویر اصلی")]
        public string AttachpicturemainUrl { get; set; }

        [Display(Name = "تصاویر")]
        public string AttachpicturesUrl { get; set; }



        [Display(Name = "متن اصلی")]
        [Required]
        public string Mainnews { get; set; }

       [Display(Name = "توضیحات")]
        public string Description { get; set; }


        [Display(Name = "فعال")]
        public Boolean IsActive { get; set; }


        [Display(Name = "گروه تحقیقاتی")]
        public List<GroupResearch> groupResearches { get; set; }

        [Display(Name = "وضعیت اجرا")]
        public List<StatusExec> StatusExecs { get; set; }

        [Display(Name = "نوع پروژه")]
        public List<TypeProject> TypeProjects { get; set; }

        [Display(Name = "استان")]
        public List<Provience> Proviences { get; set; }


    }
}
