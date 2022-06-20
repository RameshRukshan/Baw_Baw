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
    public partial class Treatments : Form
    {
        string UserType;
        public Treatments(string type)
        {
            InitializeComponent();
            UserType = type;
        }

        private void Treatments_Load(object sender, EventArgs e)
        {
            if (UserType == "True")
            {
                btn_adoptions.Visible = false;
                btn_animals.Visible = true;
                btn_dashboard.Visible = true;
                btn_medicalCenter.Visible = false;
                btn_notification.Visible = false;
                btn_rescue.Visible = false;
                btn_rescueTeam.Visible = false;
                btn_treatments.Visible = true;
                btn_volunteers.Visible = false;
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard home = new Dashboard(UserType);
            home.Show();
        }

        private void btn_animals_Click(object sender, EventArgs e)
        {
            this.Close();
            Animal ani = new Animal(UserType);
            ani.Show();
        }

        private void btn_treatments_Click(object sender, EventArgs e)
        {
            this.Close();
            Treatments treat = new Treatments(UserType);
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
