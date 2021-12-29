using FactoryApp.Models;
using FactoryApp.ViewModels;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FactoryApp.UserControls
{
    /// <summary>
    /// Interaction logic for Plants.xaml
    /// </summary>
    public partial class Plants : UserControl
    {
        private Stack<UserControl> Screens { get; }
        private StackPanel Screen { get; }
        public Plants(Employee user, Stack<UserControl> screens, StackPanel screen)
        {
            InitializeComponent();
            Screens = screens;
            Screen = screen;
            this.DataContext = new PlantsVM(user);
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (sender != null)
                {
                    if (sender is DataGrid grid && grid.SelectedItems != null && grid.SelectedItems.Count == 1)
                    {
                        
                        //This is the code which helps to show the data when the row is double clicked.
                        DataGridRow dgr = grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem) as DataGridRow;
                        Plant dr = (Plant)dgr.Item;

                        int plantId = dr.ID;
                        Areas areas = new Areas(plantId, Screens, Screen);
                        Screens.Push(areas);
                        Screen.Children.Clear();
                        Screen.Children.Add(areas);
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
