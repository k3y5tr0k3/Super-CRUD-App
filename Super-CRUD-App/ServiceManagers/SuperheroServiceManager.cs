using Super_CRUD_App.Entities;
using Super_CRUD_App.Models;
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

        /// <summary>
        /// Selects a Superhero from the database
        /// </summary>
        /// 
        /// <param name="id">Superhero ID</param>
        /// 
        /// <returns><![CDATA[SuperheroModel]]></returns>
        public async Task<Superhero> GetSuperheroAsync(int id)
        {
            using (SuperRegistryEntities db = new SuperRegistryEntities())
            {
                SuperheroModel hero = from superhero in db.Superheroes
                                 join abilities in db.Abilities on superhero.SuperheroID equals abilities.
                                 join affinity in db.Affinity on e.TID equals t.TID
                                 where e.OwnerID == user.UID
                                 select new
                                 {
                                     UID = e.OwnerID,
                                     TID = e.TID,
                                     Title = t.Title,
                                     EID = e.EID
                                 };



                
                return hero;
            }
        }

        /// <summary>
        /// Select a subset of rows from the Superhero table
        /// </summary>
        /// 
        /// <param name="pageRequest"></param>
        /// <returns></returns>
        public async Task<PageResultModel> GetPageResultAsync(PageRequestModel pageRequest)
        {
            using (SuperRegistryEntities db = new SuperRegistryEntities())
            {
                var totalSuperheros = await db.Superheroes.CountAsync();
                var superheros = query.Page(pageRequest).ToListAsync().Result.Select(e => ModelFactory.CreateListModel(e));
                return await Task;
            }
        }
        
         
        #endregion

        #region Update

        #endregion

        #region Delete

        #endregion
    }
}
