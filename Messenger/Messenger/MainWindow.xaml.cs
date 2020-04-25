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

namespace Messenger
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

        private void ShowContacts(object sender, RoutedEventArgs e)
        {
            CollapseAll();
            Contacts.Visibility = System.Windows.Visibility.Visible;
        }

        private void ShowChat(object sender, RoutedEventArgs e)
        {
            CollapseAll();
            Chat.Visibility = System.Windows.Visibility.Visible;
        }
        private void ShowCalls(object sender, RoutedEventArgs e)
        {
            CollapseAll();
            Calls.Visibility = System.Windows.Visibility.Visible;
         }
        private void ShowSettings(object sender, RoutedEventArgs e)
        {
            CollapseAll();
            Settings.Visibility = System.Windows.Visibility.Visible;
        }
        private void CollapseAll()
        {
            Chat.Visibility = System.Windows.Visibility.Collapsed;
            Contacts.Visibility = System.Windows.Visibility.Collapsed;
            Settings.Visibility = System.Windows.Visibility.Collapsed;
            Calls.Visibility = System.Windows.Visibility.Collapsed;
        }

    }
}
