using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gestion.Models
{
    class Employe
    {
        private int Id { get; set; }
        private String Firstname { get; set; }
        private String Lastname { get; set; }


        public Employe(String firstName, String  lastName)
        {
            string _file = @"C:\Users\elmeh\source\repos\Gestion\Gestion\Data\Employes.xml";
            XDocument doc;
            if(!File.Exists(_file))
            {
                doc = new XDocument();
                doc.Add(new XElement("Employes"));
            }
            else
            {

                doc = XDocument.Load(_file);
            }
            this.Id=doc.Descendants("Employee").Count()+1;
            this.Firstname = firstName;
            this.Lastname = lastName;

        }

        public void SaveEmployee()
        {
            string _file = @"C:\Users\elmeh\source\repos\Gestion\Gestion\Data\Employes.xml";
            XDocument doc;

            if (!File.Exists(_file))
            {
                doc = new XDocument();
                doc.Add(new XElement("Employes"));
            }
            else
            {

                doc = XDocument.Load(_file);
            }

            doc.Root.Add(
                  new XElement("Employee",
                               new XElement("Id", this.Id),
                               new XElement("First_name", this.Firstname),
                               new XElement("Last_name", this.Lastname)
                        )
                  );
            doc.Save(_file);


        }


        public override string ToString()
        {
            return this.Id.ToString();
        }
    }
}
