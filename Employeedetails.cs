
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
    public partial class Employeedetails : BaseForm
    {
        string gender;
        DAL dal = new DAL();
        bool recfnd = false;
        public Employeedetails()
        {
            InitializeComponent();
            getmaxid();
        }
        private void getmaxid()
        {
            dal.isPROcall = true;
            dal.ClearParameters();
            dal.AddParameters("action", "getmax");
            dal.AddParameters("empid", "0");
            object MaxID = dal.GetID("sp_emp");
            dal.isPROcall = false;
            txtempid.Text = MaxID + ""; 

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
                    cmbgen.Text = rdr["gender"].ToString();
                    dtdob.Text = rdr["dob"].ToString();
                    rtxtadd.Text = rdr["emp_address"].ToString();
                    cmbdepart.Text = rdr["department_name"].ToString();
                    cmbdesign.Text = rdr["designation"].ToString();
                    txtmonsal.Text = rdr["monthly_salary"].ToString();

                }
                else
                {
                    txtempname.Text = "";
                    cmbgen.SelectedIndex = 0;
                    dtdob.Text = "";
                    rtxtadd.Text = "";
                    cmbdepart.SelectedIndex = 0;
                    cmbdesign.SelectedIndex = 0;
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
            if (MessageBox.Show("Do u want to save ?", "SaveEmp", MessageBoxButtons.YesNo) == DialogResult.No)
                return;



            string Query = $"insert into tbl_EmployeeDetails values( '{txtempid.Text}','{txtempname.Text}','{gender}','{dtdob.Text}','{rtxtadd.Text}','{cmbdepart.Text}','{cmbdesign.Text}','{txtmonsal.Text}')";
            dal.isPROcall = true;
            dal.ClearParameters();
            dal.AddParameters("empid", txtempid.Text);
            dal.AddParameters("empname", txtempname.Text);
            dal.AddParameters("gender", cmbgen.Text);
            dal.AddParameters("dob", dtdob.Text);
            dal.AddParameters("address", rtxtadd.Text);
            dal.AddParameters("department", cmbdepart.Text);
            dal.AddParameters("designation", cmbdesign.Text);
            dal.AddParameters("monthlysalary", txtmonsal.Text);

            if (!recfnd)
            {
                dal.AddParameters("action", "insert");
            }
            else
            {
                dal.AddParameters("action", "update");
            }
            try
            {
                int res = dal.ExecuteQuery("sp_emp");
                if (res > 0)
                {
                    recfnd = false;
                    MessageBox.Show("Record save successfully!!");

                }
                dal.isPROcall = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void btncanc_Click(object sender, EventArgs e)
        {
            ClearControls(txtempid, Controls);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u want to delete ?", "DeleteEmp", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                if (recfnd)
                {
                    dal.isPROcall = true;
                    dal.ClearParameters();
                    dal.AddParameters("action", "delete");
                    dal.AddParameters("empid", txtempid.Text);
                    int res = dal.ExecuteQuery("sp_emp");
                    dal.isPROcall = false;

                    if (res > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully");
                        ClearControls(txtempid, Controls);


                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Selection().ShowDialog();
        }
    }
}
