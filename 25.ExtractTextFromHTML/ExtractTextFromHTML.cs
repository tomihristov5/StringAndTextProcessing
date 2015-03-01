using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        static void Main()
        {
            string title = string.Empty;
            string htmlText = Console.ReadLine();
            if (htmlText.Contains("<title>"))
            {
                int start = htmlText.IndexOf("<title>") + 7;
                int end = htmlText.IndexOf("</title>");
                title = htmlText.Substring(start, end - start);
                htmlText = htmlText.Substring(end + 8);
            }
            while (htmlText.Contains("</a>"))
            {
                htmlText = htmlText.Replace("<a", " <x");
                htmlText = htmlText.Replace("a>", "x> ");
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(htmlText);
            while (sb.ToString().Contains("<") || sb.ToString().Contains(">"))
            {
                int start = sb.ToString().IndexOf("<");
                int end = sb.ToString().IndexOf(">");
                sb.Remove(start, end - start + 1);
            }
            string text = sb.ToString().Trim();
            if (title != string.Empty)
            {
                Console.WriteLine("Title: " + title);
            }
            Console.WriteLine("Text: " + text);
        }
    }
}
