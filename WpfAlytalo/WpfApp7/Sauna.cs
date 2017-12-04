using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WpfApp7
{
    public class Sauna
    {

        public bool Switched {get; set;}

        public void SaunaPaalle()

        {
        Switched = true;
        }
        public void SaunaPois()
        {
        Switched = false;
        }
    }

}
