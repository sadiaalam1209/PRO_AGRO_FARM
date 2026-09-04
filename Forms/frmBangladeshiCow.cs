using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Agro_farm.Forms
{
    public partial class frmBangladeshiCow : Form
    {
        public frmBangladeshiCow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Takes the user back to the previous page (frmCow).
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure?", "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            // No -> remain on this page, do nothing.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnType1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmBanglaType1 typeForm = new frmBanglaType1())
            {
                typeForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                // Keep skipping upward, past this page, straight to frmMainManu.
                this.Close();
                return;
            }

            this.Show();
        }

        private void btnType2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmBanglaType2 typeForm = new frmBanglaType2())
            {
                typeForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                // Keep skipping upward, past this page, straight to frmMainManu.
                this.Close();
                return;
            }

            this.Show();
        }

        private void btnType3_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmBanglaType3 typeForm = new frmBanglaType3())
            {
                typeForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                // Keep skipping upward, past this page, straight to frmMainManu.
                this.Close();
                return;
            }

            this.Show();
        }

        private void btnType4_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmBanglaType4 typeForm = new frmBanglaType4())
            {
                typeForm.ShowDialog();
            }

            if (Pro_Agro_farm.NavFlow.ReturnToDashboard)
            {
                // Keep skipping upward, past this page, straight to frmMainManu.
                this.Close();
                return;
            }

            this.Show();
        }
    }
}