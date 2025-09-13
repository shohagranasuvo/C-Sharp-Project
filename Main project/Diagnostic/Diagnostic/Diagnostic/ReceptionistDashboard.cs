using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostic
{
    public partial class ReceptionistDashboard : Form
    {
        string name;
        FormLogIn mainWindow;
        public ReceptionistDashboard(string UserName , FormLogIn LogIn )
        {
            this.name = UserName;
            this.mainWindow = LogIn;

            
            
            InitializeComponent();

            this.lblWelcomeName.Text +=", "+UserName.ToUpper();

            Receptionist receptionistGridView = new Receptionist();
            this.pnlforUcReceptionist.Controls.Add(receptionistGridView);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            mainWindow.Visible = true;
        }

        private void lblDashBoard_Click(object sender, EventArgs e)
        {
            this.pnlforUcReceptionist.Controls.Clear(); 
            Receptionist receptionistGridView = new Receptionist();
            this.pnlforUcReceptionist.Controls.Add(receptionistGridView);
        }

        private void lblPatientReg_Click(object sender, EventArgs e)
        {
            this.pnlforUcReceptionist.Controls.Clear();
           UcRegisterPatient registerPatient = new UcRegisterPatient();
            this.pnlforUcReceptionist.Controls.Add(registerPatient);
        }

        private void ReceptionistDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
