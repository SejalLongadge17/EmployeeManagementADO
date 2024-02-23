using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormado
{
    public partial class Payroll : BaseForm
    {
        DAL dal = new DAL();
        bool recfnd = false;
        public Payroll()
        {
            InitializeComponent();
            cmbmonth.SelectedIndex = 0;
        }

        private void txtempid_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                dal.isPROcall = true;
                dal.ClearParameters();
                dal.AddParameters("action", "select");
                dal.AddParameters("empid", txtempid.Text);
                SqlDataReader rdr = dal.GetReader("sp_emp");
                dal.isPROcall = false;
                if (rdr != null && rdr.HasRows)
                {
                    recfnd = true;
                    rdr.Read();
                    txtempname.Text = rdr["emp_name"].ToString();
                    txtdepart.Text = rdr["department_name"].ToString();
                    txtdesign.Text = rdr["designation"].ToString();
                    txtmonsal.Text = rdr["monthly_salary"].ToString();
                }
                else
                {
                    txtempname.Text = "";
                    txtdepart.Text = "";
                    txtdesign.Text = "";
                    txtmonsal.Text = "";
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save?", "Save Payroll",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            dal.isPROcall = true;
            dal.ClearParameters();
            dal.AddParameters("empid", txtempid.Text);
            dal.AddParameters("empname", txtempname.Text);
            dal.AddParameters("department", txtdepart.Text);
            dal.AddParameters("designation", txtdesign.Text);
            dal.AddParameters("monthlysalary", txtmonsal.Text);
            dal.AddParameters("month", cmbmonth.Text);
            dal.AddParameters("totalworkingdays", txttwd.Text);
            dal.AddParameters("paidholidays", txtpaidholi.Text);
            dal.AddParameters("unpaidholidays", txtunpaidholi.Text);
            dal.AddParameters("totalattendance", txttotalattend.Text);
            dal.AddParameters("currentmonsal", txtcurrsal.Text);

            if (recfnd)
            {
                dal.AddParameters("action", "update");
            }

            try
            {
                int res = dal.ExecuteQuery("sp_emp");
                if (res > 0)
                {
                    recfnd = false;
                    MessageBox.Show("Record Saved Successfully");
                }
                dal.isPROcall = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            ClearControls(txtempid, Controls);
        }

        private void txttotalattend_Validating(object sender, CancelEventArgs e)
        {
            txtcurrsal.Text = ((Common.CInt(txtmonsal.Text) / Common.CInt(txttwd.Text)) *
               Common.CInt(txttotalattend.Text)).ToString();
        }



        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Selection().ShowDialog();
        }

        private void txtunpaidholi_Validating(object sender, CancelEventArgs e)
        {
            txttotalattend.Text = (Common.CInt(txttwd.Text) - Common.CInt(txtunpaidholi.Text)).ToString();
        }
    }
}
