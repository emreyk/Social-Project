﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Common
{
    public class DefaultCommon:IComman
    {
        //varsayılan davranıs
        public string GetCurrentUsername()
        {
            return "system";
        }
    }
}
