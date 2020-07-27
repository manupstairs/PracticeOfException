using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeOfException
{
    class ClassA
    {
        public void MethodA()
        {
            new ClassB().MethodB();
        }
    }

    class ClassB
    {
        public void MethodB()
        {
            new ClassC().MethodC();
        }
    }

    class ClassC
    {
        public void MethodC()
        {
            throw new NotImplementedException();
        }
    }
}
