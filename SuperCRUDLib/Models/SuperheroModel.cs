using SuperCRUDLib.Entities;
using System.Collections.Generic;

namespace SuperCRUDLib.Models
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
