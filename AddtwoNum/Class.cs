using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AddtwoNum
{
    public class Class
    {
        

        public Class()
        {
        }
         
        /// <summary>
        /// Add two Numbers
        /// </summary>
        /// <param name="value1">provid string value1</param>
        /// <param name="value2">provid string value2</param>
        /// <returns></returns>
        public int Opertwonumbers(string value1,string value2,string oper)
        {
            int firstvalue=isNullChech(value1);
            int secondvalue=isNullChech(value2);              
            
            int result = 0;
            
            if (oper == "+")
            {
                result = firstvalue + secondvalue;
            }
            if (oper == "*")
            {
                result = firstvalue * secondvalue;
            }
            if (oper == "/")
            {
                result = firstvalue / secondvalue;
            }

            return result;  
        }
        /// <summary>
        /// string Null Chech
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int isNullChech(string value)
        {
            int result = 0;
            if(!string .IsNullOrEmpty(value))
            {
                result=Convert.ToInt32(value);
            }
            return result;
        }
    }
}
