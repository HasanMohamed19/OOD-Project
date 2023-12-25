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

namespace OOD_Project
{
    public partial class ViewEmails : Form
    {
        public ViewEmails()
        {
            InitializeComponent();
            populateEmails();
        }

        private void populateEmails()
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@recipient_user_id", 3);
            MessageBox.Show(Global.User_id.ToString());
            dbm.Command.CommandText = "SELECT * FROM [dbo].[email] WHERE recipient_user_id = @recipient_user_id";

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(dbm.Command);
                BindingSource bs = new BindingSource();

                da.Fill(dt);
                bs.DataSource = dt;
                emailDG.DataSource = bs;
                emailDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                emailDG.RowTemplate.MinimumHeight = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
        }
    }
}
