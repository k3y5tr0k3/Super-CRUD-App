﻿using SuperCRUDLib.Entities;
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
        #region Creation

        /// <summary>
        /// private constructor
        /// </summary>
        public SuperheroServiceManager() { }

        #endregion

        #region Create 

        /*public async Task CreateSuperheroAsync()
        {
            return new Task;
        }*/

        #endregion

        #region Read

        /// <summary>
        /// Asyncronous wrapper function for GetSuperhero()
        /// </summary>
        /// 
        /// <param name="id">Superhero ID</param>
        /// 
        /// <returns><![CDATA[SuperheroModel]]></returns>
        public async Task<SuperheroModel> GetSuperheroAsync(int id)
        {
            using (SuperRegistryEntities db = new SuperRegistryEntities())
            {
                return await Task.Factory.StartNew(() => GetSuperhero(id));
            }
        }

        /// <summary>
        /// Selects a Superhero from the database
        /// </summary>
        /// 
        /// <param name="id"></param>
        /// <returns></returns>
        private SuperheroModel GetSuperhero(int id)
        {
            using (SuperRegistryEntities db = new SuperRegistryEntities())
            {
                var sprocResult = db.sp_SelectSuperheroDetailsBySuperheroID(id);

                return SuperheroModelFatory.CreateSuperheroModel(sprocResult);
            }
        }

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

                return SuperheroModelFatory.CreatePageResult(sprocResult, req, totalRecords);
            }
        }
        
         
        #endregion

        #region Update

        #endregion

        #region Delete

        /// <summary>
        /// Remove a superhero secified by SuperheroID
        /// </summary>
        /// <param name="id">SuperheroID</param>
        public async void TryRemoveAsync(int id)
        {
            using (SuperRegistryEntities db = new SuperRegistryEntities())
            {
                Superhero hero = await db.Superheroes.Where(x => x.SuperheroID == id).FirstOrDefaultAsync();
                db.Superheroes.Remove(hero);
            }
        }

        #endregion
    }
}
