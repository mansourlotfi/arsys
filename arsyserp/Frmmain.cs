using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace arsyserp
{
    public partial class Frmmain : Telerik.WinControls.UI.RadForm
    {
        private void Namayesh()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=.;Initial Catalog=arsyserp;Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM[dbo].[Table_presentedco]";
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public Frmmain()
        {
            InitializeComponent();
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        private void Frmmain_Load(object sender, EventArgs e)
        {
            Namayesh();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (Txt_co_name.Text=="")
            {
                MessageBox.Show("لطفا نام شرکت را وارد نمایید");
                Txt_co_name.Focus();
                return ;

            }
            if (combo_work.Text == "")
            {
                MessageBox.Show("لطفا زمینه فعالیت شرکت را وارد نمایید");
                combo_work.Focus();
                return;
            }
            if (Txt_contact.Text == "")
            {
                MessageBox.Show("لطفا شماره تماس شرکت را وارد نمایید");
                Txt_contact.Focus();
                return;
            }

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=.;Initial Catalog=arsyserp;Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO [dbo].[Table_presentedco]([corporation_name],[field],[contact_info],[date],[result],[adress],[description]) VALUES('" + Txt_co_name.Text + "','" + combo_work.Text + "','" + Txt_contact.Text + "','" + datepickerpresent.Text + "','" + combo_res.Text + "','" + Txt_coadress.Text + "','" + Txt_description.Text + "')";
            cmd.ExecuteNonQuery();
            Txt_co_name.Text = "";
            combo_work.Text = "";
            Txt_contact.Text = "";
            datepickerpresent.Text = "";
            combo_res.Text = "";
            Txt_coadress.Text = "";
            Txt_description.Text = "";
            Txt_co_name.Focus();
            Namayesh();







        }

        private void Txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            if (Txt_co_name.Text=="")
            {
                MessageBox.Show("نام شرکتی که می خواهید حذف شود را وارد نمایید");
                Txt_co_name.Focus();
                return;

            }
            if (MessageBox.Show("آیا از حذف این رکورد مطمئن هستید؟","دقت کنید",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)

            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=.;Initial Catalog=arsyserp;Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from [dbo].[Table_presentedco] where [corporation_name]='" + Txt_co_name.Text + "'";
                cmd.ExecuteNonQuery();
                Txt_co_name.Text = "";
                combo_work.Text = "";
                Txt_contact.Text = "";
                datepickerpresent.Text = "";
                combo_res.Text = "";
                Txt_coadress.Text = "";
                Txt_description.Text = "";
                Txt_co_name.Focus();
                Namayesh();

            }
            else
            {
             Txt_co_name.Focus();
            }
        }

        private void Btnedith_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=.;Initial Catalog=arsyserp;Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "update  [dbo].[Table_presentedco] set [corporation_name]='" + Txt_co_name.Text + "',[field]='" + combo_work.Text + "',[contact_info]='" + Txt_contact.Text + "',[date]='" + datepickerpresent.Text + "',[result]='" + combo_res.Text + "',[adress]='" + Txt_coadress.Text + "',[description]='" + Txt_description.Text + "'where corporation_name='" + Txt_co_name.Text + "'";
            cmd.ExecuteNonQuery();
            Txt_co_name.Text = "";
            combo_work.Text = "";
            Txt_contact.Text = "";
            datepickerpresent.Text = "";
            combo_res.Text = "";
            Txt_coadress.Text = "";
            Txt_description.Text = "";
            Txt_co_name.Focus();
            Namayesh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=.;Initial Catalog=arsyserp;Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select *  [dbo].[Table_presentedco] where [corporation_name]='" + Txt_co_name.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (Txt_co_name.Text == "")
            {
                MessageBox.Show("نام شرکتی که می خواهید جست و جو شود را وارد نمایید");
                Txt_co_name.Focus();
                return;

            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Namayesh();
            Txt_co_name.Text = "";
            combo_work.Text = "";
            Txt_contact.Text = "";
            datepickerpresent.Text = "";
            combo_res.Text = "";
            Txt_coadress.Text = "";
            Txt_description.Text = "";
            Txt_co_name.Focus();
        }

        private void radButton6_Click(object sender, EventArgs e)
        {

        }

        private void Frmmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            string imaglocation="";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter= "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (dialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    imaglocation = dialog.FileName;
                    pictureBox2.ImageLocation = imaglocation;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است","دقت کنید",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void btnchap_presentco_Click(object sender, EventArgs e)
        {
            presentcoprint presentcoprint = new presentcoprint();
            presentcoprint.Show();
        }
    }
}
