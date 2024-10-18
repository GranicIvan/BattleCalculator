using BtlCalc1.View;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BtlCalc1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Hello, World!");
            Trace.WriteLine("TRACE ");

        }

        private void Battle1v1_Click(object sender, RoutedEventArgs e)
        {

            Battle1v1 battle = new Battle1v1();
            //battle.Owner = this;  // Set the owner so it stays on top of the main window
            battle.Show();

            


        }
    }
}