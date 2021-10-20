using _1_SingleResponsibility.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SingleResponsibility.GoodExample
{
   public  class GoodBookInsert
    {


        public GoodLog goodLog;

        public GoodBookInsert() 
        {
            goodLog = new GoodLog();
        }
        
            
        string log;
        public bool insert(Book book)
        {
                StringBuilder stringBuilder = new StringBuilder();
                try
                {
                    stringBuilder.Append(book.BookId);
                    stringBuilder.AppendLine();
                    stringBuilder.Append(book.BookName);
                    stringBuilder.AppendLine();
                    

                    log = goodLog.BuildLog(stringBuilder.ToString());
                    goodLog.LogFile(@"C:/log.txt", log);
                    return true;
                }
                catch (Exception exc)
                {

                    log = goodLog.BuildLog(exc.Message.ToString());
                    goodLog.LogFile(@"C:/log.txt", log);
                    return false;
                }

            }
    }
}
