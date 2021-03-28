using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_endless_scroller
{
    class Trex
    {
        public bool saltando;
        public bool agachado;
        public int veloSalto;
        public int gravedad;
        public Trex()
        {
            saltando = false;
            agachado = false;
            veloSalto = 12;
            gravedad = 12;
        }
       public void SetStartPos()
        {
            saltando = false;
            agachado = false;
            veloSalto = 12; // setear a 12
            gravedad = 12;
        }
        public void Saltar()
        {
            if (saltando && gravedad < 0)
            {
                saltando = false;
            }
            if (saltando)
            {
                veloSalto = -12;
                gravedad -= 1;
            }
            else
            {
                veloSalto = 12;
            }
        }
        public void Agacharse()
        {
            if (agachado == false)
            {
                agachado = true;
            }            
            
        }
    }
}
