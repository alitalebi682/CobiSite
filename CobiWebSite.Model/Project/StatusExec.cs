using CobiWebSite.Model.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.Model.Project 
{
    public class StatusExec :BaseEntity
    {
        public string StatusExecPro { get; set; }

        public ProjectBase ProjectBase { get; set; }
    }
}
