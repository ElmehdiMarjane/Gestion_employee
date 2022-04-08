using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gestion.Models
{
    class Operation
    {

        private int Id { get; set; }
        private String Name { get; set; }


        //test
        public Operation(String name)
        {
            this.Name = name;
            string _file = @".\Data\Operation.xml";
            XDocument doc;

            if (!File.Exists(_file))
            {
                doc = new XDocument();
                doc.Add(new XElement("Operation"));
            }
            else
            {

                doc = XDocument.Load(_file);
            }
            this.Id = doc.Descendants("Operation").Count() + 1;


        }

        public void SaveOperation()
        {
            string _file = @".\Data\Operation.xml";
            XDocument doc;

            if (!File.Exists(_file))
            {
                doc = new XDocument();
                doc.Add(new XElement("Operations"));
            }
            else
            {

                doc = XDocument.Load(_file);
            }

            doc.Root.Add(
                  new XElement("Operation",
                               new XElement("num", this.Id),
                               new XElement("Name", this.Name)
                        )
                  );
            doc.Save(_file);

        }

    }
}
