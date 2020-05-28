using System;
using System.Collections.Generic;
using System.Text;

namespace GRU.Poc.Project.Domain.Entities
{
    public class User
    {
        public string Name { get; }

        public string Document { get; }

        public bool Actived { get; private set; }

        public List<UserProfile> UserProfiles { get; private set; }

        public List<Airline> Airlines { get; private set; }

        public User(string name, string document) {

            Name = name;
            Document = document;
            UserProfiles = new List<UserProfile>();
            Airlines = new List<Airline>();
        }

        public void AddActived(bool a) {

            Actived = a;
        }

        public void AddProfile(UserProfile userProfile) {

            UserProfiles.Add(userProfile);
        
        }

        public void AddAirline(Airline airline) {

            Airlines.Add(airline);
        }
    }
}
