using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class BasicGradeCard
    {

        public string StudentName { get; set; }
        public int Year { get; set; }
        public string SchoolLevel { get; set; }

        public virtual void DisplayGradeCard()
        {
            Console.WriteLine($"Grade Card for {StudentName}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"School Level: {SchoolLevel}");
        }

    }
}
