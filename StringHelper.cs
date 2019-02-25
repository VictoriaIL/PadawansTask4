using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if ( str == "")
            {
                throw new ArgumentException();
            }
            
            char[] arr = str.ToCharArray();
            char[] glas = "aeoui".ToCharArray();
            int count = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < glas.Length; ++j)
                {
                    if (arr[i] == glas[j])
                        count++;
                }
            }
            return count;
        }
    }
}
