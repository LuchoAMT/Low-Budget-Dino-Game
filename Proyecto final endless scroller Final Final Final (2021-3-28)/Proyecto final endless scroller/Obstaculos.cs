using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_endless_scroller
{
    class Obstaculos
    {
        public int veloObst;
        public Random rndm = new Random();
        public Obstaculos()
        {
            veloObst = 10;
        }
        public void SetStartVel()
        {
            veloObst = 10;
        }
        
    }
}
