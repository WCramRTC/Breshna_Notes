using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breshna_Notes
{
    internal class Student
    {

        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;

        public double Average()
        {
            return (_csiGrade + _genEdGrade) / 2.0;
        }

    }
}
