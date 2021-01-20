using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTracker.Models
{
    public class project
    {
        public int Id { get; set; }
        public string projectName { get; set; }
        public string projectDescription { get; set; }

        public project()
        {

        }

    }
}
