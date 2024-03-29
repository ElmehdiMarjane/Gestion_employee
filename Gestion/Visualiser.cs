﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MetroFramework.Controls;


namespace Gestion
{
    public partial class Visualiser : MetroFramework.Forms.MetroForm
    {
        static string _Works = @".\Data\Works.xml";
        XElement Works = XElement.Load(_Works);
        
       
            
        public Visualiser()
        {
            InitializeComponent();
            
        }

        public void populate()
        {
            var _Worklist = (
                from Work in Works.Elements("Work")
                select new
                {
                    Num = Work.Element("Num").Value,
                    Client_depot_port = Work.Element("Client").Value,
                    Employe = Work.Element("Employe").Value,
                    Operation = Work.Element("Operation").Value,
                    Vehicule = Work.Element("Vehicule").Value,
                    Date = Work.Element("Date").Value,
                    Heure_Debut = Work.Element("Heure_entre").Value,
                    Heure_Fin = Work.Element("Heure_sorti").Value,
                    Heures_Add = Work.Element("Heures_supplémentaires").Value,
                    
                }).ToList();

            metroGrid1.DataSource = _Worklist;


        }
        private void Visualiser_Load(object sender, EventArgs e)
        {
            
            populate();


        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            metroGrid1.Refresh();
          
            var _Worklist = (
                from Work in Works.Elements("Work")
                where (string)Work.Element("Date") == metroDateTime1.Value.ToShortDateString()
                select new
                {
                    Num = Work.Element("Num").Value,
                    Client_depot_port = Work.Element("Client").Value,
                    Employe = Work.Element("Employe").Value,
                    Operation = Work.Element("Operation").Value,
                    Vehicule = Work.Element("Vehicule").Value,
                    Date = Work.Element("Date").Value,
                    Heure_Debut = Work.Element("Heure_entre").Value,
                    Heure_Fin = Work.Element("Heure_sorti").Value,
                    Heures_Add = Work.Element("Heures_supplémentaires").Value,
                    

                }).ToList();

            metroGrid1.DataSource = _Worklist;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

           
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
          
                if (metroTextBox1.Text == "")
                {
                populate();


                }
                else
                {
                    string name = metroTextBox1.Text;
                    
                    metroGrid1.Refresh();

                    var _Worklist = (
                        from Work in Works.Elements("Work")
                        where ((string)Work.Element("Client")).StartsWith(name, StringComparison.InvariantCultureIgnoreCase)
                        select new
                        {
                            Num = Work.Element("Num").Value,
                            Client_depot_port = Work.Element("Client").Value,
                            Employe = Work.Element("Employe").Value,
                            Operation = Work.Element("Operation").Value,
                            Vehicule = Work.Element("Vehicule").Value,
                            Date = Work.Element("Date").Value,
                            Heure_Debut = Work.Element("Heure_entre").Value,
                            Heure_Fin = Work.Element("Heure_sorti").Value,
                            Heures_Add = Work.Element("Heures_supplémentaires").Value,
                            

                        }).ToList();

                    metroGrid1.DataSource = _Worklist;
                } 
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox2.Text == "")
            {
                populate();


            }
            else
            {
                string name = metroTextBox2.Text;
                
                metroGrid1.Refresh();

                var _Worklist = (
                    from Work in Works.Elements("Work")
                    where ((string)Work.Element("Employe")).StartsWith(name, StringComparison.InvariantCultureIgnoreCase)
                    select new
                    {
                        Num = Work.Element("Num").Value,
                        Client_depot_port = Work.Element("Client").Value,
                        Employe = Work.Element("Employe").Value,
                        Operation = Work.Element("Operation").Value,
                        Vehicule = Work.Element("Vehicule").Value,
                        Date = Work.Element("Date").Value,
                        Heure_Debut = Work.Element("Heure_entre").Value,
                        Heure_Fin = Work.Element("Heure_sorti").Value,
                        Heures_Add = Work.Element("Heures_supplémentaires").Value,
                        

                    }).ToList();

                metroGrid1.DataSource = _Worklist;
            }
        }

        private void metroGrid1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

          
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            try {
                

                string target = metroGrid1.SelectedRows[0].Cells["Num"].Value.ToString();
                IEnumerable<XElement> elList =
                from el in Works.Elements("Work")
                where ((string)el.Element("Num") == target)
                select el;


                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    elList.Remove();
                    MessageBox.Show("Supprimer avec succès ");
                    populate();
                    Works.Save(_Works);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
                
            }
            catch(Exception es)
            {
                MessageBox.Show("Selectioner une ligne");
            }
          
        }
    }

}
