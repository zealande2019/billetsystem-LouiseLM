using System;

namespace BilletSystemLibrary
{
    public class Bil : Køretøj
    {
        /// <summary>
        /// Metoden retunerer prisen for en bil.
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// Metoden retunerer køretøjstypen
        /// </summary>
        /// <returns></returns>
        public override string KøretøjType()
        {
            return "Bil";
        }
    }
}
