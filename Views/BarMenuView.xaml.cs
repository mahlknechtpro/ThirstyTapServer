using System;
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
    /// Interaktionslogik für BarMenuView.xaml
    /// </summary>
    /// 

    public partial class BarMenuView : UserControl
    {
        //globale Variable
        public static int quantity = 1;
        public Button buttonName;
        public TextBlock textBlockName;

        public BarMenuView()
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

        private void BTN_INPUT_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            tb_kassa_output_akt.Text = (tb_kassa_output_akt.Text == "0" && button.Content.ToString() != ",")
                ? button.Content.ToString()
                : tb_kassa_output_akt.Text + button.Content;
        }
        private void BTN_OPERATOR_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Content.ToString())
            {
                case "+":
                    lbl_kassa_output_full.Content = lbl_kassa_output_full.Content + tb_kassa_output_akt.Text + "+";
                    break;
                case "-":
                    lbl_kassa_output_full.Content = lbl_kassa_output_full.Content + tb_kassa_output_akt.Text + "-";
                    break;
                case "*":
                    lbl_kassa_output_full.Content = lbl_kassa_output_full.Content + tb_kassa_output_akt.Text + "*";
                    break;
                case "/":
                    lbl_kassa_output_full.Content = lbl_kassa_output_full.Content + tb_kassa_output_akt.Text + "/";
                    break;
            }
            tb_kassa_output_akt.Clear();
        }
        private void BTN_FUNC_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Content.ToString())
            {
                case "DEL":
                    tb_kassa_output_akt.Text = tb_kassa_output_akt.Text.Remove(tb_kassa_output_akt.Text.Length - 1);
                    if (tb_kassa_output_akt.Text == "")
                    {
                        tb_kassa_output_akt.Text = "0";
                    }
                    break;
                case "TOTALE":
                    break;
            }
        }

        private void Btn_varie_click(object sender, RoutedEventArgs e)
        {

        }

        private void Lvi_alleloeschen(object sender, RoutedEventArgs e)
        {

        }

        private void Lvi_loeschen(object sender, RoutedEventArgs e)
        {

        }

    }
}
