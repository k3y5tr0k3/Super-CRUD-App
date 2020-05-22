using Super_CRUD_App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_CRUD_App.Windows.DetailsWindow
{
    public partial class Details : Form
    {
        /// <summary>
        /// Creates an instance of
        /// </summary>
        /// <param name="hero"></param>
        public Details(Superhero hero)
        {
            InitializeComponent();
            DisplayHero(hero);
        }

        private void DisplayHero(Superhero hero)
        {
            SuperHeroNameInfoLbl.Text = hero.Name;
            AffinityTypeInfoLbl.Text = hero.Affinity.Type;
            hero.
            //
        }
    }
}
