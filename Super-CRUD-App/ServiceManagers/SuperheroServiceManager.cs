using Super_CRUD_App.DataModels;
using SuperLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperLibrary.ServiceManagers
{
    /*
     * A singleton class to interact with entity framework and execute queries
     */
    public class SuperheroServiceManager
    {
        #region Singleton Creation

        /// <summary>
        /// Holds an instance of the current instance of SuperheroServiceManager
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
        public static SuperheroServiceManager getInstance()
        {
            if (instance is null)
            {
                instance = new SuperheroServiceManager();
            }

            return instance;
        }
        #endregion


        #region Create 
        // insert statement
        #endregion

        #region Read
        /* 
         * Simple Select Query to get some data
         * 
         */
        public async Task<Superhero> getSuperheroAsync(int id)
        {
            using (SuperRegistryEntities db = new SuperRegistryEntities())
            {
                Superhero hero = await db.Superheroes.Where((x) => x.SuperheroID == 1).FirstOrDefaultAsync();
                return hero;
            }
        }
         
        #endregion

        #region Update

        #endregion

        #region Delete

        #endregion
    }
}
