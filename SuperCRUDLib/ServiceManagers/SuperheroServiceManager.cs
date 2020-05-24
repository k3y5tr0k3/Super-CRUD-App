using SuperCRUDLib.Entities;
using SuperCRUDLib.ModelFactories;
using SuperCRUDLib.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SuperLibrary.ServiceManagers
{
    /*
     * A singleton class to interact with entity framework and execute queries
     */
    public class SuperheroServiceManager
    {
        #region Singleton Creation

        /// <summary>
        /// Holds a reference to the current instance of SuperheroServiceManager
        /// </summary>
        private static SuperheroServiceManager instance;

        /// <summary>
        /// private constructor
        /// </summary>
        private SuperheroServiceManager() { }

        /// <summary>
        /// Static method that returns a singleton instance of SuperheroServiceManager
        /// </summary>
        /// <returns>An instance of SuperheroServiceManger</returns>
        public static SuperheroServiceManager GetInstance()
        {
            if (instance is null)
            {
                instance = new SuperheroServiceManager();
            }

            return instance;
        }
        #endregion

        #region Create 
        
        /*public async Task CreateSuperheroAsync()
        {
            return new Task;
        }*/

        #endregion

        #region Read

        /// <summary>
        /// Selects a Superhero from the database
        /// </summary>
        /// 
        /// <param name="id">Superhero ID</param>
        /// 
        /// <returns><![CDATA[SuperheroModel]]></returns>
        /*public async Task<SuperheroModel> GetSuperheroAsync(int id)
        {
            // TODO:
            return 
        }*/

        /// <summary>
        /// Call a sproc to paginate the superhero table
        /// </summary>
        /// 
        /// <param name="pageRequest"></param>
        /// <returns><![CDATA[PageResultModel]]></returns>
        public async Task<PageResultModel> GetPageResultAsync(PageRequestModel req)
        {
            using (SuperRegistryEntities db = new SuperRegistryEntities())
            {
                var totalRecords = await db.Superheroes.CountAsync();
                var sprocResult = db.sp_SelectPageOfSuperheros(req.PageNo, req.PageSize, req.Filter);

                List<SuperheroListModel> superheroList = sprocResult.Select(x => new SuperheroListModel
                {
                    RowNum = (int)x.RowNum,
                    SuperheroID = x.SuperheroID,
                    Name = x.Name
                }
                ).ToList();

                PageResultModel result = SuperheroModelFatory.CreatePageResult(superheroList, req, totalRecords);

                return result;
            }
        }
        
         
        #endregion

        #region Update

        #endregion

        #region Delete

        #endregion
    }
}
