using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_struct_enum_inheritance
{
    // enum is a set of constant values
    enum GenderEnum // any variable of type GenderEnum can have only Male or Female value
    {
        // enum is used to make restrictions to the values
        // enum is value type
        Male, Female // Male has int value = 0, Female has int value = 1 (for storing in memory)
    }
    enum ITIBranch
    {
        Smart = 100, Alex = 200, Zagazig = 3000, Asuit, Mansoura
    }
    enum Color 
    {
        Red = 1, // numbers in this example need to be doubles of 2 (1, 2, 4, 8, 16)>>> so as to use "or" operator to make combination (only one digit equals 1 in the number in binary ex: 0001,0010,0100,1000)
        Green = 2,
        Blue = 4,
    }
}
