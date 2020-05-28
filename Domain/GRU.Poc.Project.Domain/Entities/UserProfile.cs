using System;
using System.Collections.Generic;
using System.Text;

namespace GRU.Poc.Project.Domain.Entities
{
    public class UserProfile
    {

        public string Name { get; }
        public bool Actived { get; }

        public UserProfile(string name, bool actived) {

            Name = name;
            Actived = actived;
        }

    }
}
