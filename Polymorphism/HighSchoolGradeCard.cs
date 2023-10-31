using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class HighSchoolGradeCard : BasicGradeCard 
    {
        public string HighSchoolInfo { get; set; }

        public override void DisplayGradeCard()
        {
            base.DisplayGradeCard();
            Console.WriteLine($"High School Info: {HighSchoolInfo}");
        }

    }
}
