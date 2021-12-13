﻿using FactoryApp.ViewModels;
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
    /// <summary>
    /// Interaction logic for Areas.xaml
    /// </summary>
    public partial class Areas : Window
    {
        public Areas(int plantId)
        {
            this.DataContext = new AreasVM(plantId);
            InitializeComponent();
        }
    }
}
