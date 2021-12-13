using FactoryApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp.ViewModels
{
    public class MainMenuVM
    {
        public MainMenuVM(Employee user)
        {
            this.user = user;
            Plants = new ObservableCollection<Plant>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=Factory;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Plant where plant_active = 1", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here   
            con.Open();
            foreach(DataRow row in dt.Rows)
            {
                Plant plant = new Plant();
                plant.ID = (int)row["plant_id"];
                plant.Name = (string)row["plant_name"];
                if (row["plant_description"] != DBNull.Value)
                {
                    plant.Description = (string)row["plant_description"];
                }
                Plants.Add(plant);
            }
            con.Close();
        }
        public Employee User
        {
            get
            {
                return user;
            }
        }
        public ObservableCollection<Plant> Plants { get; }

        Employee user;

    }
}
