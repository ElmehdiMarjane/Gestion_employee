using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class AddVehicle : MetroFramework.Forms.MetroForm
    {
        public AddVehicle()
        {
            InitializeComponent();
            
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Models.Vehicle Employe = new Models.Vehicle(metroTextBox1.Text);

            Employe.SaveVehicle();
            MessageBox.Show("Ajouté avec succès");
            this.Close();
        }
    }
}
