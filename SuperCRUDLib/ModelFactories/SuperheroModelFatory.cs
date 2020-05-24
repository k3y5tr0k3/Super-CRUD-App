using SuperCRUDLib.Entities;
using SuperCRUDLib.Models;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;

namespace SuperCRUDLib.ModelFactories
{
    /// <summary>
    /// Static class for converting <![CDATA[ObjectResult]]> objects to an objects
    /// optimized for use in the UI
    /// </summary>
    public class SuperheroModelFatory
    {
        public static PageResultModel CreatePageResult(List<SuperheroListModel> superheros, PageRequestModel req, int totalRecords)
        {
            PageResultModel result = new PageResultModel
            {
                PageNo = req.PageNo,
                PageSize = req.PageSize,
                TotalRecords = totalRecords,
                Superheros = superheros
            };

            return result;
        }
    }
}
