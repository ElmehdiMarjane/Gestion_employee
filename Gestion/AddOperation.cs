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
    public partial class AddOperation : MetroFramework.Forms.MetroForm
    {
        public AddOperation()
        {
            InitializeComponent();
        }

        private void AddOperation_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Models.Operation Employe = new Models.Operation(metroTextBox1.Text);
            
            Employe.SaveOperation();
            MessageBox.Show("Ajouté avec succès");
            this.Close();
        }
    }
}
