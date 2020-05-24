using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCRUDLib.Models
{
    public class PageRequestModel
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string Filter { get; set; }

        public PageRequestModel()
        {
            PageNo = 1;
            PageSize = 5;
            Filter = "";
        }
    }
}
