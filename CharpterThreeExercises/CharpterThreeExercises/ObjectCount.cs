using System;
using System.Collections.Generic;
using System.Text;

namespace CharpterThreeExercises
{
    class ObjectCount
    {
        static int count;

        public ObjectCount()
        {
            count++;
        }

        public int Display()
        {
            return count;
        }


    }
}
