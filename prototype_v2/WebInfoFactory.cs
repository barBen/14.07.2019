﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace prototype_v2
{
    public class WebInfoFactory
    {
        static public string FormatBytes(long bytes)
        {
            string[] magnitudes =
                new string[] { "GB", "MB", "KB", "Bytes" };
            long max =
                (long)Math.Pow(1024, magnitudes.Length);

            return string.Format("{1:##.##} {0}",
                magnitudes.FirstOrDefault(
                    magnitude =>
                    bytes > (max /= 1024)) ?? "0 Bytes",
              (decimal)bytes / (decimal)max);
        }


        private static string WriteWebRequestSizeAsync(string url)
        {
            try
            {
                WebRequest webRequest =
                    WebRequest.Create(url);
                WebResponse response =
                    webRequest.GetResponseAsync().Result;
                using (StreamReader reader =
                    new StreamReader(
                        response.GetResponseStream()))
                {
                    string text =
                        reader.ReadToEndAsync().Result;
                    Console.WriteLine(
                        FormatBytes(text.Length));
                    return FormatBytes(text.Length);
                }
            }
            catch (WebException)
            {
                // ...
            }
            catch (IOException)
            {

                // ...
            }
            catch (NotSupportedException)
            {
                // ...
            }

            return "Failed...";
        }

        Dictionary<string, WebInfo> dictionary = new Dictionary<string, WebInfo>();

        public WebInfo CreateWebInfo(string url)
        {
            if (dictionary.ContainsKey(url))
            {
                return dictionary[url].clone();
            }
            else
            {
                DateTime newTimeStamp = DateTime.Now;
                string newSize = WriteWebRequestSizeAsync(url);
                WebInfo newWebInfo = new WebInfo(newTimeStamp, newSize, url);

                dictionary.Add(url, newWebInfo);

                return newWebInfo;
            }
        }
    }
}