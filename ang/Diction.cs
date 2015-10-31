using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ang
{
    class Diction
    {
        private string pol, eng;

        public string Eng
        {
            get { return eng; }
            set { eng = value; }
        }

        public string Pol
        {
            get { return pol; }
            set { pol = value; }
        }

        public Diction()
        {
            pol = eng = null;
        }
        public Diction(string Pol, string Eng)
        {
            pol = Pol;
            eng = Eng;
        }
    }
}
