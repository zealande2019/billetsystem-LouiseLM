using System;
using System.Collections.Generic;
using System.Text;

namespace BilletSystemLibrary
{
    public abstract class Køretøj
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        /// <summary>
        /// Metoden retunerer prisen for et køretøj.
        /// </summary>
        /// <returns></returns>
        public abstract decimal Pris();

        /// <summary>
        /// Metoden retunerer køretøjstypen
        /// </summary>
        /// <returns></returns>
        public abstract string KøretøjType();
    }
}
