using System.Globalization;

namespace ISO_Manager.Utilities
{
    public class DateToMiladi
    {
        public static DateTime ToMiladi(DateTime dateTime)
        {
            System.Globalization.GregorianCalendar PC = new System.Globalization.GregorianCalendar();
            PC.CalendarType = System.Globalization.GregorianCalendarTypes.USEnglish;
            Calendar persian = new PersianCalendar();

            return new DateTime(PC.GetYear(dateTime), PC.GetMonth(dateTime), PC.GetDayOfMonth(dateTime),persian);
            
        }
    }
}
