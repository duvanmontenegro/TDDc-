using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class Resta
    {
        public object Operar(string num)
        {
            if (num.Equals(""))
                return 0;
            if (string.IsNullOrEmpty(num))
                throw new NotImplementedException();
            return num;
        }
    }
}
