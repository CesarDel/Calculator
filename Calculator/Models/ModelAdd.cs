using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class ModelAdd
    {
        private Result Result;
        public ModelAdd(Parameter a, Parameter b)
        {
            double Par1 = a.getValue(); // put the first value on Par1

            double Par2 = b.getValue();  // put the first value on Par2
            
            this.Result = new Result(Par1 + Par2);  //makes the calculation and puts it in the variable Result

        }

        public Result getResult() { return this.Result; } // method to return the value of Result

    }
}
