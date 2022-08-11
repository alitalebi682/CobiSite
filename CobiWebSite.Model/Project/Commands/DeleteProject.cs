using CobiWebSite.Model.FrameWork;
using CobiWebSite.Model.News.Entities;
using CobiWebSite.Model.Project;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.Model.News.Commands
{
    public  class DeleteProject : IRequest<ApplicationServiceResponse<ProjectBase>>
    {
        public int Id { get; set; }



    }
}
