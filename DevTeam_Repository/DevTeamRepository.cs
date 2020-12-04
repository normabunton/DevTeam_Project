﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Repository
{
    public class DevTeamRepository
    {
        //private readonly DeveloperRepo _developerRepo = new DeveloperRepo(); // this gives you access to the _developerDirectory so you can access existing Developers and add them to a team
        private readonly List<DevTeam> _devTeams = new List<DevTeam>();

        public void AddTeamToList(DevTeam content)//DevTeam Create
        {
            _devTeams.Add(content);
        }
        public List<DevTeam> GetContentList() //DevTeam Read
        {
        return _devTeams;
        }
        //DevTeam Update
        //DevTeam Delete

        //DevTeam Helper (Get Team by ID)

    }
}

