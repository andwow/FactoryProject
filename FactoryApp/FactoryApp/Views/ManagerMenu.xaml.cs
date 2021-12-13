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
using System.Windows.Shapes;

namespace FactoryApp.Views
{
  
    public partial class ManagerMenu : Window
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

      
        private void Check_Stocks_Button_Click(object sender, RoutedEventArgs e)
        {
            CheckStocks stocks = new CheckStocks();
            stocks.Show();

        }
        private void About_Production_Button_Click(object sender, RoutedEventArgs e)
        {
            Production production = new Production();
            production.Show();
        }

        private void About_Employees_Button_Click(object sender, RoutedEventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
        }

    }
}
