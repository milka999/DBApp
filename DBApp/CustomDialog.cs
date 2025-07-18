using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApp
{
    public partial class CustomDialog : Form
    {
        public CustomDialog(string caption, string question)
        {
            InitializeComponent();
            this.Text = caption;
            this.lblDialogQuestion.Text = question;

            this.btnYes.Click += BtnYes_Click;
            this.btnNo.Click += BtnNo_Click;
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            // this.parent.dialogResult = DialogEnum.NE; 
            this.DialogResult = DialogResult.No; 
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;  
            // Ova linija bi trebala da zatvori formu sama 
        }
    }
}
