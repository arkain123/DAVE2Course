using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal interface ISave
    {
        List<object> Result { get; set; }
        void AddData((double x, double y) value);
        //void SolveByEuler();
        //void SolveByTrapezoidal();
        //void SolveByRungeKutta3();
        //void SolveByRungeKutta4();

        List<object> GetResult();
    }
}
