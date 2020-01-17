using System;
using System.Linq;
using System.Xml.Linq;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.CheckXml();
        }
    }

    class Solution
    {
        public void CheckXml()
        {
            int returnValue = int.MinValue;

            try
            {
                //Question 3.a
                XDocument doc = XDocument.Load("InputDocument.xml");
                
                returnValue = 0;


                //Question 3.b
                var element = doc.Descendants().FirstOrDefault(x => (string)x.Attribute("Command") == "DEFAULT");

                if (element != null)
                    returnValue = -1;


                //Question 3.c
                var status = (string)doc.Descendants("DeclarationHeader").Elements("SiteID").FirstOrDefault();


            }
            catch (System.Xml.XmlException e)
            {
                Console.WriteLine("The file was not structured correctly:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
