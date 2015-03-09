using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class MainController
    {

        public static Result Add(Parameter a, Parameter b) {

            ModelAdd add1 = new ModelAdd(a, b);
                                    
            return add1.getResult(); 
        
        }

        public static Result Subtract(Parameter a, Parameter b)
        {

            ModelSubtract sub1 = new ModelSubtract(a, b);

            return sub1.getResult();
        }

        public static Result Multiply(Parameter a, Parameter b)
        {

            ModelMultiply mult1 = new ModelMultiply(a, b);

            return mult1.getResult();
        }

        public static Result Divide(Parameter a, Parameter b)
        {
            ModelDivision div1 = new ModelDivision(a, b);

            return div1.getResult();
        }                
    }
}
