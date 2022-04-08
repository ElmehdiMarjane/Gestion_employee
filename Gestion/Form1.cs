using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Gestion
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AddEmployee a = new AddEmployee();
            a.Show();
            
             

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AddClient a = new AddClient();
            a.Show();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Visualiser a = new Visualiser();
            a.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Checkin a = new Checkin();
            a.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            AddOperation a = new AddOperation();
            a.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            AddVehicle a = new AddVehicle();
            a.Show();
        }
    }
}
