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

namespace Event_Final_Project
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

        private void BtnClickRegister(object sender, RoutedEventArgs e)
        {
            Main.Content = new Register();
        }
        private void BtnClickProducts(object sender, RoutedEventArgs e)
        {
            Main.Content = new Products();
        }
        private void BtnClickFeedback(object sender, RoutedEventArgs e)
        {
            Main.Content = new Feedback();
        }
        private void BtnClickContact(object sender, RoutedEventArgs e)
        {
            Main.Content = new Contact();
        }
        private void BtnClickAbout(object sender, RoutedEventArgs e)
        {
            Main.Content = new About();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
