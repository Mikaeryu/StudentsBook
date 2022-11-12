using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsBook
{
    public class RusEngDictionary
    {
        public String English { get; set; }
        public String Russian { get; set; }
        public String Transcription { get; set; }

        public RusEngDictionary(String englishWord, String russianWord, String transcription)
        {
            this.English = englishWord;
            this.Russian = russianWord;
            this.Transcription = transcription;

        }

        public static List<RusEngDictionary> GetDictionaryList()
        {
            return new List<RusEngDictionary>(new RusEngDictionary[24] {
            new RusEngDictionary("to work", "работать", "tuː wɜːk"),
            new RusEngDictionary("B.", "One", "34 West Fifth Street, Apartment 67"),
            new RusEngDictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),
            new RusEngDictionary("D.", "Three", "78 South Ninth Street, Apartment 10"),

            new RusEngDictionary("A.", "Zero", "12 North Third Street, Apartment 45"),
            new RusEngDictionary("B.", "One", "34 West Fifth Street, Apartment 67"),
            new RusEngDictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),
            new RusEngDictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),

            new RusEngDictionary("A.", "Zero", "12 North Third Street, Apartment 45"),
            new RusEngDictionary("B.", "One", "34 West Fifth Street, Apartment 67"),
            new RusEngDictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),
            new RusEngDictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),

            new RusEngDictionary("A.", "Zero", "12 North Third Street, Apartment 45"),
            new RusEngDictionary("B.", "One", "34 West Fifth Street, Apartment 67"),
            new RusEngDictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),
            new RusEngDictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),

            new RusEngDictionary("A.", "Zero", "12 North Third Street, Apartment 45"),
            new RusEngDictionary("B.", "One", "34 West Fifth Street, Apartment 67"),
            new RusEngDictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),
            new RusEngDictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),

            new RusEngDictionary("A.", "Zero", "12 North Third Street, Apartment 45"),
            new RusEngDictionary("B.", "One", "34 West Fifth Street, Apartment 67"),
            new RusEngDictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),
            new RusEngDictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),



        });
        }
    }
}
