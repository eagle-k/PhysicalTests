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
using Microsoft.VisualBasic;

namespace PhysicalTest
{
    public partial class ExamineeRegister : Form
    {
        public bool IsNew { get; set; }
        public int InitID { get; set; }
        public string InitLastName { get; set; }
        public string InitFirstName { get; set; }
        public DateTime InitBirthdate { get; set; }

        public ExamineeRegister()
        {
            InitializeComponent();
        }

        private void ExamineeRegister_Load(object sender, EventArgs e)
        {
            if (IsNew)
            {
                try
                {
                    var sql = @"SELECT MAX(ExamineeID) FROM Examinee";
                    using (var conn = new SqlConnection(Program.ConnStr))
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandText = sql;
                        var idObj = cmd.ExecuteScalar();

                        int id;
                        if (idObj != null)
                        {
                            id = Convert.ToInt32(idObj) + 1;
                        }
                        else
                        {
                            id = 1;
                        }
                        textBoxID.Text = id.ToString();
                    }
                }
                catch (SqlException)
                {
                }
            }
            else
            {
                textBoxID.ReadOnly = true;
                textBoxID.Text = InitID.ToString();
                textBoxLastName.Text = InitLastName;
                textBoxFirstName.Text = InitFirstName;
                dateTimePickerBirthdate.Value = InitBirthdate;
                ActiveControl = textBoxLastName;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(Strings.StrConv(textBoxID.Text, VbStrConv.Narrow), out id))
            {
                MessageBox.Show(this, "IDは数字で入力してください。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (id < 0 || 99999999 < id)
            {
                MessageBox.Show(this, "IDは正の整数8桁まで入力できます。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            DateTime birthdate = dateTimePickerBirthdate.Value;

            string sql;
            if (IsNew)
            {
                sql = @"INSERT INTO Examinee (ExamineeID, FirstName, LastName, Birthdate) VALUES (@ExamineeID, @FirstName, @LastName, @Birthdate)";
            }
            else
            {
                sql = @"UPDATE Examinee SET ExamineeID = @ExamineeID, FirstName = @FirstName, LastName = @LastName, Birthdate = @Birthdate WHERE ExamineeID = @ExamineeID";
            }

            try
            {
                using (var conn = new SqlConnection(Program.ConnStr))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@ExamineeID", id);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Birthdate", birthdate);
                    cmd.ExecuteNonQuery();
                }
                Close();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "登録に失敗しました。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
