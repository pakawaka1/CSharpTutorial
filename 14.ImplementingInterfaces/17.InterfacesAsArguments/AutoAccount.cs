﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _17.InterfacesAsArguments
{
    public class AutoAccount : Account, ITransferable
    {
        public void Transfer()
        {
            Console.WriteLine("Auto Transfer Completed...");
        }
    }
}
