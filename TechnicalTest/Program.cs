using System;
using System.Collections.Generic;
using System.IO;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            s.ParseEDIFACT();
        }
    }

    class Solution
    {
        public void ParseEDIFACT()
        {
            var line = string.Empty;
            var result = new List<string>();

            try
            {
                using StreamReader sr = new StreamReader("EDIFACTMsg.txt");

                while ((line = sr.ReadLine()) != null)
                {
                    string[] segment = line.Split("+");

                    if (segment[0] == "LOC")
                    {
                        try
                        {
                            result.Add(segment[1]);
                            result.Add(segment[2].Replace("&#39;", "'"));
                        }
                        catch
                        {
                            Console.WriteLine("Invalid data structure");
                        }
                    }
                }

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}

