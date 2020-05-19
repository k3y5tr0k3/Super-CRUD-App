using Super_CRUD_App.DataModels;
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
        public Details(Superhero hero)
        {
            InitializeComponent();
            DisplayHero(hero);
        }

        private void DisplayHero(Superhero hero)
        {
            SuperHeroNameInfoLbl.Text = hero.Name;
            //
        }
    }
}
