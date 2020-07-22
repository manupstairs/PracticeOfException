using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOfException
{
    class HttpClientRetry
    {
        public async Task<string> HandleHttpRequestExceptionAsync()
        {
            HttpClient client = new HttpClient();
            try
            {
                return await client.GetStringAsync("http://www.ajshdgasjhdgajdhgasjhdgasjdhgasjdhgas.tk/");
                
            }
            catch (HttpRequestException ex)
            {
                //Simulate to try again.
                //log here then retry
                return await client.GetStringAsync("http://www.dell.com/");
            }
            finally
            {
                client?.Dispose();
            }
        }
    }
}
