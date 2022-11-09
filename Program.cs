// See https://aka.ms/new-console-template for more information


namespace LongestPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = {"flower","flow","flight"};
            string res = LongestCommonPrefix(strs);

            Console.WriteLine(res);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string str_1 = strs[0];
            int len = str_1.Length;
            int ind = 0;
            foreach (string str in strs)
            {
                int j = 0;
                foreach (char c in str)
                {
                    if (j>=len || str_1[j] != c )
                    {
                        break;
                    } 
                    j+=1;              
                }            
                ind=j;            
            }                         
            return str_1.Substring(0,ind);
        }
    }
}
