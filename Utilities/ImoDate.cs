namespace ISO_Manager.Utilities
{
    public class ImoDate
    {

        public static Int32 GetAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            return today.Year - dateOfBirth.Year;
         
        }
    }
}
