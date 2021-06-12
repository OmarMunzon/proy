using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;
namespace Proyecto
{
    class Mesa:IGraficarObject
    {
        float x, y, z;
        Vector3 colour, centro;

        public Mesa(Vector3 Centro,float ancho,float alto,float profundidad)
        {
            this.centro.X = Centro.X * 0.01f; 
            this.centro.Y = Centro.Y * 0.01f;
            this.centro.Z = Centro.Z;
            this.x = ancho * 0.01f;
            this.y = alto * 0.01f;
            this.z = profundidad * 0.01f;

            this.colour = new Vector3(0.8f, 0.5f, 0.5f);//cafe
        }

        public void Dibujar()
        {
            GL.PushMatrix();
            tabla();
            patas();
            GL.PopMatrix();
        }

        void tabla()
        {
            //GL.Begin(PrimitiveType.Quads);
            //GL.Color3(this.colour.X, this.colour.Y, this.colour.Z);
            //GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z);
            //GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z);
            //GL.Vertex3(centro.X - x, centro.Y + y / 2, centro.Z + z);
            //GL.Vertex3(centro.X + x, centro.Y + y / 2, centro.Z + z);
            //GL.End();
            
            //top
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(this.colour.X, this.colour.Y, this.colour.Z);      
            GL.Vertex3(centro.X - 2 * x, centro.Y, centro.Z - 2*z);
            GL.Vertex3(centro.X - 2 * x, centro.Y - y / 2 + 0.10, centro.Z + z - 0.10);
            GL.Vertex3(centro.X + 2 * x, centro.Y - y / 2 + 0.10, centro.Z + z - 0.10);
            GL.Vertex3(centro.X + 2 * x, centro.Y, centro.Z - 2*z);
            GL.End();

            //bottom            
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(this.colour.X, this.colour.Y, this.colour.Z);            
            GL.Vertex3(centro.X - 2 * x, centro.Y, centro.Z - 2 * z);
            GL.Vertex3(centro.X - 2 * x, centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X + 2 * x, centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X + 2 * x, centro.Y, centro.Z - 2 * z);
            GL.End();

            //front
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(this.colour.X, this.colour.Y, this.colour.Z);
            GL.Vertex3(centro.X + 2 * x, centro.Y - y / 2 + 0.10, centro.Z + z - 0.10);
            GL.Vertex3(centro.X - 2 * x, centro.Y - y / 2 + 0.10, centro.Z + z - 0.10);            
            GL.Vertex3(centro.X - 2 * x, centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X + 2 * x, centro.Y - y / 2, centro.Z + z);
            GL.End();

            //back
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(this.colour.X, this.colour.Y, this.colour.Z);
            GL.Vertex3(centro.X + 2 * x, centro.Y, centro.Z - 2 * z);
            GL.Vertex3(centro.X - 2 * x, centro.Y, centro.Z - 2 * z);
            GL.Vertex3(centro.X - 2 * x, centro.Y, centro.Z - 2 * z);            
            GL.Vertex3(centro.X + 2 * x, centro.Y, centro.Z - 2 * z);            
            GL.End();

            //right
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(this.colour.X, this.colour.Y, this.colour.Z);
            GL.Vertex3(centro.X + 2 * x, centro.Y, centro.Z - 2 * z);
            GL.Vertex3(centro.X + 2 * x, centro.Y - y / 2 + 0.10, centro.Z + z - 0.10);
            GL.Vertex3(centro.X + 2 * x, centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X + 2 * x, centro.Y, centro.Z - 2 * z);
            GL.End();

            //left
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(this.colour.X, this.colour.Y, this.colour.Z);
            GL.Vertex3(centro.X - 2 * x, centro.Y, centro.Z - 2 * z);
            GL.Vertex3(centro.X - 2 * x, centro.Y - y / 2 + 0.10, centro.Z + z - 0.10);
            GL.Vertex3(centro.X - 2 * x, centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X - 2 * x, centro.Y, centro.Z - 2 * z);            
            GL.End();

        }

        void patas()
        {
            //p1 back
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(this.colour.X, this.colour.Y, this.colour.Z);
            GL.Vertex3(centro.X - 2 * x + 0.15, centro.Y, centro.Z - 2 * z);
            GL.Vertex3(centro.X - 2 * x, centro.Y, centro.Z - 2 * z);            
            GL.Vertex3(centro.X - 2 * x , centro.Y - 2*y, centro.Z - 2 * z);
            GL.Vertex3(centro.X - 2 * x + 0.15, centro.Y - 2*y, centro.Z - 2 * z);
            GL.End();
            //p2 front
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(this.colour.X, this.colour.Y, this.colour.Z);
            GL.Vertex3(centro.X - 2 * x + 0.15, centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X - 2 * x, centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X - 2 * x, centro.Y - 2*y, centro.Z + z);
            GL.Vertex3(centro.X - 2 * x + 0.15, centro.Y - 2*y , centro.Z + z);            
            GL.End();

            //p3 front
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(this.colour.X, this.colour.Y, this.colour.Z);
            GL.Vertex3(centro.X + 2 * x, centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X + 2 * x - 0.15, centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X + 2 * x - 0.15, centro.Y - 2*y, centro.Z + z);
            GL.Vertex3(centro.X + 2 * x, centro.Y - 2*y, centro.Z + z);
            GL.End();

            //p4 back
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(this.colour.X, this.colour.Y, this.colour.Z);
            GL.Vertex3(centro.X + 2 * x, centro.Y, centro.Z - 2 * z);
            GL.Vertex3(centro.X + 2 * x-0.15, centro.Y, centro.Z - 2 * z);
            GL.Vertex3(centro.X + 2 * x - 0.15, centro.Y-2*y, centro.Z - 2 * z);
            GL.Vertex3(centro.X + 2 * x, centro.Y-2*y, centro.Z - 2 * z);
            GL.End();
        }

    }//end class
}
