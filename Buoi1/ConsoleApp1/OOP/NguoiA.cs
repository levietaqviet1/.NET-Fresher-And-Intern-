using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class NguoiA : IAction
    {
        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Chan()
        {
            Console.WriteLine("Di chan A");
        }
    }
}
