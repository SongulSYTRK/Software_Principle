using _1_SingleResponsibility.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SingleResponsibility.BadExample
{
    public class BadBook_Example
    {
       void InsertBook (Book book)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {    
                stringBuilder.Append(book.BookId);
                stringBuilder.AppendLine();
                stringBuilder.Append(book.BookName);
                stringBuilder.AppendLine();
                File.WriteAllText(@"C:/log.txt", stringBuilder.ToString());

                stringBuilder = new StringBuilder();
                stringBuilder.Append("İnsert Date");
                stringBuilder.AppendLine(DateTime.Now.ToString());
                stringBuilder.Append(book.BookId);
                File.WriteAllText(@"C:/ log.txt", stringBuilder.ToString());

                stringBuilder = new StringBuilder();
                stringBuilder.Append("");
                stringBuilder.AppendLine(DateTime.Now.ToString());
                stringBuilder.Append(book.BookId);
                File.WriteAllText(@"C:/ log.txt", stringBuilder.ToString());


            }
            catch (Exception exc)
            {

                stringBuilder = new StringBuilder();
                stringBuilder.Append(exc.Message);
                stringBuilder.AppendLine(DateTime.Now.ToString());
                File.WriteAllText(@"C:/log.txt", stringBuilder.ToString());
            }

        }

    }
}
