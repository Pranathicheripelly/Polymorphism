using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   
            class Program
        {
            static void Main(string[] args)
            {
                runApp();
            }

            static void runApp()
            {

                BasicGradeCard elementaryCard = new ElementarySchoolGradeCard
            {
                StudentName = "Anoop",
                Year = 5,
                SchoolLevel = "Elementary",
                ElementaryInfo = "Elementary Grade Card Info"
            };

            BasicGradeCard middleCard = new MiddleSchoolGradeCard
            {
                StudentName = "Babu",
                Year = 8,
                SchoolLevel = "Middle School",
                MiddleSchoolInfo = "Middle School Grade Card Info"
            };

            BasicGradeCard highCard = new HighSchoolGradeCard
            {
                StudentName = "Chandu",
                Year = 11,
                SchoolLevel = "High School",
                HighSchoolInfo = "High School Grade Card Info"
            };

            DisplayGradeCardDetails(elementaryCard);
            DisplayGradeCardDetails(middleCard);
            DisplayGradeCardDetails(highCard);
        }

        static void DisplayGradeCardDetails(BasicGradeCard gradeCard)
        {
            gradeCard.DisplayGradeCard();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

}
  
