using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp.Models
{
    public class Line: ModelBase
    {
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                NotifyPropertyChanged("ID");
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }
        public string ProductivityString
        {
            get
            {
                return ProductivityMethods.GetString(lineProductivity);
            }
        }
        public Productivity LineProductivity
        {
            get
            {
                return lineProductivity;
            }
            set
            {
                lineProductivity = value;
                NotifyPropertyChanged("LineProductivity");
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                NotifyPropertyChanged("Description");
            }
        }
        int id;
        string name;
        Productivity lineProductivity;
        string description;
    }
}
