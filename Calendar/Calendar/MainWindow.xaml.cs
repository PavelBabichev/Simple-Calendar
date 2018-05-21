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

namespace Calendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Week week;
        public MainWindow()
        {
            InitializeComponent();
            treeWiev.SelectedItemChanged += treeWiev_SelectedItemChanged;
        }

        void treeWiev_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            string selectedMonth = (treeWiev.SelectedItem as TreeViewItem).Header.ToString();
            if (selectedMonth == "Январь") InitListWiev(1);
            else if (selectedMonth == "Февраль") InitListWiev(2);
            else if (selectedMonth == "Март") InitListWiev(3);
            else if (selectedMonth == "Апрель") InitListWiev(4);
            else if (selectedMonth == "Май") InitListWiev(5);
            else if (selectedMonth == "Июнь") InitListWiev(6);
            else if (selectedMonth == "Июль") InitListWiev(7);
            else if (selectedMonth == "Август") InitListWiev(8);
            else if (selectedMonth == "Сентябрь") InitListWiev(9);
            else if (selectedMonth == "Октябрь") InitListWiev(10);
            else if (selectedMonth == "Ноябрь") InitListWiev(11);
            else if (selectedMonth == "Декабрь") InitListWiev(12);

        }
        void InitListWiev(int numberOfMonth)
        {
            List<Week> month = new List<Week>();

            int i=0;
            int j = 0;
            DateTime date = new DateTime(2018, numberOfMonth, 1);
            int dayInMonth = DateTime.DaysInMonth(2018, numberOfMonth);
            int dayOfWeek = (int)date.DayOfWeek;
            switch (dayOfWeek)
            {
                case 1:
                    week = new Week("1", "2", "3", "4", "5", "6", "7");
                    i = 7;
                    break;
                case 2:
                    week = new Week("", "1", "2", "3", "4", "5", "6");
                    i = 6;
                    break;
                case 3:
                    week = new Week("", "", "1", "2", "3", "4", "5");
                    i = 5;
                    break;
                case 4:
                    week = new Week("", "", "", "1", "2", "3", "4");
                    i = 4;
                    break;
                case 5:
                    week = new Week("", "", "", "", "1", "2", "3");
                    i = 3;
                    break;
                case 6:
                    week = new Week("", "", "", "", "", "1", "2");
                    i = 2;
                    break;
                case 7:
                    week = new Week("", "", "", "", "", "", "1");
                    i = 1;
                    break;
                default:
                    break;
            }
            int numberFullWeek = (dayInMonth - i) / 7;
            int restOfDay = (dayInMonth - i) % 7;
            month.Add(week);
            while (j < numberFullWeek)
            {
                week = new Week((++i).ToString(), (++i).ToString(), (++i).ToString(), (++i).ToString(), (++i).ToString(), (++i).ToString(), (++i).ToString());
                j++;
                month.Add(week);
            }
            switch (restOfDay)
            {
                case 1:
                    week = new Week((++i).ToString(), "", "", "", "", "", "");
                    break;
                case 2:
                    week = new Week((++i).ToString(), (++i).ToString(), "", "", "", "", "");
                    break;
                case 3:
                    week = new Week((++i).ToString(), (++i).ToString(), (++i).ToString(), "", "", "", "");
                    break;
                case 4:
                    week = new Week((++i).ToString(), (++i).ToString(), (++i).ToString(), (++i).ToString(), "", "", "");
                    break;
                case 5:
                    week = new Week((++i).ToString(), (++i).ToString(), (++i).ToString(), (++i).ToString(), (++i).ToString(), "", "");
                    break;
                case 6:
                    week = new Week((++i).ToString(), (++i).ToString(), (++i).ToString(), (++i).ToString(), (++i).ToString(), (++i).ToString(), "");
                    break;
                default:
                    break;
            }
            month.Add(week);
            monthList.ItemsSource = month;
        }
    }
}
