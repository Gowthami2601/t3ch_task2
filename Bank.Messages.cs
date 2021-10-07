using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BankCon
{
    class Bank
    {
        public string GetStringInput()
        {
            return Console.ReadLine();
        }
        public int GetIntInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public int StringInt(string s)
        {
            return Convert.ToInt32(s);
        }
    }
}
