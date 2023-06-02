using System;
using System.Collections.Generic;
using System.Linq;

namespace AS19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Initialize the Collection

            List<Student> students = new List<Student>()
            {
new Student("Jaakko Laaksonen", "Sammonkatu 5", new DateTime(1995, 11, 23)),
new Student("Minna Jaakkola", "Patteristonkatu 10", new DateTime(1991, 10, 25)),
new Student("Asko Liukkonen", "Kettukuja 15", new DateTime(1976, 03, 11)),
new Student("Elina Savela", "Kasarminkatu 20", new DateTime(2001, 07, 14)),
new Student("Santeri Kilpeläinen", "Porrassalmenkatu 25", new DateTime(1968, 12, 18)),
new Student("Sari Karasti", "Saimaannorpantie 30", new DateTime(1985, 04, 15)),
new Student("Marja Kosonen", "Saattotie 35", new DateTime(1957, 08, 12)),
new Student("Riiko Lappalainen", "Savilahdenkatu 40", new DateTime(2002, 05, 20)),
new Student("Onerva Rantanen", "Jääkärinkatu 13", new DateTime(1988, 08, 18)),
new Student("Tuulia Tuominen", "Kuistinkuja 47", new DateTime(1979, 11, 12)),
new Student("Pyry Ojala", "Suur-Savonkatu 7", new DateTime(1994, 06, 23)),
new Student("Touko Hiltunen", "Tykkimiehenkatu 17", new DateTime(1965, 12, 12)),
new Student("Kerkko Kauppinen", "Sointukatu 12", new DateTime(1963, 06, 06)),
new Student("Visa Lahti", "Brahenkatu 9", new DateTime(1959, 09, 29)),
new Student("Ohto Lahti", "Brahenkatu 7", new DateTime(1958, 08, 16)),
new Student("Vanamo Lindholm", "Arkistokatu 91", new DateTime(1966, 09, 22)),
new Student("Kuisma Vuorinen", "Hanhikankaankatu 29", new DateTime(1988, 01, 01)),
new Student("Päivö Mäki", "Kokkomäenkatu 3", new DateTime(1992, 12, 02)),
new Student("Salla Laukkanen", "Laiturikatu 59", new DateTime(2000, 11, 09)),
            };


            //To find oldest of family Lahti.
            /*   var chosen = (from item in students
                        orderby item.DateOfBirth ascending
                        where item.Name.Contains("Lahti")
                        select item).FirstOrDefault();

          if (chosen != null)
          {
              Console.WriteLine("Name:{0}", chosen.Name);
          } */

            // To find true or false

            int year = 1986;
            var query =students.Where(item => item.DateOfBirth.Year >= year);
            if (query.Count() == students.Count())
                Console.Write("Are all students born after the {0}?\n True",year);
                
            else
          
                Console.WriteLine("Were all students born after the {2}?\n False", query.Count(),students.Count(),year);
                    

        }
    }
}
