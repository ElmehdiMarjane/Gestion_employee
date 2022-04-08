using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gestion.Models
{
    class Work
    {
        private int Num;
        private String Employe { get; set; }
        private String Client { get; set; }
        private string Technique { get; set; }
        private string Vehicule { get; set; }
        private DateTime Date { get; set; }
        private DateTime Entree { get; set; }
        private DateTime Exit { get; set; }
        private int Overtime { get; set; }


        public Work(String employe ="", String client = "", String technique = "",String vhicule = "", DateTime date = default(DateTime), DateTime entree = default(DateTime), DateTime exit= default(DateTime), int overtime=0)
        {
            try { 
            this.Employe = employe;
            this.Client = client;
            this.Technique = technique;
            this.Vehicule = vhicule;
            this.Date = date;
            this.Entree = entree;
            this.Exit = exit;
            this.Overtime = overtime;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Veuillez remplir tous les champs ");

            }
            string _file = @".\Data\Works.xml";
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
            this.Num = doc.Descendants("Work").Count() + 1;
        }

        public void saveWork()
        {
            string _file = @".\Data\Works.xml";
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
                new XElement("Work",
                    new XElement("Num", this.Num),
                    new XElement("Client", this.Client),
                    new XElement("Employe",this.Employe),
                    new XElement("Operation",this.Technique),
                    new XElement("Vehicule", this.Vehicule),
                    new XElement("Date",this.Date.ToShortDateString()),
                    new XElement("Heure_entre",this.Entree.ToShortTimeString()),
                    new XElement("Heure_sorti",this.Exit.ToShortTimeString()),
                    new XElement("Heures_supplémentaires", this.Overtime.ToString())
                    )
                );
            doc.Save(_file);

        }

    }
}
