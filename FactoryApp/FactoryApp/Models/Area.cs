using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp.Models
{
    public class Area : ModelBase
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
        string description;
    }
}
