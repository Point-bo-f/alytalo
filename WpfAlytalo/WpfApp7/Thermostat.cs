

namespace WpfApp7
{
    public class Thermostat
    {
        public bool Switched { get; set; }
            public int Temperature { get; set; }
        public void AsetaLampotila(int uusiLampotila)
        {
            if (uusiLampotila == 0)
            {
                Switched = false;
                Temperature = 0;
            }
            else
            {
                Switched = true;
                Temperature = uusiLampotila;
            }
        }
            
    }
}    

