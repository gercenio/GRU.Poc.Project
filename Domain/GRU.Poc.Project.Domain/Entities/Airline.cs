using System;
using System.Collections.Generic;
using System.Text;

namespace GRU.Poc.Project.Domain.Entities
{
    public class Airline
    {
        public string Name { get; }
        public string Document { get; }

        public bool Actived { get; private set; }

        public Airline(string name, string document) {

            Name = name;
            Document = document;
        }

        public void AddActived(bool a) {

            Actived = a;
        }
    }
}
