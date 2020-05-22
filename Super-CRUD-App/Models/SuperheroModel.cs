using Super_CRUD_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_CRUD_App.Models
{
    public class SuperheroModel
    {
        public string Name { get; set; }
        public ICollection<Ability> Abilities { get; set; }
        public Affinity Affinity { get; set; }
        public Alias Alias { get; set; }
        public Background Background { get; set; }
        public Origin Origin { get; set; }
        public Region Region { get; set; }
    }
}
