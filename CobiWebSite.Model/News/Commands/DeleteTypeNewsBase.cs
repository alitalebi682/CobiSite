using CobiWebSite.Model.FrameWork;
using CobiWebSite.Model.News.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.Model.News.Commands
{
    public class DeleteTypeNewsBase : IRequest<ApplicationServiceResponse<TypeNewsBase>>
    {
        public int Id { get; set; }
        public string GroupNewsName { get; set; }

        public string PictureGroupNews { get; set; }
    }
}
