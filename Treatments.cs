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
    }
}
