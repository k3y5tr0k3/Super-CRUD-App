using SuperCRUDLib.Entities;
using SuperCRUDLib.Models;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace SuperCRUDLib.ModelFactories
{
    /// <summary>
    /// For converting db result set to object
    /// </summary>
    public class SuperheroModelFatory
    {
        public static PageResultModel CreatePageResult(IEnumerable<sp_SelectPageOfSuperheros_Result> superheros, PageRequestModel req, int totalRecords)
        {
            List<SuperheroListModel> superheroList = superheros.Select(x => new SuperheroListModel
            {
                RowNum = (int)x.RowNum,
                SuperheroID = x.SuperheroID,
                Name = x.Name
            }
            ).ToList();

            PageResultModel result = new PageResultModel
            {
                PageNo = req.PageNo,
                PageSize = req.PageSize,
                TotalRecords = totalRecords,
                Superheros = superheroList
            };

            return result;
        }

        /// <summary>
        /// For converting db result set to object
        /// </summary>
        public static SuperheroModel CreateSuperheroModel(IEnumerable<sp_SelectSuperheroDetailsBySuperheroID_Result> superhero)
        {
            SuperheroModel[] superheroModel = superhero.Select(x => new SuperheroModel
            {
                SuperheroID = x.SuperheroID,
                Name = x.Name,
                Affinity = x.Affinity,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Region = x.Region_Name,
                Origin = x.Origin,
                AbilityName = x.Ability_Name,
                AbilityDescription = x.Ability_Description
            }
            ).ToArray();

            return superheroModel[0];
        }
    }
}
