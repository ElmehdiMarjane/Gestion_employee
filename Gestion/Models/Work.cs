using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gestion.Models
{
    class Work
    {

        private Employe Employe { get; set; }
        private Client Client { get; set; }
        private string Technique { get; set; }
        private DateTime Date { get; set; }
        private DateTime Entree { get; set; }
        private DateTime Exit { get; set; }
        private int Overtime { get; set; }


        public Work(Employe employe,Client client,String technique,DateTime date,DateTime entree,DateTime exit,int overtime)
        {
            this.Employe = employe;
            this.Client = client;
            this.Technique = technique;
            this.Date = date;
            this.Entree = entree;
            this.Exit = exit;
            this.Overtime = overtime;


        }

        public void saveWork()
        {
            string _file = @".\Data\Clients.xml";
            XDocument doc;

            if (!File.Exists(_file))
            {
                doc = new XDocument();
                doc.Add(new XElement("Works"));

            }
            else
            {
                doc = XDocument.Load(_file);
            }

            doc.Root.Add(
                new XElement("Work"),
                    new XElement("Employe",this.Employe.ToString()),
                    new XElement("Client",this.Client.ToString()),
                    new XElement("Technique",this.Technique),
                    new XElement("Date",this.Date.ToShortDateString()),
                    new XElement("Heure_entre",this.Entree.ToShortTimeString()),
                    new XElement("Heure_sorti",this.Exit.ToShortTimeString()),
                    new XElement("Heur_additionnelle", this.Overtime.ToString())
                );
                

        }

    }
}
