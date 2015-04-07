using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcSystem;

namespace MathService
{
    public class Math : IMath
    {
        public bool Prime(int n)
        {
            bool prime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                }
            }
            return prime;
        }

        public Tuple Sum(Tuple t)
        {
            double[] sum = new double[1];
            sum[0] = 0;
            for (int i = 0; i < t.Data.Length; i++)
            {
                sum[0] += t.Data[i];
            }

            Tuple tSum = new Tuple();
            tSum.Name = "Suma";
            tSum.Data = sum;
            return tSum;
        }
                
        public double[] SolveSystem(double[] system)
        {
            EcuationSystem ecSystem = new EcuationSystem();

            if ((system.Length != 6) && (system.Length != 12))
            {
                return new double[]{0};
            }

            double[] nResult = ecSystem.SolveSystem(system);

            return nResult;
        }
    }
}