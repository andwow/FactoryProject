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
    /// Interaction logic for Lines.xaml
    /// </summary>
    public partial class Lines : UserControl
    {
        private Stack<UserControl> Screens { get; }
        private StackPanel Screen { get; }
        public Lines(int areaId, Stack<UserControl> screens, StackPanel screen)
        {
            ViewModel = new LinesVM(areaId);
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
                        Models.Line dr = (Models.Line)dgr.Item;

                        int lineId = dr.ID;
                        LineScreen line = new LineScreen(lineId, Screens, Screen);
                        Screens.Push(line);
                        Screen.Children.Clear();
                        Screen.Children.Add(line);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public LinesVM ViewModel { get; }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Screens.Pop();
            Screen.Children.Clear();
            Screen.Children.Add(Screens.Peek());
        }
    }
}
