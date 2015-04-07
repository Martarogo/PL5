using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace MathService
{
    [ServiceContract]
    public interface IMath
    {
        [OperationContract]
        bool Prime(int value);

        [OperationContract]
        Tuple Sum(Tuple t);

        [OperationContract]
        double[] SolveSystem(double[] system);
    }

    [DataContract]
    public class Tuple
    {
        double[] _data;
        string _name;

        [DataMember]
        public double[] Data
        {
            get { return _data; }
            set { _data = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
