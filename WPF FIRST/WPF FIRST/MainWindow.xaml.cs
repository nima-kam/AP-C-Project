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


namespace WPF_FIRST
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

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            Tab_control.SelectedItem = second_page;
            
        }

        private void SAVE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LOAD_Click(object sender, RoutedEventArgs e)
        {

        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show($"{this.TextBox.Text}\nReset");
            this.TextBox.Text = string.Empty;
            this.CarCheckBox.IsChecked = false;
            this.MetroCheckBox.IsChecked = false;
            this.BusCheckBox.IsChecked = false;
            this.TaxiCheckBox.IsChecked = false;
            



        }
            
        private void NEWButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Tab_control.SelectedItem = first_page;
        }
    }
}
