using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BtlCalc1.View
{
    /// <summary>
    /// Interaction logic for Battle1v1.xaml
    /// </summary>
    public partial class Battle1v1 : Window
    {
        public Battle1v1()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();

        }
    }
}
