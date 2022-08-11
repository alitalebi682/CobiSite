using CobiWebSite.Model.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.Model.Project
{
    public class TypeProject : BaseEntity
    {

        public String  TypeProjectName { get; set; }

        public ProjectBase ProjectBase { get; set; }
    }
}
