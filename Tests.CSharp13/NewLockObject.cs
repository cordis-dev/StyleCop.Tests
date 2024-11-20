using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.CSharp13
{
    internal class NewLockObject
    {
        private System.Threading.Lock myLock = new System.Threading.Lock();

        public void MyMethod()
        {
            lock (myLock)
            {
                // Your code
            }
        }
    }
}
