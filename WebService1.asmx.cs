using System;
using System.IO;
using System.Web.Services;
using System.Xml;

namespace AMB_SOAP_WS_CS
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int RunValid() // Uses valid xml file
        {
            // load the xml file
            XmlDocument doc = new XmlDocument(); // creating xml doc object
            string path1 = AppDomain.CurrentDomain.BaseDirectory; // current project directory
            string path2 = @"Data\Valid.xml"; // specifying xml document
            string Full_Path = Path.Combine(path1, path2); // combining paths
            doc.Load(Full_Path); // loading xml data
            return TestXML(doc);
        }

        [WebMethod]
        public int RunInvalidCommand() // uses xml file with invalid command value
        {
            // load the xml file
            XmlDocument doc = new XmlDocument();
            string path1 = AppDomain.CurrentDomain.BaseDirectory;
            string path2 = @"Data\InvalidCommand.xml";
            string Full_Path = Path.Combine(path1, path2);
            doc.Load(Full_Path);
            return TestXML(doc);
        }

        [WebMethod]
        public int RunInvalidSiteID() // uses xml file with invalid site id value
        {
            // load the xml file
            XmlDocument doc = new XmlDocument();
            string path1 = AppDomain.CurrentDomain.BaseDirectory;
            string path2 = @"Data\InvalidSiteID.xml";
            string Full_Path = Path.Combine(path1, path2);
            doc.Load(Full_Path);
            return TestXML(doc);
        }

        public int TestXML(XmlDocument doc) // test structure of xml file
        {

            // Get elements
            XmlNodeList Declaration = doc.GetElementsByTagName("Declaration");
            XmlNodeList SiteID = doc.GetElementsByTagName("SiteID");

            // Initialise variables
            string Command = "";
            string Site_ID = "";

            // Gather Command value from declaration node
            foreach (XmlNode elem in Declaration)
            {
                Command = elem.Attributes["Command"].Value;
            }

            // Gather SiteID value 
            foreach (XmlNode elem in SiteID)
            {
                Site_ID = elem.InnerText;
            }

            if (Command != "DEFAULT")
            {
                return -1; // invalid command specified
            }
            else if (Site_ID != "DUB")
            {
                return -2; // invalid Site specified
            }
            else
            {
                return 0; // document was structured correctly
            }
        }
    }
}