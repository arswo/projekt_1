using System;

namespace projekt_1
{
    class Program
    {
        static void Main()
        {

            
            //object name = "Andrey";					// storing a string in an object
            object age = 36;                        // storing an int in an object

            var age1 = (int)age;
            Console.WriteLine(age1);

                //		object height = 1.73;					// storing a double in an object
                //		// int length1 = name.Length;				// gives compile error!
                //		int age_1 = ((string)name).Length;	// cast to access members
        
        }

    }

}