using SuperCRUDLib.Models;
using SuperLibrary.ServiceManagers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCRUDLib.Windows.DetailsWindow
{
    public partial class Details : Form
    {
        private SuperheroModel superhero;
        private SuperheroServiceManager serviceManager;

        /// <summary>
        /// Creates an instance of
        /// </summary>
        /// <param name="hero"></param>
        public Details(int superheroID)
        {
            InitializeComponent();

            serviceManager = new SuperheroServiceManager();

            DisplayHero(superheroID);
        }

        /// <summary>
        /// Get SuperheroModel from the DB and 
        /// add the superhero's details to form
        /// </summary>
        /// <param name="hero"><![CDATA[SuperheroModel]]></param>
        private async void DisplayHero(int SuperheroID)
        {
            superhero = await GetSuperhero(SuperheroID);

            // TODO: add data to labels here
            SuperHeroNameInfoLbl.Text = superhero.Name;
            AbilityDescriptionInfoLbl.Text = superhero.AbilityDescription;
            AffinityTypeInfoLbl.Text = superhero.Affinity;
            AbilityNameInfoLbl.Text = superhero.AbilityName; 
            AbilityDescriptionInfoLbl.Text = superhero.AbilityDescription;
            AliasFirstnameinfoLbl.Text = superhero.FirstName;
            AliasLastnameInfoLbl.Text = superhero.LastName;
            OriginTypeInfoLbl.Text = superhero.Origin;
            RegionNameInfoLbl.Text = superhero.Region;


        }

        /// <summary>
        /// Get SuperheroModel for the specified superhero
        /// </summary>
        /// <param name="superheroID"></param>
        /// <returns><![CDATA[SuperheroModel]]></returns>
        public async Task<SuperheroModel>  GetSuperhero(int superheroID)
        {
            return await serviceManager.GetSuperheroAsync(superheroID);
        }

    }
}
