using Super_CRUD_App.Entities;
using Super_CRUD_App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_CRUD_App.ModelFactories
{
    /// <summary>
    /// Static class for converting <![CDATA[ObjectResult]]> objects to an objects
    /// optimized for use in the UI
    /// </summary>
    public class SuperheroModelFatory
    {
        public static PageResultModel CreatePageResult(ObjectResult superheros, PageRequestModel req, int totalRecords)
        {
            PageResultModel result = new PageResultModel
            {
                PageNo = req.PageNo,
                PageSize = req.PageSize,
                TotalRecords = totalRecords,
                Superheros = new List<Superhero>()
            };

            foreach (Superhero hero in superheros)
            {
                result.Superheros.Add(hero);
            };

            return result;
        }
    }
}
