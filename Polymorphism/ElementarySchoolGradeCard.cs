using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class ElementarySchoolGradeCard:BasicGradeCard
    {

        public string ElementaryInfo { get; set; }

        public override void DisplayGradeCard()
        {
            base.DisplayGradeCard();
            Console.WriteLine($"Elementary Info: {ElementaryInfo}");
        }

    }
}
