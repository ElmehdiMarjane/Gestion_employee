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
    public partial class Checkin : MetroFramework.Forms.MetroForm
    {

        string _Clients = @".\Data\Clients.xml";
        string _Employees = @".\Data\Employes.xml";
        string _Operation = @".\Data\Operation.xml";
        string _Vehicle = @".\Data\Vehicle.xml";
        public Checkin()
        {
            InitializeComponent();
            
            metroDateTime1.Format = DateTimePickerFormat.Custom;
            metroDateTime1.CustomFormat = "HH:mm"; // Only use hours and minutes
            metroDateTime1.ShowUpDown = true;
            metroDateTime2.Format = DateTimePickerFormat.Custom;
            metroDateTime2.CustomFormat = "HH:mm"; // Only use hours and minutes
            metroDateTime2.ShowUpDown = true;
            
        }

        private void Checkin_Load(object sender, EventArgs e)
        {
            //Populating Combobox Employee
            XElement Employe = XElement.Load(_Employees);
            var EmployeeList = (
                from client in Employe.Elements("Employee")
                select new
                {

                    firstName = client.Element("First_name").Value,
                    lastName = client.Element("Last_name").Value

                }).ToList();


            foreach (var te in EmployeeList)
            {

                metroComboBox1.Items.Add(te.firstName+" "+te.lastName);
            }

            //Populating Combobox Client
            XElement Clients = XElement.Load(_Clients);
            var ClientList = (
                from client in Clients.Elements("Client")
                select new
                {

                    Name = client.Element("Name").Value

                }).ToList();


            foreach (var te in ClientList)
            {

                metroComboBox2.Items.Add(te.Name);
            }

            //Populating Combobox Operation
            XElement Operations = XElement.Load(_Operation);
            var OperationList = (
                from Operation in Operations.Elements("Operation")
                select new
                {

                    Name = Operation.Element("Name").Value

                }).ToList();


            foreach (var te in OperationList)
            {

                metroComboBox3.Items.Add(te.Name);
            }

            //Populating Combobox Vehicule
            XElement Vehicles = XElement.Load(_Vehicle);
            var VehicleList = (
                from Vehicle in Vehicles.Elements("Vehicle")
                select new
                {

                    Name = Vehicle.Element("Name").Value

                }).ToList();


            foreach (var te in VehicleList)
            {

                metroComboBox4.Items.Add(te.Name);
            }


        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try {

                Models.Work newWork = new Models.Work(metroComboBox1.SelectedItem.ToString(), metroComboBox2.SelectedItem.ToString(), metroComboBox3.Text,metroComboBox4.Text, metroDateTime3.Value, metroDateTime1.Value, metroDateTime2.Value, int.Parse(metroTextBox2.Text));
                newWork.saveWork();
                MessageBox.Show("Ajouté avec succès");
                this.Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez remplir tous les champs ");

            }
            

        }
    }
}
