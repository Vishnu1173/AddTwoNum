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

namespace AddtwoNum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string oper = " ";
        public MainWindow()
        {
            InitializeComponent();

        }


        private void oper_Click(object sender, RoutedEventArgs e)
        {
            //int result = AddtwoNumber(txtvalue1.Text, txtvalue2.Text);
             Button button = (Button)sender;
             oper = button.Content.ToString();
            //Class oclass = new Class(); (or next statement used both are same)
            Class oclass;
            oclass = new Class();
            int result = oclass.Opertwonumbers(txtvalue1.Text, txtvalue2.Text,oper);
            txtbresult.Text = result.ToString();
        }

        //public int AddtwoNumber(string value1, string value2)
        //{
        //    int firstvalue = Convert.ToInt32(value1);
        //    int secondvalue = Convert.ToInt32(value2);
        //    int result = firstvalue + secondvalue;
        //    return result;
        //}

        //private void btnmult_Click(object sender, RoutedEventArgs e)
        //{
        //    int result1 = MulttwoNumber(txtvalue1.Text, txtvalue2.Text);
        //    txtbresult.Text = result1.ToString();
        //}
        //public int MulttwoNumber(string value1, string value2)
        //{
        //    int firstvalue = 0;
        //    int secondvalue = 0;
        //    if (!string.IsNullOrEmpty(value1))
        //    {
        //        firstvalue = Convert.ToInt32(value1);
        //    }
        //    if (!string.IsNullOrEmpty(value2))
        //    {
        //        secondvalue = Convert.ToInt32(value2);
        //    }

        //    int result1 = firstvalue * secondvalue;
        //    return result1;
        //}


        //private void btndivid_Click(object sender, RoutedEventArgs e)
        //{
        //    int result2 = DividtwoNumber(txtvalue1.Text, txtvalue2.Text);
        //    txtbresult.Text = result2.ToString();
        //}
        //public int DividtwoNumber(string value1, string value2)
        //{
        //    int firstvalue = isstringNullCheck(value1);
        //    int secondvalue = isstringNullCheck(value2);
        //    int result2 = firstvalue / secondvalue;
        //    return result2;
        //}
        //public int isstringNullCheck(string value)
        //{ 
        //    if(string.IsNullOrEmpty(value))
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return Convert.ToInt32(value);
        //    }     
    //}
    }
}
