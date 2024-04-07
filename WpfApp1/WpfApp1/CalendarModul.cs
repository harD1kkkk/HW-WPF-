using System.Collections.Generic;

namespace WpfApp1
{

    internal class CalendarModul
    {
        public string AddDateTolist(string date, List<string> selectedDates)
        {
            MainWindow mainWindow = new MainWindow();
            string selectedDate = date;

            if (selectedDates.Contains(selectedDate))
            {
                return "0";
            }
            return selectedDate;
        }
    }
}