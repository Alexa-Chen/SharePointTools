using System;
using System.IO;
using System.Net;

namespace SharePointTools.Utility
{
    public class WebDownload
    {
        public static void DownLoad(string Url, string FileName)
        {
            var Value = false;
            WebResponse response = null;
            Stream stream = null;

            try
            {
                var request = (HttpWebRequest)WebRequest.Create(Url);

                response = request.GetResponse();
                stream = response.GetResponseStream();

                if (!response.ContentType.ToLower().StartsWith("text/"))
                {
                    Value = SaveBinaryFile(response, FileName);

                }

            }
            catch (Exception err)
            {
                var aa = err.ToString();
            }

        }

        /// <summary>
        /// Save a binary file to disk.
        /// </summary>
        /// <param name="response">The response used to save the file</param>
        // 将二进制文件保存到磁盘
        private static bool SaveBinaryFile(WebResponse response, string FileName)
        {
            var value = true;
            var buffer = new byte[1024];

            try
            {
                if (File.Exists(FileName))
                    File.Delete(FileName);
                Stream outStream = System.IO.File.Create(FileName);
                var inStream = response.GetResponseStream();

                int l;
                do
                {
                    l = inStream.Read(buffer, 0, buffer.Length);
                    if (l > 0)
                        outStream.Write(buffer, 0, l);
                }
                while (l > 0);

                outStream.Close();
                inStream.Close();
            }
            catch
            {
                value = false;
            }
            return value;
        }

        public static void Saveimage(string url, string filepath)
        {
            var client = new WebClient();
            client.UseDefaultCredentials = true;
            try
            {
                client.DownloadFile(url, filepath);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
