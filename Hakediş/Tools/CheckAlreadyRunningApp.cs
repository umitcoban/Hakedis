﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakediş
{
   static class CheckAlreadyRunningApp
    {
        public static bool CheckApp()
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
