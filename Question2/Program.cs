using System;
using System.Linq;
using System.Xml.Linq;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.RefText();
        }
    }

    class Solution
    {
        public void RefText()
        {
            try
            {
                XDocument doc = XDocument.Load("InputDocument.xml");

                var refCodeArray = new string[] { "MWB", "TRV", "CAR" };

                for (int i = 0; i < refCodeArray.Length; i++)
                {
                    var element = doc.Descendants().FirstOrDefault(x => (string)x.Attribute("RefCode") == refCodeArray[i]);

                    if(element != null)
                        Console.WriteLine(refCodeArray[i] + ": " + element.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
