using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> selectedDates = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CalendarModul calendarModul = new CalendarModul();

            string date = calendarModul.AddDateTolist(ChooseCalendar.SelectedDate.Value.ToString(), selectedDates);

            if (date != "0")
            {
                ListBox.Items.Add(date);
                selectedDates.Add(date);
            }
            else
            {
                MessageBox.Show("Already reserved");
            }
        }
    }
}
