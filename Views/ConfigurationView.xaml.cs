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
using System.Data;
using ThirstyTap.Core;

namespace ThirstyTap.Views
{
    /// <summary>
    /// Interaktionslogik für ConfigurationView.xaml
    /// </summary>
    public partial class ConfigurationView : UserControl
    {
        public ConfigurationView()
        {
            InitializeComponent();
            Logger.Write(Logger.INFO, "View Configuration wurde gestartet");

            ////Load all the configurations from DB
            //try
            //{
            //    //generate the connection string
            //    string connectionString = "SERVER=localhost;DATABASE=tt_test;UID=root;PASSWORD=mima10492;";

            //    //create a MySQL connection with a query string
            //    MySqlConnection connection = new MySqlConnection(connectionString);

            //    //MySqlCommand cmdProd = new MySqlCommand("select p_id AS PRODNR, p_name as NOME, p_groupid AS GROUPNR, p_price AS PREZZO, p_ivaid AS IVA from t_products", connection);
            //    MySqlCommand cmdGroup = new MySqlCommand("SELECT g_id as ID, g_name AS NOME, g_uscita AS USCITA FROM t_groups", connection);
            //    MySqlCommand cmdReadGroup = new MySqlCommand("SELECT g_name FROM t_groups", connection);

            //    //open the connection
            //    connection.Open();

            //    DataTable dtgroup = new DataTable();
            //    DataTable dtGroupName = new DataTable();

            //    dtgroup.Load(cmdGroup.ExecuteReader());
            //    dtGroupName.Load(cmdReadGroup.ExecuteReader());

            //    cb_group_prod.ItemsSource = dtGroupName.DefaultView;
            //    cb_group_prod.DisplayMemberPath = "g_name";
            //    cb_group_prod.SelectedValuePath = "g_name";
                
            //    dtGridGroup.DataContext = dtgroup;
            //}
            //catch (Exception ex)
            //{
            //    funcDLL.Func.LogWrite_Error("Errore Configuration - Load Configuration --> " + ex.ToString());
            //}

        }

        private void showProdGroup(object sender, EventArgs e)
        {
            //string insertGroup = this.cb_group_prod.Text;

            //funcDLL.Func.LogWrite_Error("insertGroup: " + insertGroup);

            //try
            //{
            //    //generate the connection string
            //    string connectionString = "SERVER=localhost;DATABASE=tt_test;UID=root;PASSWORD=mima10492;";
            //    string selectString = "SELECT p.* FROM t_products as p INNER JOIN t_groups as g ON p.p_groupid = g.g_id WHERE g.g_name = '" + insertGroup + "';";

            //    funcDLL.Func.LogWrite_Error("selectString: " + selectString);

            //    //create a MySQL connection with a query string
            //    MySqlConnection connection = new MySqlConnection(connectionString);

            //    MySqlCommand selectCMD = new MySqlCommand(selectString, connection);

            //    connection.Open();

            //    DataTable dtprod = new DataTable();

            //    dtprod.Load(selectCMD.ExecuteReader());

            //    //close the connection
            //    connection.Close();

            //    dtGridProd.DataContext = dtprod;
            //}
            //catch (Exception ex)
            //{
            //    funcDLL.Func.LogWrite_Error("Errore Configuration - Load Productslist --> " + ex.ToString());
            //}

        }
    }
}
