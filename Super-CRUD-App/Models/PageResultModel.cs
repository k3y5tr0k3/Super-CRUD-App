using Super_CRUD_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_CRUD_App.Models
{
    /// <summary>
    /// Represents one page of a paginated list of superheros
    /// </summary>
    public class PageResultModel
    {
        public int PageNo { get; set; }
        public int TotalRecords { get; set; }
        public int PageSize { get; set;  }
        public ICollection<Superhero> Superheros { get; set; }
    }
}
