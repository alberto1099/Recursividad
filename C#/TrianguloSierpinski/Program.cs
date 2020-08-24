using System;
using System.Drawing;

namespace TrianguloSierpinski
{
    class Program
    {
        private void Triangulo(int x1, int y1, int x2, int y2, int x3, int y3, Graphics g, int n)
        {
            if (n == 0)
            {
                SolidBrush b = new SolidBrush(Color.Teal);
                Point[] puntos = new Point[3];
                puntos[0] = new Point(x1, y1);
                puntos[1] = new Point(x2, y2);
                puntos[2] = new Point(x3, y3);
                g.FillPolygon(b, puntos);
            }
            else
            {
                int pm1x = (x1 + x2) / 2;
                int pm1y = (y1 + y2) / 2;
                int pm2x = (x1 + x3) / 2;
                int pm2y = (y1 + y3) / 2;
                int pm3x = (x2 + x3) / 2;
                int pm3y = (y2 + y3) / 2;
                Triangulo(x1, y1, pm1x, pm1y, pm2x, pm2y, g, n - 1);
                Triangulo(pm1x, pm1y, x2, y2, pm3x, pm3y, g, n - 1);
                Triangulo(pm2x, pm2y, pm3x, pm3y, x3, y3, g, n - 1);
            }
        }
        
        static void Main(string[] args)
        {

        }
    }
}
