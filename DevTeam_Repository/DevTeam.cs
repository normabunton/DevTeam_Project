using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Repository
{
    public class DevTeam
    {
        public string NameOfTeam { get; set; }
        public string Developer { get; set; }

        public DevTeam() { }
        public DevTeam(string nameOfTeam, string developer)
        {
            NameOfTeam = nameOfTeam;
            Developer = developer;
        }
    }
}
