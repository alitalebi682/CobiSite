using CobiWebSite.Model.FrameWork;
using CobiWebSite.Model.News.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.Model.News.Commands
{
    public class UpdateNews : IRequest<ApplicationServiceResponse<NewsBase>>
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Type { get; set; }
    }
}
