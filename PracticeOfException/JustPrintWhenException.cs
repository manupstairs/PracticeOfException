using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOfException
{
    class JustPrintWhenException
    {
        internal async Task<string> DownloadContent(string uri)
        {
            //Debug.Assert(!string.IsNullOrEmpty(uri));

            //if (string.IsNullOrEmpty(uri))
            //{
            //    throw new ArgumentNullException("uri is null");
            //}

            try
            {
                using (var httpClient = new HttpClient())
                {
                    return await httpClient.GetStringAsync(uri);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
