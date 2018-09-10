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

namespace Week7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public static List<string> listname = new List<string>();


        bool empty()
        {
            if (TxtItems.Text == "")
            {
                MessageBox.Show("Please Input Item");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {


            if (this.TxtItems.Text != "")
            {
                LstBox.Items.Add(TxtItems.Text);
                TxtItems.Clear();

            }
            else
            {
                MessageBox.Show("Please Input Item");
            }


        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            while (LstBox.SelectedItems.Count > 0)
            {
                LstBox.Items.Remove(LstBox.SelectedItems[0]);
                TxtItems.Clear();
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            int Index = LstBox.SelectedIndex;
            LstBox.Items.RemoveAt(Index);
            LstBox.Items.Insert(Index, TxtItems.Text);
            TxtItems.Clear();

        }

        private void LstBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                TxtItems.Text = LstBox.SelectedItem.ToString();
            }
            catch
            {

            }
        }
    }


    
}
