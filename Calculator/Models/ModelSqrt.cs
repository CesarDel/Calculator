using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Models
{
    class ModelSqrt
    {
        private Result Result;
        public ModelSqrt(Parameter a)
        {
            double Par1 = a.getValue(); // put the first value on Par1

            this.Result = new Result(Math.Sqrt(Par1));  //makes the calculation and puts it in the variable Result
        }

        public Result getResult() { return this.Result; } // method to return the value of Result

    }
}
