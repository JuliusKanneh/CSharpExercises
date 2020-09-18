using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterThreeExercises
{
    //Application of how constructors and Deconstructors are called (Life Circle of Objects)
    public class ObjectLifeCycle
    {
        //Invoking Constructor
        public ObjectLifeCycle()
        {
            Console.WriteLine("Constructor Invoked.");
        }

        //Invoking Deconstructor
        ~ObjectLifeCycle()
        {
            Console.WriteLine("Deconstructor Invoked");
        }
    }
}
