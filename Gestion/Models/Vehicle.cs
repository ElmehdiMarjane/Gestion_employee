using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gestion.Models
{
    class Vehicle
    {
        private int Id { get; set; }
        private String Name { get; set; }


        //test
        public Vehicle(String name)
        {
            this.Name = name;
            string _file = @".\Data\Vehicle.xml";
            XDocument doc;

            if (!File.Exists(_file))
            {
                doc = new XDocument();
                doc.Add(new XElement("Vehicle"));
            }
            else
            {

                doc = XDocument.Load(_file);
            }
            this.Id = doc.Descendants("Vehicle").Count() + 1;


        }

        public void SaveVehicle()
        {
            string _file = @".\Data\Vehicle.xml";
            XDocument doc;

            if (!File.Exists(_file))
            {
                doc = new XDocument();
                doc.Add(new XElement("Vehicles"));
            }
            else
            {

                doc = XDocument.Load(_file);
            }

            doc.Root.Add(
                  new XElement("Vehicle",
                               new XElement("num", this.Id),
                               new XElement("Name", this.Name)
                        )
                  );
            doc.Save(_file);

        }
    }
}
