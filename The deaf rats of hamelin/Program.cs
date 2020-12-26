using System;
using System.Text;

namespace The_deaf_rats_of_hamelin
{
    class Program
    {
        public static string[] GetW(int h)
        {
            if (h < 2) return new string[h];
            int row = 0;
            int stars_number = h * 4 - 3;
            int times = 0;
            StringBuilder[] c = new StringBuilder[h];
            for(int a = 0; a < h; a++)
            {
                c[a] = new StringBuilder();
                c[a].Length = stars_number;
            }
            for (int i = 0; i < stars_number; i++)
            {
                if (i == h - 1) times = 1;
                if (i == stars_number-2 * h + 1) times = 2;
                if (i == stars_number - h) times = 3;
                c[row][i] = '*';
                if (row < h - 1 && (times == 0 || times == 2))
                {
                    row += 1;
                    
                }
                else
                {
                    row -= 1;
                    
                }
                
            }
            string []str = new string[h];
            for(int i = 0; i < h; i ++)
            {
                c[i].Replace('\0', ' ');
                str[i] = c[i].ToString();
               
            }
            
            return str;
          
        }



            static void Main(string[] args)
        {
           
            foreach(string a in GetW(15))
            {

                Console.WriteLine(a);

            }
            Console.WriteLine("Hello");
            Console.ReadKey();
           

        }
    }
}
