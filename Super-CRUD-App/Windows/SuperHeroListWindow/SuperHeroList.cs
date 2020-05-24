using SuperCRUDLib.Entities;
using SuperCRUDLib.Models;
using SuperCRUDLib.Windows.AddUpdateWindow;
using SuperCRUDLib.Windows.DetailsWindow;
using SuperLibrary.ServiceManagers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCRUDLib.Windows.SuperHeroListWindow
{
    public partial class SuperHeroList : Form
    {
        private Form currentWindow;
        PageRequestModel pageRequest;
        PageResultModel currentPage;

        private SuperheroServiceManager serviceManager;

        #region Initialization

        public SuperHeroList()
        {
            InitializeComponent();

            serviceManager = new SuperheroServiceManager();

            InitializeDataGridView();
        }

        #endregion


        #region Utilities
        /// <summary>
        /// Force a window into focus. Used when a user thries to open two 
        /// of a similar type of window. This alow a mximum of two windows 
        /// open at any one time.
        /// </summary>
        /// <param name="window"></param>
        private void FocusWindow(Form window)
        {
            window.WindowState = FormWindowState.Normal;
            window.BringToFront();
            window.Focus();
        }

        /// <summary>
        /// Updates/Refreshes data with currentPage
        /// </summary>
        private void RefreshFormData()
        {
            // labels
            PageNoLabel.Text        = currentPage.PageNo.ToString();
            TotalPagesLabel.Text    = currentPage.GetTotalPages().ToString();
            TotalRecords.Text       = currentPage.TotalRecords.ToString();

            // DataGridView
            SuperheroListDataGridView.Update();
            SuperheroListDataGridView.Refresh();

            SuperheroListDataGridView.Columns[0].AutoSizeMode   = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SuperheroListDataGridView.Columns[0].Name           = "";
            SuperheroListDataGridView.Columns[1].Visible        = false;
            SuperheroListDataGridView.Columns[2].AutoSizeMode   = DataGridViewAutoSizeColumnMode.Fill;
        } 

        #endregion


        #region DataGridView 

        /// <summary>
        /// Re-initializes the DataGridView after CRUD operation.
        /// </summary>
        public void SetDataSource()
        {
            SuperheroListDataGridView.DataSource = currentPage.Superheros;
        }

        public int? CurrentSelection()
        {
            return SuperheroListDataGridView.CurrentCell.RowIndex;
        }

        /// <summary>
        /// Initialize the DataGridView during form initialization
        /// </summary>
        private async void InitializeDataGridView()
        {
            pageRequest = new PageRequestModel();
            await GetPage();
            SetDataSource();
            RefreshFormData();
        }

        #endregion


        #region CRUD Buttons

        /// <summary>
        /// Opens <![CDATA[AddUpdateForm]]> window to add a new superhero the the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Clicked(object sender, EventArgs e)
        {
            if (currentWindow is null)
            {
                currentWindow = new AddUpdateForm();
                currentWindow.Show();
            }
            else
            {
                FocusWindow(currentWindow);
            }
        }

        /// <summary>
        /// Opens <![CDATA[AddUpdateForm]]> window to update an existing superhero in the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Clicked(object sender, EventArgs e)
        {
            if (currentWindow is null)
            {
                if (CurrentSelection() != null)
                {
                    currentWindow = new AddUpdateForm((int) CurrentSelection());
                    currentWindow.Show();
                }
                
            }
            else
            {
                FocusWindow(currentWindow);
            }
        }

        /// <summary>
        /// Remove a superhero from the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in SuperheroListDataGridView.SelectedRows)
            {
                SuperheroListModel hero = row.DataBoundItem as SuperheroListModel;

                if (hero != null)
                {
                    serviceManager.TryRemoveAsync(hero.SuperheroID);
                }

                await GetPage();
                RefreshFormData();
            }
        }

        /// <summary>
        /// Open the <![CDATA[Details]]> window to display all
        /// the details related to a specified superhero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailsButton_Clicked(object sender, EventArgs e)
        {
            if (currentWindow is null)
            {
                if (SuperheroListDataGridView.SelectedRows.Count == 1)
                {
                    foreach (DataGridViewRow row in SuperheroListDataGridView.SelectedRows)
                    {
                        SuperheroListModel superhero = row.DataBoundItem as SuperheroListModel;
                        currentWindow = new Details(superhero.SuperheroID);
                        currentWindow.Show();
                    }
                    
                }
            }
            else
            {
                FocusWindow(currentWindow);
            }
        }

        #endregion



        #region Pagination Utilities
        /// <summary>
        /// Request a page of a paginated list of superheros
        /// </summary>
        /// <param name="pageNo"></param>
        /// <returns></returns>
        private async Task GetPage()
        {
            currentPage = await serviceManager.GetPageResultAsync(pageRequest);
        }

        #endregion



        #region Pagination Buttons

        private async void PrevPage_Click(object sender, EventArgs e)
        {
            if (pageRequest.PageNo + 1 <= currentPage.GetTotalPages())
            {
                pageRequest.PageNo++;
                await GetPage();
                RefreshFormData();
            }
            
            
        }

        private async void NextPage_Click(object sender, EventArgs e)
        {
            if (pageRequest.PageNo > 1)
            {
                pageRequest.PageNo--;
                await GetPage();
                RefreshFormData();
            }
                
        }

        #endregion

        
    }
}
