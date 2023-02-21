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

namespace WpfApp
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

        private void GENERATEClick(object sender, RoutedEventArgs e)
        {
            string Num = "";

            //format = 24.02.2023


            int Year = DatePickerBirthdayS.SelectedDate.Value.Year;
            int Month = DatePickerBirthdayS.SelectedDate.Value.Month;
            int Day = DatePickerBirthdayS.SelectedDate.Value.Day;
            Random random = new Random();
            int ab = random.Next(7, 10);
            

            if (RByes.IsChecked != false)
            {
                if (Year >= 1900 && Year <= 1949)
                {
                    Num = Num + "1";
                }
                else if (Year >= 1950 && Year <= 1999)
                {
                    Num = Num + "2";
                }
                else if (Year >= 1800 && Year <= 1849)
                {
                    Num = Num + "3";
                }
                else if (Year >= 1850 && Year <= 1899)
                {
                    Num = Num + "4";
                }
                else if (Year >= 2000 && Year <= 2049)
                {
                    Num = Num + "5";
                }
                else if (Year >= 2050 && Year <= 2099)
                {
                    Num = Num + "6";
                }
            }
            else
            {
                Num = Num + ab.ToString();
            }

            Num = Num + Year.ToString().Substring(Year.ToString().Length - 2);
            Num = Num + Month.ToString();
            Num = Num + Day.ToString();
            MessageBox.Show(Num); //при 28 февраля 1980 резидент, 2802028
        }
    }
}
