﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_5
{
    internal interface IOldInterface
    {
        void SaveMessage(string message)
        {}
        
        void SaveError(string error) 
        { }


    }
}
