using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HurryDriver
{
    public partial class FormMenu : Form
    {
        public FormRoad R = new FormRoad(true);
        public FormMenu()
        {
            InitializeComponent();
        }


        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newgameB_Click(object sender, EventArgs e)
        {
            choosingMode();
        }


        public void choosingMode()
        {
            this.Controls.Remove(newgameB);

            this.Controls.Add(this.tillcrashB);
            this.Controls.Add(this.timeButton);


        }



        private void tillcrashB_Click(object sender, EventArgs e)
        {
            FormRoad R = new FormRoad(false);
            this.Hide();
            Cursor.Hide();
            R.ShowDialog();

            this.Controls.Remove(tillcrashB);
            this.Controls.Remove(timeButton);

            this.Controls.Add(newgameB);
            this.Show();

        }

        private void timeButton_Click(object sender, EventArgs e)
        {
            FormRoad R = new FormRoad(true);
            this.Hide();
            R.ShowDialog();

            this.Controls.Remove(tillcrashB);
            this.Controls.Remove(timeButton);

            this.Controls.Add(newgameB);
            this.Show();
        }
    }
}
