using System;
using System.Threading.Tasks;

namespace PracticeOfException
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestNestedTryCatch();
            //TestJustPrint();
            TestRetryWhenException();
            Console.ReadKey();
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

        private static async void TestRetryWhenException()
        {
            var retryHandler = new HttpClientRetry();
            var respone = await retryHandler.HandleHttpRequestExceptionAsync();
            Console.WriteLine(respone);
        }
    }
}
