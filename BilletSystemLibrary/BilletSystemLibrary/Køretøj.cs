using System;
using System.Collections.Generic;
using System.Text;

namespace BilletSystemLibrary
{
    public abstract class Køretøj
    {
        public string _nummerplade;
        public DateTime Dato { get; set; }

        public string Nummerplade
        {
            get { return _nummerplade; }
            set
            {
                if (value.Length > 7 && !string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nummerpladen er ugyldig.");
                }
                _nummerplade = value;
            }
        }


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
