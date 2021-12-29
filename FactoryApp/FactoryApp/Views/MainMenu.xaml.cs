using FactoryApp.Models;
using FactoryApp.UserControls;
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
        public MainMenu(Employee user)
        {
            //this.DataContext = new PlantsVM(user);
            InitializeComponent();
            Screens = new Stack<UserControl>();
            Plants plants = new Plants(user, Screens, Screen);
            Screens.Push(plants);
            Screen.Children.Add(plants);
            //plants.MouseDoubleClick += new MouseButtonEventHandler(DataGrid_MouseDoubleClick);
        }
        Stack<UserControl> Screens { get; }
    }

}
