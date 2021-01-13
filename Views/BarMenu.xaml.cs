﻿using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaktionslogik für BarMenu.xaml
    /// </summary>
    /// 

    public partial class BarMenu : UserControl
    {
        //globale Variable
        public static int quantity = 1;
        public Button buttonName;
        public TextBlock textBlockName;

        public BarMenu()
        {
            InitializeComponent();
            Logger.Write(Logger.INFO, "View BarMenu wurde gestartet");

            //#region Fill all button
            //try
            //{
            //    //generate the connection string
            //    string connectionString = "SERVER=localhost;DATABASE=tt_test;UID=root;PASSWORD=mima10492;";
                
            //    //create a MySQL connection with a query string
            //    MySqlConnection connection = new MySqlConnection(connectionString);

            //    //MySQLCommand
            //    MySqlCommand cmdgroup = new MySqlCommand("select Count(*) from t_groups", connection);

            //    //open the connection
            //    connection.Open();

            //    string countGroup = cmdgroup.ExecuteScalar().ToString();

            //    funcDLL.Func.LogWrite_Info("View Bar - Menu: Gruppenanzahl: " + countGroup);

            //    //close the connection
            //    connection.Close();

            //    int iCountGroup = int.Parse(countGroup);
            //    //int iCountProducts = int.Parse(countProducts);

            //    for(int i = 1; i <= iCountGroup; i++)
            //    {
            //        textBlockName = this.FindName("Group" + i) as TextBlock;

            //        Console.WriteLine("TextBox.Text: " + textBlockName.Text);
            //        try
            //        {
            //            //MySQLCommand
            //            MySqlCommand groupName = new MySqlCommand(@"select g_name from t_groups WHERE g_id = @i", connection);
            //            groupName.Parameters.Add("@i", (MySqlDbType)SqlDbType.Int).Value = i; //your id parameter!


            //            connection.Open();

            //            string nameGroup = groupName.ExecuteScalar().ToString();

            //            connection.Close();

            //            textBlockName.Text = nameGroup;
            //            textBlockName.Visibility = Visibility.Visible;

            //            //CREATE STATEMENT
            //            string prodStatement = "select Count(*) from t_products WHERE p_groupid = " + i;
            //            MySqlCommand cmdproducts = new MySqlCommand(prodStatement, connection);

            //            //open the connection
            //            connection.Open();

            //            string countProducts = cmdproducts.ExecuteScalar().ToString();
            //            funcDLL.Func.LogWrite_Info("View Bar - Menu: Produkteanzahl: " + countProducts);
            //            connection.Close();
            //            Console.WriteLine("Wert countProducts: " + countProducts);

            //            int iCountProducts = int.Parse(countProducts);



            //            for (int j = 1; j <= iCountProducts; j++)
            //            {

            //                buttonName = this.FindName("prod_" + i + "_" + j) as Button;
            //                try
            //                {
            //                    //MySQLCommand
            //                    string queryProductName = "select p_name from t_products WHERE p_groupid = " + i + " AND p_id = " + j;
            //                    Console.WriteLine("Test: " + queryProductName);

            //                    MySqlCommand productName = new MySqlCommand("select p_name from t_products WHERE p_groupid = '" + i + "' AND p_id = '" + j + "'", connection);
                                
            //                    connection.Open();

            //                    string nameProduct = productName.ExecuteScalar().ToString();

            //                    connection.Close();

            //                    buttonName.Content = nameProduct;
            //                    buttonName.Visibility = Visibility.Visible;
            //                }
            //                catch(Exception ex)
            //                {
            //                    MessageBox.Show(ex.ToString());
            //                }
                            
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.ToString());
            //        }
            //    }
                
            //} 
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //#endregion
        }

        #region Btn_click_1
        private void Btn_click_1(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 1;

            //tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);

        }
        #endregion

        #region Btn_click_2
        private void Btn_click_2(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 2;

            //tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_3
        private void Btn_click_3(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 3;

            //tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_4
        private void Btn_click_4(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 4;

            //tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_5
        private void Btn_click_5(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 5;

            //tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_6
        private void Btn_click_6(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 6;

            //tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_7
        private void Btn_click_7(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 7;

            //tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_8
        private void Btn_click_8(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 8;

            //tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_9
        private void Btn_click_9(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 9;

            //tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_click_0
        private void Btn_click_0(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            int num = 0;

            //tb_kassa.Text = funcDLL.Func.NumPadIns(tb, num);
        }
        #endregion

        #region Btn_del
        private void Btn_del(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();

            var index = lv_Users.Items.IndexOf(lv_Users.SelectedItem);
            //MessageBox.Show("Index: " + index);
            if (index == -1)
            {
                if (tb.Length > 1)
                {
                    tb = tb.Substring(0, tb.Length - 1);
                }
                else
                {
                    tb = "0";
                }
                tb_kassa.Text = tb.ToString();
            }
            else
            {
                double priceOne;
                string lblTotal;
                var selectedStockObject = lv_Users.SelectedItems[0] as MyItem;
                if (selectedStockObject == null)
                {
                    return;
                }

                priceOne = selectedStockObject.Price;
                lblTotal = lbl_totale.Content.ToString();
                //lbl_totale.Content = funcDLL.Func.TotalSumMinus(priceOne, lblTotal);

                
                lv_Users.Items.RemoveAt(index);
            }
            
        }
        #endregion

        #region Btn_multi
        private void Btn_multi(object sender, RoutedEventArgs e)
        {
            if(tb_kassa.Text == "0")
            {
                lv_Users.SelectAll();
            }
            else
            {
                quantity = int.Parse(tb_kassa.Text);
                tb_kassa.Text = "0";
            }

        }
        #endregion

        #region Btn_minus
        private void Btn_minus(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Btn_plus
        private void Btn_plus(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Btn_click_result
        private void Btn_click_result(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Btn_click_comma
        private void Btn_click_comma(object sender, RoutedEventArgs e)
        {
            //Variablen
            string tb = tb_kassa.Text.ToString();
            String comm = ",";

            if (tb == "")
            {
                tb_kassa.Text = comm.ToString();
            }
            else if (tb != "")
            {
                tb_kassa.Text += comm.ToString();
            }
        }
        #endregion

        #region Btn_varie_click
        private void Btn_varie_click(object sender, RoutedEventArgs e)
        {
            //Variable
            string tb =  tb_kassa.Text.ToString();
            char[] separator = {'.',','};
            Int32 count = 2;
            Double priceTb;
            String lblTotal;

            //Todo Null bei einstelliger Decimal hinzufügen
            String[] strlist = tb.Split(separator, count, StringSplitOptions.None);
            
            if (tb.Contains(",") == false)
            {
                priceTb = Convert.ToDouble(strlist[0] + ",0");
            }
            else
            {
                priceTb = Convert.ToDouble(strlist[0] + "," + strlist[1]);
            }
            priceTb = priceTb * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = "Varie 10%", Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            //lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);




            //Textbox zurücksetzen
            tb_kassa.Clear();
            tb_kassa.Text = "0";
            quantity = 1;
        }
        #endregion

        #region Lvi_loeschen
        private void Lvi_loeschen(object sender, RoutedEventArgs e)
        {
            var index = lv_Users.Items.IndexOf(lv_Users.SelectedItem);
            
            double priceOne;
            string lblTotal;
            var selectedStockObject = lv_Users.SelectedItems[0] as MyItem;
            if (selectedStockObject == null)
            {
                return;
            }

            priceOne = selectedStockObject.Price;
            lblTotal = lbl_totale.Content.ToString();
            //lbl_totale.Content = funcDLL.Func.TotalSumMinus(priceOne, lblTotal);

            
            lv_Users.Items.RemoveAt(index);
            

        }

            private void Lvi_alleloeschen(object sender, RoutedEventArgs e)
        {
            lv_Users.Items.Clear();
            lbl_totale.Content = "0";
        }
        #endregion

        private void Btn_2_1(object sender, RoutedEventArgs e)
        {
            int group = 2;
            int prod = 1;
            char[] separator = { '.', ',' };
            Double priceTb = 0.0;
            String lblTotal;
            string prodName = "";

            //prodName = funcDLL.Func.getProdName(group, prod, prodName);
            //priceTb = funcDLL.Func.getPrice(group, prod, priceTb) * quantity;

            this.lv_Users.Items.Add(new MyItem { Product = prodName, Quantity = quantity, Price = priceTb });

            lblTotal = lbl_totale.Content.ToString();

            //lbl_totale.Content = funcDLL.Func.TotalSum(priceTb, lblTotal);
            quantity = 1;
        }
    }

    internal class MyItem
    {
        public String Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
