using BtlCalc1.Models;
using BtlCalc1.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        //Data for player 1
        private string nameP1;
        private double hpP1; 
        private double atkP1;
        private double atkSpdP1;
        private double armorP1;

        //Data for player 2
        private string nameP2;
        private double hpP2;
        private double atkP2;
        private double atkSpdP2;
        private double armorP2;

        public Battle1v1()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();

        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve the text from the TextBoxes for Player 1
            nameP1 = TbName1.Text;
            string hpTextP1 = TbHP1.Text;
            string atkTextP1 = TbATK1.Text;
            string atkSpdTextP1 = TbAtkSpd1.Text;
            string armorTextP1 = TbArmor1.Text;

            // Retrieve the text from the TextBoxes for Player 2
            nameP2 = TbName2.Text;
            string hpTextP2 = TbHP2.Text;
            string atkTextP2 = TbATK2.Text;
            string atkSpdTextP2 = TbAtkSpd2.Text;
            string armorTextP2 = TbArmor2.Text;

            // Optionally, you can parse these values to integers or other types if needed
            if (double.TryParse(hpTextP1, out double hpP1) &&
                double.TryParse(atkTextP1, out double atkP1) &&
                double.TryParse(atkSpdTextP1, out double atkSpdP1) &&
                double.TryParse(hpTextP2, out double hpP2) &&
                double.TryParse(atkTextP2, out double atkP2) &&
                double.TryParse(atkSpdTextP2, out double atkSpdP2)) 
            {


                double.TryParse(armorTextP1, out double armorP1);
                double.TryParse(armorTextP2, out double armorP2);

                Unit p1 = new Unit(nameP1, hpP1, atkP1, armorP1, atkSpdP1);
                Unit p2 = new Unit(nameP2, hpP2, atkP2, armorP2, atkSpdP2);

                BattleResult1v1 result =  Battle1v1VM.Battle1v1(p1, p2);
                Trace.WriteLine(result);
                // Display the result in a MessageBox
                MessageBox.Show(result.ToString());

            }
            else
            {
                // Handle the case where parsing fails
                MessageBox.Show("Please enter valid numbers in all fields.");
            }
        }

        
    }
}
