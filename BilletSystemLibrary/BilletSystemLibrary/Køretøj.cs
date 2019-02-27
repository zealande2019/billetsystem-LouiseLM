using System;
using System.Collections.Generic;
using System.Text;

namespace BilletSystemLibrary
{
    public abstract class Køretøj
    {
        public string _nummerplade;
        public DateTime Dato { get; set; }
        private bool _brobizz;

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
        public virtual decimal Pris()
        {
            if (_brobizz == true)
            {
                return  5;
            }
            return 200;
        }

        /// <summary>
        /// Metoden retunerer køretøjstypen
        /// </summary>
        /// <returns></returns>
        public abstract string KøretøjType();

        public Køretøj(bool brobizz)
        {
            this._brobizz = brobizz;
        }
    }
}
