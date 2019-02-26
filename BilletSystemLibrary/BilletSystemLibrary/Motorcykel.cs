using System;
using System.Collections.Generic;
using System.Text;

namespace BilletSystemLibrary
{
    public class Motorcykel
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        /// <summary>
        /// Metoden retunerer prisen for en motorcykel.
        /// </summary>
        /// <returns></returns>
        public static decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// Metoden retunerer kæretøjstypen
        /// </summary>
        /// <returns></returns>
        public static string Køretøj()
        {
            return "Motorcykel";
        }
    }
}
