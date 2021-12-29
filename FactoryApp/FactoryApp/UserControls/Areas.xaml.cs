using FactoryApp.Models;
using FactoryApp.ViewModels;
using FactoryApp.Views;
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
    /// Interaction logic for Areas.xaml
    /// </summary>
    public partial class Areas : UserControl
    {
        private Stack<UserControl> Screens { get; }
        private StackPanel Screen { get; }
        public Areas(int plantId, Stack<UserControl> screens, StackPanel screen)
        {
            ViewModel = new AreasVM(plantId);
            InitializeComponent();
            Screens = screens;
            Screen = screen;
            this.DataContext = ViewModel;
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
                        Area dr = (Area)dgr.Item;

                        int areaId = dr.ID;
                        Lines lines = new Lines(areaId, Screens, Screen);
                        Screens.Push(lines);
                        Screen.Children.Clear();
                        Screen.Children.Add(lines);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public AreasVM ViewModel { get; }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Screens.Pop();
            Screen.Children.Clear();
            Screen.Children.Add(Screens.Peek());
        }
    }
}
