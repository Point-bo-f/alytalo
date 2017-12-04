using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace WpfApp7
{
    public class Lights
    {
        public bool Switched { get; set; }

        public String Dimmer { get; set; }

        public void ValotPois()
        {
         Switched = false;
         Dimmer = "0%";
        }
        public void Valot33(int Valonmaara)
        {
            Switched = true;
            Dimmer = Valonmaara.ToString();
        }
        public void Valot66(int Valonmaara)
        {
            Switched = true;
            Dimmer = Valonmaara.ToString();
        }
        public void Valot100(int Valonmaara)
        {
             Switched = true;
             Dimmer = Valonmaara.ToString();
        }
    }
}
