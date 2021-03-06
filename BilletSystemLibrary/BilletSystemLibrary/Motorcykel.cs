﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BilletSystemLibrary
{
    public class Motorcykel : Køretøj
    {
        /// <summary>
        /// Metoden retunerer prisen for en motorcykel.
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// Metoden retunerer køretøjstypen
        /// </summary>
        /// <returns></returns>
        public override string KøretøjType()
        {
            return "Motorcykel";
        }
    }
}
