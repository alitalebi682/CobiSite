using CobiWebSite.Model.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.Model.Project
{
    public class GroupResearch :BaseEntity
    {

        public String GroupReserch { get; set; }

        public ProjectBase ProjectBase { get; set; }
    }
}
