using System;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace ConsoleApplication1
{
    class Program
    {
        private string GetTextFromPDF()
        {
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader(@"C:\Users\narendran.venkat\Desktop\Avastin_en_GB.pdf"))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            return text.ToString();
        }
        static void Main()
        {
            Program pdftotext = new Program();
            Console.WriteLine(pdftotext.GetTextFromPDF());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
