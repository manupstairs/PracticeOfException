using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace PracticeOfException
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //TestNestedTryCatch();
            //TestJustPrint();
            // TestRetryWhenException();
            TopLevelTryCatch();

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

        private static void TopLevelTryCatch()
        {
            try
            {
                new ClassA().MethodA();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
