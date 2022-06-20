using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baw_Baw
{
    public partial class Notifications : Form
    {
        public Notifications()
        {
            InitializeComponent();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard home = new Dashboard("Flase");
            home.Show();
        }

        private void btn_animals_Click(object sender, EventArgs e)
        {
            this.Close();
            Animal ani = new Animal("False");
            ani.Show();
        }

        private void btn_treatments_Click(object sender, EventArgs e)
        {
            this.Close();
            Treatments treat = new Treatments("Faalse");
            treat.Show();
        }

        private void btn_medicalCenter_Click(object sender, EventArgs e)
        {
            this.Close();
            MedicalCenter mc = new MedicalCenter();
            mc.Show();
        }

        private void btn_rescueTeam_Click(object sender, EventArgs e)
        {
            this.Close();
            RescueTeam rc = new RescueTeam();
            rc.Show();
        }

        private void btn_rescue_Click(object sender, EventArgs e)
        {
            this.Close();
            Rescue res = new Rescue();
            res.Show();
        }

        private void btn_volunteers_Click(object sender, EventArgs e)
        {
            this.Close();
            Volunteers vol = new Volunteers();
            vol.Show();
        }

        private void btn_adoptions_Click(object sender, EventArgs e)
        {
            this.Close();
            Adoptions ado = new Adoptions();
            ado.Show();
        }

        private void btn_notification_Click(object sender, EventArgs e)
        {
            this.Close();
            Notifications noti = new Notifications();
            noti.Show();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }
    }
}
