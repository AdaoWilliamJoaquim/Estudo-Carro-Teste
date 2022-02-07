using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoCarro
{
    public class carro
    {
        public bool on { get; set; }
        public string Name { get; set; }
        public int speed { get; set; }
      
        public bool retunTurnon()
        {
            return on;
        }
        public void Turnon()
        {
            on = true;

        }
        public void off()
        {
            on = false;
        }

        public void Aceleratecar()
        {
            speed+=3;

        }

        public void BreakCar()
        {
            speed--;

        }
        public void SetCarName(string name)
        {
            Name = name; 

        }
        public string ReturnCarName()
        {
            return Name;
;
        }

        public string ReturnSpeed()
        {
            return speed.ToString()+" MPH ";     
        }




    }
}
