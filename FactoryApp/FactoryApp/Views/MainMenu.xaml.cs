using FactoryApp.Models;
using FactoryApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FactoryApp.Views
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu(Employee user, SqlConnection con)
        {
            this.DataContext = new MainMenuVM(user);
            InitializeComponent();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (sender != null)
                {
                    DataGrid grid = sender as DataGrid;
                    if (grid != null && grid.SelectedItems != null && grid.SelectedItems.Count == 1)
                    {
                        //This is the code which helps to show the data when the row is double clicked.
                        DataGridRow dgr = grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem) as DataGridRow;
                        Plant dr = (Plant)dgr.Item;

                        int plantId = dr.ID;
                        Areas areas = new Areas(plantId);
                        areas.Show();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }

}
