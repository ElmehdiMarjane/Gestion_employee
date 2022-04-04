using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gestion.Models
{
    class Client
    {
        private int Id { get; set; }
        private String Name { get; set; }


        //test
        public Client(String name)
        {
            this.Name = name;
            string _file = @"C:\Users\elmeh\source\repos\Gestion\Gestion\Data\Clients.xml";
            XDocument doc;

            if (!File.Exists(_file))
            {
                doc = new XDocument();
                doc.Add(new XElement("Clients"));
            }
            else
            {

                doc = XDocument.Load(_file);
            }
            this.Id = doc.Descendants("Employee").Count() + 1;


        }

        public void SaveClient()
        {
            string _file = @"C:\Users\elmeh\source\repos\Gestion\Gestion\Data\Clients.xml";
            XDocument doc;

            if (!File.Exists(_file))
            {
                doc = new XDocument();
                doc.Add(new XElement("Clients"));
            }
            else
            {
                
                doc = XDocument.Load(_file);
            }

            doc.Root.Add(
                  new XElement("Client",
                               new XElement("Id", this.Id),
                               new XElement("Name", this.Name)
                        )
                  );
            doc.Save(_file);

        }



    }
}
