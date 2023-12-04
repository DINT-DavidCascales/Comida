﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Comida
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM vm= new MainWindowVM();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
            formularioPlato.IsEnabled = true;
           
        }

        private void limpiarPlato_Click(object sender, RoutedEventArgs e)
        {
            vm.QuitarPlato();
            formularioPlato.IsEnabled = false;
        }
    }
}
