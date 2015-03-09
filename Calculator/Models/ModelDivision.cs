using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class ModelDivision
    {

        private Result Result;
        public ModelDivision(Parameter a, Parameter b)
        {

            double Par1 = a.getValue();

            double Par2 = b.getValue();
            
            this.Result = new Result((double)Par1 / Par2);

        }

        public Result getResult() { return this.Result; }




    }
}
