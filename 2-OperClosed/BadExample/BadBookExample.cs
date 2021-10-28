using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OperClosed.BadExample
{
    public enum BookGenre { History = 1, Novel = 2, Poem = 3 };
    public class BadBookExample
    {
        
        public string ChooseGenre(BookGenre bookGenre)
        {
            string x;

            if (bookGenre==BookGenre.History)
            {
                  x=  "you choose history ";
            }
            else if (bookGenre == BookGenre.Novel)
            {
                 x= "you choose Novel ";
            }
            else if (bookGenre == BookGenre.Poem)
            {
                x ="you choose Poem ";
            }
            return x;
        }
    }
    
}
