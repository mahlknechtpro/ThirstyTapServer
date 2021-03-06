﻿using ThirstyTap.Viewmodels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThirstyTap.Core;

namespace ThirstyTap.Views
{
    /// <summary>
    /// Interaktionslogik für MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            Logger.Write(Logger.INFO, "View MainView wurde gestartet");
        }

        private void BTN_Menue_OpenKassaView_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.App.SwitchPage(new BarMenuViewModel());
        }
        private void BTN_Menue_OpenStatisticView_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.App.SwitchPage(new StatisticViewModel());
        }
        private void BTN_Menue_OpenTableView_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.App.SwitchPage(new TableViewModel());
        }

    }
}
