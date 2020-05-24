using SuperCRUDLib.Entities;
using System.Collections.Generic;

namespace SuperCRUDLib.Models
{
    /// <summary>
    /// Represents one page of a paginated list of superheros
    /// </summary>
    public class PageResultModel
    {
        public int PageNo { get; set; }
        public int TotalRecords { get; set; }
        public int PageSize { get; set;  }
        public ICollection<SuperheroListModel> Superheros { get; set; }


        /// <summary>
        /// Calculate total number of pages
        /// </summary>
        /// <returns></returns>
        public int GetTotalPages()
        {
            int pages = TotalRecords / PageSize;

            if (TotalRecords % PageSize != 0)
            {
                pages++;
            }

            return pages;
        }
    }
}
