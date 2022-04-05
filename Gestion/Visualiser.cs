using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gestion
{
    public partial class Visualiser : MetroFramework.Forms.MetroForm
    {
        string _Works = @".\Data\Works.xml";
        public Visualiser()
        {
            InitializeComponent();
        }

        private void Visualiser_Load(object sender, EventArgs e)
        {
            //Populating Combobox Employee
            XElement Works = XElement.Load(_Works);
            var _Worklist = (
                from Work in Works.Elements("Work")
                select new
                {

                    Employe = Work.Element("Employe").Value,
                    Client = Work.Element("Client").Value,
                    Technique = Work.Element("Technique").Value,
                    Date = Work.Element("Date").Value,
                    Heure_entre = Work.Element("Heure_entre").Value,
                    Heure_sorti = Work.Element("Heure_sorti").Value,
                    Heur_additionnelle = Work.Element("Heur_additionnelle").Value

                }).ToList();

            metroGrid1.DataSource = _Worklist;
           
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            metroGrid1.Refresh();
            XElement Works = XElement.Load(_Works);
            var _Worklist = (
                from Work in Works.Elements("Work")
                where (string)Work.Element("Date") == metroDateTime1.Value.ToShortDateString()
                select new
                {

                    Employe = Work.Element("Employe").Value,
                    Client = Work.Element("Client").Value,
                    Technique = Work.Element("Technique").Value,
                    Date = Work.Element("Date").Value,
                    Heure_entre = Work.Element("Heure_entre").Value,
                    Heure_sorti = Work.Element("Heure_sorti").Value,
                    Heur_additionnelle = Work.Element("Heur_additionnelle").Value

                }).ToList();

            metroGrid1.DataSource = _Worklist;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

           
        }
    }
}
