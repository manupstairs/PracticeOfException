using System;

namespace PracticeOfException
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestNestedTryCatch();
            TestJustPrint();
        }

        private static void TestNestedTryCatch()
        {
            var nestedTryCatch = new NestedTryCatch();
            nestedTryCatch.OutsideMethodA();
        }

        private static async void TestJustPrint()
        {
            var justPrint = new JustPrintWhenException();
            await justPrint.DownloadContent(null);
        }
    }
}
