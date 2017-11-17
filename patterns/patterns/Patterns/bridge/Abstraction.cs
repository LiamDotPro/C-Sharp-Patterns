using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Patterns.bridge
{
    class Abstraction
    {
        IBridge bridge;

        public Abstraction(IBridge Implemntation) {
            bridge = Implemntation;
        }

        public string Operation() {
            return bridge.OperationImp();
        }
    }
}
