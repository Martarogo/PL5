using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcSystem;

namespace SistemaEcuaciones
{
    class Program
    {
        public static void Main(string[] args)
        {
            EcuationSystem ecSystem = new EcuationSystem();

            ecSystem.SolveSystem();
        }
    }
}
