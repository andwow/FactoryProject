using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp.Models
{
    public class Employee : ModelBase
    {
        public Employee()
        {

        }
        public Employee(string cnp, string username, string lastName, string firstName, double salary, string gender, DateTime birthday, int role)
        {
            this.cnp        = cnp;
            this.username   = username;
            this.lastName   = lastName;
            this.firstName  = firstName;
            this.gender     = gender;
            this.birthday   = birthday;
            this.role       = role;
            this.salary     = salary;
        }
        public string Cnp
        {
            get
            {
                return cnp;
            }
            set
            {
                cnp = value;
                NotifyPropertyChanged("Cnp");
            } 
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                NotifyPropertyChanged("Username");
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                NotifyPropertyChanged("LastName");
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                NotifyPropertyChanged("FirstName");
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
                NotifyPropertyChanged("Gender");
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
                NotifyPropertyChanged("Birthday");
            }
        }
        public int Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
                NotifyPropertyChanged("Role");
            }
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
                NotifyPropertyChanged("Salary");
            }
        }
        string cnp;
        string username;
        string lastName;
        string firstName;
        string gender;
        double salary;
        DateTime birthday;
        int role;
    }
}
