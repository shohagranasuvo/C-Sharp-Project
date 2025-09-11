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
        public AdminInterface(string name  , FormLogIn LogInPage)
        {
            this.name = name;
            this.LogInPage = LogInPage;
            InitializeComponent();
            this.lblWelcome.Text += this.name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
