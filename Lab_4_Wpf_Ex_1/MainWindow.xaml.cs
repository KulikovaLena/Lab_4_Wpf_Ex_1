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

namespace Lab_4_Wpf_Ex_1
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
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro * sumEuro;
            resSum1.Text = resEuro.ToString();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateHryvnia = Convert.ToDouble(rate2.Text);
            double sumHryvnia = Convert.ToDouble(sum2.Text);
            double resHryvnia = rateHryvnia * sumHryvnia;
            resSum2.Text = resHryvnia.ToString();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate3.Text);
            double sumDram = Convert.ToDouble(sum3.Text);
            double resDram = rateDram * sumDram;
            resSum3.Text = resDram.ToString();
        }

        private void Button_Click_Inches(object sender, RoutedEventArgs e)
        {
            double rateInches = Convert.ToDouble(inches.Text);
            double metrInches = Math.Round(rateInches * 0.0254, 3);
            resInches.Text = metrInches.ToString();
        }
        private void Button_Click_Pounds(object sender, RoutedEventArgs e)
        {
            double ratePounds = Convert.ToDouble(pounds.Text);
            double metrPounds = Math.Round (ratePounds / 3.2808, 3);
            resPounds.Text = metrPounds.ToString();
        }
        private void Button_Click_Miles(object sender, RoutedEventArgs e)
        {
            double rateMiles = Convert.ToDouble(miles.Text);
            double metrMiles = rateMiles * 1609.34;
            resMiles.Text = metrMiles.ToString();
        }
        private void Button_Click_Verst(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(verst.Text);
            double metrVerst = rateVerst * 1066.8;
            resVerst.Text = metrVerst.ToString();
        }
    }
}
