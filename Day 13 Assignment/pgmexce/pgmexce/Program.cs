using System;

namespace pgmexce
{
    
        
            class Program
        {
            static void Main()
            {
                // Declares and assigns a string array.
                // ... Then implicitly casts to base class object.
                // ... Then assigns invalid element.
                string[] array1 = { "cat", "dog", "fish" };
                object[] array2 = array1;
                array2[0] = 5;
            }
        }



    }


