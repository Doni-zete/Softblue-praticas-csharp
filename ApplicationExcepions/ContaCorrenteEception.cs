using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationExcepions
{

    
    public class ContaCorrente : Exception
    {
        public ContaCorrente() { }
        public ContaCorrente(string message) : base(message) { }
        public ContaCorrente(string message, Exception inner) : base(message, inner) { }
       
    }
}
