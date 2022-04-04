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
    public partial class AddEmployee : MetroFramework.Forms.MetroForm
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Models.Employe Employe = new Models.Employe(metroTextBox1.Text, metroTextBox2.Text);
            MessageBox.Show(Employe.ToString());
            Employe.SaveEmployee();
            

        }
    }
}
