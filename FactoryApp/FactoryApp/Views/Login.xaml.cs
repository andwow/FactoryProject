using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
using System.Data.SqlClient;
using FactoryApp.Models;

namespace FactoryApp.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Connection String   
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=Factory;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Employee where username=@UserName and password =@Password", con);
            cmd.Parameters.AddWithValue("@UserName", username.Text);
            cmd.Parameters.AddWithValue("@Password", password.Password);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here   
            con.Open();
            int i = cmd.ExecuteNonQuery();
            
            if (dt.Rows.Count > 0)
            {
                Employee user = new Employee();
                user.Cnp        = (string)dt.Rows[0]["employee_cnp"];
                user.FirstName  = (string)dt.Rows[0]["employee_first_name"];
                user.LastName   = (string)dt.Rows[0]["employee_last_name"];
                user.Username   = (string)dt.Rows[0]["username"];
                user.Gender     = (string)dt.Rows[0]["employee_gender"];
                user.Birthday   = (DateTime)dt.Rows[0]["employee_birthday"];
                user.Salary     = (double)dt.Rows[0]["employee_salary"];
                user.Role       = (int)dt.Rows[0]["role_id"];

                MainMenu mainMenu = new MainMenu(user);
                mainMenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }
            con.Close();
        }
    }
}
