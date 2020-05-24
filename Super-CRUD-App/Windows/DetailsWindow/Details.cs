using SuperCRUDLib.Models;
using System.Windows.Forms;

namespace SuperCRUDLib.Windows.DetailsWindow
{
    public partial class Details : Form
    {
        /// <summary>
        /// Creates an instance of
        /// </summary>
        /// <param name="hero"></param>
        public Details(int superheroID)
        {
            InitializeComponent();

            DisplayHero(superheroID);
        }

        /// <summary>
        /// Get SuperheroModel from the DB and 
        /// add the superhero's details to form
        /// </summary>
        /// <param name="hero"><![CDATA[SuperheroModel]]></param>
        private void DisplayHero(int SuperheroID)
        {
            
        }

    }
}
