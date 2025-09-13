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
    public partial class AdminInterface : Form
    { private string name { set; get; }
        private FormLogIn LogInPage     { set; get; }
        public AdminInterface(string name, FormLogIn LogInPage)
        {
            this.name = name;
            this.LogInPage = LogInPage;
            InitializeComponent();
            this.lblWelcome.Text += this.name;
            FirstDashBoardView();
            
        }
            
            //this.pnlUserControl.Controls.Clear();


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible= false;
            this.LogInPage.Visible =true;
        }
        public void FirstDashBoardView()
        {
            this.pnlUserControl.Controls.Clear();

            UcAdminDashBoard ucAdminDashBoard = new UcAdminDashBoard();
            ucAdminDashBoard.Dock = DockStyle.Fill;
            this.pnlUserControl.Controls.Add(ucAdminDashBoard);

        }

        private void lblAdminUsers_Click(object sender, EventArgs e)
        {
           
            //UcReciptionist ucReciptionist =new UcReciptionist();

            //this.pnlUserControl.Controls.Clear();
            //this.pnlUserControl.Controls.Add(ucReciptionist);
            UcAdminAdd AA =new UcAdminAdd();
            this.pnlUserControl.Controls.Clear();
            
            this.pnlUserControl.Controls.Add(AA);
            
            

        }

        private void lblAdminDashboard_Click(object sender, EventArgs e)
        {
            FirstDashBoardView();

        }
    }
}
