using System.Text.RegularExpressions;

namespace StarterKit.Application.Util
{
    public class CommonLib
    {
        public static string ConvertTimeToMonthDayYear(DateTime date)
        {
            return date.ToString("MMMM dd, yyyy");
        }


        public static bool IsValidNonZeroNumber(int input)
        {
            return input != 0;
        }

        public static string ConvertTitleToSlug(string title)
        {

            //remove special characters except spaces
            title = Regex.Replace(title, @"[^a-zA-Z0-9 ]+", "");
            title = title.ToLower();
            title = title.Replace(" ", "-");

            return DateTime.Now.ToString("yyyy-MM-dd-") + title;

        }

        public static List<string> ConvertStringToWordList(string tagNames)
        {

            List<string> tags = tagNames.Split().ToList();

            return tags;

        }

        public static List<string> RemoveDuplicateWordsFromList(List<string> tagsList)
        {
            List<string> uniqueTags = tagsList.Distinct().ToList();

            return uniqueTags;
        }



    }
}
