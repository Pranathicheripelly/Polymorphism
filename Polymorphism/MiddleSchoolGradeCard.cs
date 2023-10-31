using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class MiddleSchoolGradeCard:BasicGradeCard
    {

        public string MiddleSchoolInfo { get; set; }

        public override void DisplayGradeCard()
        {
            base.DisplayGradeCard();
            Console.WriteLine($"Middle School Info: {MiddleSchoolInfo}");
        }

    }
}
