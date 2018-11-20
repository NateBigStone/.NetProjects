using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculatorForm
{
    public class Calculator
    {
        private decimal currentValue;
        private string operation;
        private List<decimal> valueList = new List<decimal> { };

        public Calculator() { }

        public Calculator(decimal currentValue)
        {
            this.CurrentValue = currentValue;
        }
        public decimal CurrentValue
        {
            get
            {
                return currentValue;
            }
            set
            {
               valueList.Add(value);
            }
        }

        public void Add()
        {
            operation = "add";
        }
        public void Subtract()
        {
            operation = "subtract";
        }
        public void Multiply()
        {
            operation = "multiply";
        }
        public void Divide()
        {
            operation = "divide";
        }

        public decimal Equals()
        {
            if (operation == "add")
            {
                return valueList[valueList.Count - 2] + valueList[valueList.Count-1];
            }
            else if (operation == "subtract")
            {
                return valueList[valueList.Count - 2] - valueList[valueList.Count - 1]; ;
            }
            else if (operation == "multiply")
            {
                return valueList[valueList.Count - 2] * valueList[valueList.Count - 1]; ;
            }
            else if (operation == "divide")
            {
                return valueList[valueList.Count - 2] / valueList[valueList.Count - 1]; ;
            }
            else
            {
                return 0;
            }
        }


    }
}
