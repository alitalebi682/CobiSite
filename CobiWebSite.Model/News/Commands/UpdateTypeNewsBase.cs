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
    public class UpdateTypeNewsBase : IRequest<ApplicationServiceResponse<TypeNewsBase>>
    {

        public int Id { get; set; }
        public string TypeNewsBaseName { get; set; }
    }
}
