﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureExample
    {
        /*
        6. This method uses an if statement to define what to return. Have it
            return true if the if statement passes.
            TOPIC: Conditional Logic
        */
        public bool ReturnTrueFromIf()
        {
            // This is to avoid multiple return statements.
            bool result = false;

            if (true)
            {
                result = true;
            }

            return result;
        }
    }
}
