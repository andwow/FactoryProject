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
    public class LinesVM
    {
        public LinesVM(int areaId)
        {
            Lines = new ObservableCollection<Line>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=Factory;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Line where line_active = 1 and area_id = @Area", con);
            cmd.Parameters.AddWithValue("@Area", areaId);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here   
            con.Open();
            foreach (DataRow row in dt.Rows)
            {
                Line line = new Line();
                line.ID = (int)row["line_id"];
                line.Name = (string)row["line_name"];
                line.LineProductivity = (Productivity)((int)row["line_productivity"]);
                line.Description = (string)row["line_description"];
                Lines.Add(line);
            }
            con.Close();
        }
        public ObservableCollection<Line> Lines { get; }
    }
}
