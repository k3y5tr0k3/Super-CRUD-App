using Super_CRUD_App.DataModels.Entities;
using Super_CRUD_App.Windows.DetailsWindow;
using SuperLibrary.ServiceManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_CRUD_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Details(GetSuperhero().GetAwaiter().GetResult()));
        }

        public async static Task<Superhero> GetSuperhero()
        {
            SuperheroServiceManager manager = SuperheroServiceManager.getInstance();
            Superhero superhero = await manager.getSuperheroAsync(1);

            return superhero;
        }

    }
}
