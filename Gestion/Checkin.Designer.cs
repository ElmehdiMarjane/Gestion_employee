
namespace Gestion
{
    partial class Checkin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime3 = new MetroFramework.Controls.MetroDateTime();
            this.metroComboBox4 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(20, 78);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "Employee";
            this.metroComboBox1.Size = new System.Drawing.Size(354, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(20, 114);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.PromptText = "Client";
            this.metroComboBox2.Size = new System.Drawing.Size(354, 29);
            this.metroComboBox2.TabIndex = 1;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.metroDateTime2.Location = new System.Drawing.Point(177, 316);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 326);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Heur de sortie";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(332, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(23, 370);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.PromptText = "Heures additionnelles";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(354, 23);
            this.metroTextBox2.TabIndex = 7;
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "Heures additionnelles";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 414);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(354, 71);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Check";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.metroDateTime1.Location = new System.Drawing.Point(175, 275);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroDateTime1.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 285);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Heure d\'entrée";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 239);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Date";
            // 
            // metroDateTime3
            // 
            this.metroDateTime3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime3.Location = new System.Drawing.Point(175, 229);
            this.metroDateTime3.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime3.Name = "metroDateTime3";
            this.metroDateTime3.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime3.TabIndex = 9;
            // 
            // metroComboBox4
            // 
            this.metroComboBox4.FormattingEnabled = true;
            this.metroComboBox4.ItemHeight = 23;
            this.metroComboBox4.Location = new System.Drawing.Point(20, 186);
            this.metroComboBox4.Name = "metroComboBox4";
            this.metroComboBox4.PromptText = "Véhicule";
            this.metroComboBox4.Size = new System.Drawing.Size(354, 29);
            this.metroComboBox4.TabIndex = 12;
            this.metroComboBox4.UseSelectable = true;
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Location = new System.Drawing.Point(20, 150);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.PromptText = "Operation";
            this.metroComboBox3.Size = new System.Drawing.Size(354, 29);
            this.metroComboBox3.TabIndex = 11;
            this.metroComboBox3.UseSelectable = true;
            // 
            // Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 496);
            this.Controls.Add(this.metroComboBox4);
            this.Controls.Add(this.metroComboBox3);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroDateTime3);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "Checkin";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Checkin";
            this.Load += new System.EventHandler(this.Checkin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime metroDateTime3;
        private MetroFramework.Controls.MetroComboBox metroComboBox4;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
    }
}