using System;

namespace BilletSystemLibrary
{
    public class Bil
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        /// <summary>
        /// Metoden retunerer prisen for en bil.
        /// </summary>
        /// <returns></returns>
        public static decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// Metoden retunerer kæretøjstypen
        /// </summary>
        /// <returns></returns>
        public static string Køretøj()
        {
            return "Bil";
        }
    }
}
