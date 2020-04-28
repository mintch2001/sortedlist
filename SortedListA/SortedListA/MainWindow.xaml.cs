using System;
using System.Collections;
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

namespace SortedListA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sorted;
        public MainWindow()
        {
            InitializeComponent();
            sorted = new SortedList();
        }

        private void AddClick_Click(object sender, RoutedEventArgs e)
        {
            sorted.Add(txtKey.Text, txtValue.Text);
            ICollection collection = sorted.Keys;
            string data = " ";
            foreach(string i in collection)
            {
                //data = data + i; สำหรับเอา Key ออกมาโชว์
                data = data + " " +sorted[i].ToString(); //เอา Value ออกมาโชว์
            }
            MessageBox.Show("Data : " + data);
        }
    }
}
