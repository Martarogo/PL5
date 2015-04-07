using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcSystem
{
    public class EcuationSystem
    {
        public double[] SolveSystem(double[] system)
        {
            if (system.Length == 6)
            {
                double resultX, resultY;
                double a = system[0], b = system[1], c = system[3], d = system[4], e = system[2], f = system[5];

                if ((a * d) - (b * c) == 0)
                {
                    return new double[]{0};
                }
                else
                {
                    resultX = ((d * e) - (b * f)) / ((a * d) - (b * c));
                    
                    resultY = ((a * f) - (c * e)) / ((a * d) - (b * c));
                    
                    return new double[] { resultX, resultY };
                }
            }
            else if (system.Length == 12)
            {
                double resultX1, resultY1, resultZ1;
                double r = system[0], s = system[1], c1 = system[2], d1 = system[4], e1 = system[5], f1 = system[6], g1 = system[8], h1 = system[9], i1 = system[10], j1 = system[3], k1 = system[7], l1 = system[11];
                
                if ((r * ((e1 * i1) - (h1 * f1)) - s * ((d1 * i1) - (g1 * f1)) + c1 * ((d1 * h1) - (g1 * e1))) == 0)
                {
                    return new double[] { 0 };
                }
                else
                {
                    resultX1 = (j1 * ((e1 * i1) - (h1 * f1)) - s * ((k1 * i1) - (l1 * f1)) + c1 * ((k1 * h1) - (l1 * e1))) / (r * ((e1 * i1) - (h1 * f1)) - s * ((d1 * i1) - (g1 * f1)) + c1 * ((d1 * h1) - (g1 * e1)));
                    
                    resultY1 = (r * ((k1 * i1) - (l1 * f1)) - j1 * ((d1 * i1) - (g1 * f1)) + c1 * ((d1 * l1) - (g1 * k1))) / (r * ((e1 * i1) - (h1 * f1)) - s * ((d1 * i1) - (g1 * f1)) + c1 * ((d1 * h1) - (g1 * e1)));
                    
                    resultZ1 = (r * ((e1 * l1) - (h1 * k1)) - s * ((d1 * l1) - (g1 * k1)) + j1 * ((d1 * h1) - (g1 * e1))) / (r * ((e1 * i1) - (h1 * f1)) - s * ((d1 * i1) - (g1 * f1)) + c1 * ((d1 * h1) - (g1 * e1)));

                    return new double[] { resultX1, resultY1, resultZ1 };
                }
            }
            return new double[] { 1 };
        }
    }
}
