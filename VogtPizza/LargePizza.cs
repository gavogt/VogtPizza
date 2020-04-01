﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPizza
{
    class LargePizza : Pizza, IAddOnDecorator
    {
        public override int GetCost()
        {
            return 16;
        }

        public override string GetDescription()
        {
            return "Large pizza";
        }
    }
}
