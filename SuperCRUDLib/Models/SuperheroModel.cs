using SuperCRUDLib.Entities;
using System.Collections.Generic;

namespace SuperCRUDLib.Models
{
    public class SuperheroModel
    {
        public int SuperheroID { get; set; }
        public string Name { get; set; }
        public string AbilityName { get; set; }
        public string AbilityDescription { get; set; }
        public string Affinity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Origin { get; set; }
        public string Region { get; set; }
    }
}
