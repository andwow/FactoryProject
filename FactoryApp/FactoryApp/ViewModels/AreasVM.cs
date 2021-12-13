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
    public class AreasVM
    {
        public AreasVM(int plantId)
        {
            Areas = new ObservableCollection<Area>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=Factory;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Area where area_active = 1 and plant_id = @Plant", con);
            cmd.Parameters.AddWithValue("@Plant", plantId);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here   
            con.Open();
            foreach (DataRow row in dt.Rows)
            {
                Area area = new Area();
                area.ID = (int)row["ID"];
                area.Name = (string)row["Name"];
                area.Description = (string)row["Description"];
                Areas.Add(area);
            }
            con.Close();
        }
        public ObservableCollection<Area> Areas { get; }
    }
}
