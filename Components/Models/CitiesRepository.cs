namespace ServerManagment.Components.Models
{
    public class CitiesRepository
    {

        public static List<string> Cities = new List<string>()
        {
            "Toronto",
            "Montreal",
            "Ottawa",
            "Calgary",
            "Halifax"
        };

        public static List<string> GetCeties() => Cities;
    }
}
