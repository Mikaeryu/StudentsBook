using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsBook
{
    public class Dictionary
    {
        public String English { get; set; }
        public String Russian { get; set; }
        public String Transcription { get; set; }

        public Dictionary(String englishWord, String russianWord, String transcription)
        {
            this.English = englishWord;
            this.Russian = russianWord;
            this.Transcription = transcription;

        }

        public static List<Dictionary> GetDictionaryList()
        {
            return new List<Dictionary>(new Dictionary[24] {
            new Dictionary("to work", "работать", "tuː wɜːk"),
            new Dictionary("B.", "One", "34 West Fifth Street, Apartment 67"),
            new Dictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),
            new Dictionary("D.", "Three", "78 South Ninth Street, Apartment 10"),

            new Dictionary("A.", "Zero", "12 North Third Street, Apartment 45"),
            new Dictionary("B.", "One", "34 West Fifth Street, Apartment 67"),
            new Dictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),
            new Dictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),

            new Dictionary("A.", "Zero", "12 North Third Street, Apartment 45"),
            new Dictionary("B.", "One", "34 West Fifth Street, Apartment 67"),
            new Dictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),
            new Dictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),

            new Dictionary("A.", "Zero", "12 North Third Street, Apartment 45"),
            new Dictionary("B.", "One", "34 West Fifth Street, Apartment 67"),
            new Dictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),
            new Dictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),

            new Dictionary("A.", "Zero", "12 North Third Street, Apartment 45"),
            new Dictionary("B.", "One", "34 West Fifth Street, Apartment 67"),
            new Dictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),
            new Dictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),

            new Dictionary("A.", "Zero", "12 North Third Street, Apartment 45"),
            new Dictionary("B.", "One", "34 West Fifth Street, Apartment 67"),
            new Dictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),
            new Dictionary("C.", "Two", "56 East Seventh Street, Apartment 89"),



        });
        }
    }
}
