using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Multiplayer_Quiz.Networking;

namespace Multiplayer_Quiz.Presentation.WPF
{
    /// <summary>
    /// Interaction logic for WPF.xaml
    /// </summary>
    public partial class WPF : UserControl
    {
        private Server server;
        public WPF(Server server)
        {
            InitializeComponent();
            this.server = server;
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }


        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            server.startGameCommand = true;
            Console.WriteLine("Clicked start");
        }
    }
}
