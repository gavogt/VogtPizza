﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    abstract class Pizza : IPizza
    {
        public abstract string GetDescription();

        public abstract int GetCost();

    }
}
