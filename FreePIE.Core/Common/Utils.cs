﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using FreePIE.Core.Common.Extensions;

namespace FreePIE.Core.Common
{
    public static class Utils
    {
        public static IEnumerable<Type> GetTypes<T>()
        {
            return typeof (T).GetTypes();
        } 
    }
}
