using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;

namespace Proyecto
{
    class Escenario
    {
        Vector3 centroMasa1, centroMasa2;        
        List<IGraficarObject> ob;
        public Escenario()
        {
            this.centroMasa1 = new Vector3(-170, -75, -5);
            this.centroMasa2 = new Vector3(0, 0, -5);                                    
            this.ob=new List<IGraficarObject>{
              new Silla(centroMasa1, ancho: 50, alto: 50, profundidad: 50),
              new Mesa(centroMasa2, ancho: 50, alto: 50, profundidad: 50)
            };
        }

        public void DibujarEscenario()
        {
            foreach(var objeto in ob){
                objeto.Dibujar();
            }
        }
    }
}
