using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeOfException
{
    class NestedTryCatch
    {
        internal void OutsideMethodA()
        {
            try
            {
                this.InsideMethodB();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void InsideMethodB()
        {
            try
            {
                this.ExceptionMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ExceptionMethod() 
        {
            throw new NotImplementedException("You did't implement this method!");
        }
    }
}
