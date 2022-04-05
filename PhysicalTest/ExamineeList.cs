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

namespace PhysicalTest
{
    public partial class ExamineeList : Form
    {
        private DataTable dt;
        public bool IsSearch { get; set; } = false;
        public int? SelectedID { get; set; }
        public string SelectedFirstName { get; set; }
        public string SelectedLastName { get; set; }
        public DateTime SelectedBirthdate { get; set; }

        public ExamineeList()
        {
            InitializeComponent();
        }

        private void Fetch()
        {
            using (var conn = new SqlConnection(Program.ConnStr))
            using (var cmd = conn.CreateCommand())
            using (var adapter = new SqlDataAdapter(cmd))
            {
                var sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Examinee WHERE 1 = 1");
                cmd.Parameters.Clear();

                int idFrom;
                if (int.TryParse(textBoxIDFrom.Text, out idFrom))
                {
                    sql.AppendLine("AND ExamineeID >= @ExamineeIDFrom");
                    cmd.Parameters.AddWithValue("@ExamineeIDFrom", idFrom);
                }

                int idTo;
                if (int.TryParse(textBoxIDTo.Text, out idTo))
                {
                    sql.AppendLine("AND ExamineeID <= @ExamineeIDTo");
                    cmd.Parameters.AddWithValue("@ExamineeIDTo", idTo);
                }

                if (!string.IsNullOrEmpty(textBoxName.Text))
                {
                    sql.AppendLine("AND LastName + ' ' + FirstName LIKE @FullName");
                    var fullName = $"%{textBoxName.Text}%";
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                }

                if (checkBoxBirthdate.Checked)
                {
                    sql.AppendLine("AND Birthdate BETWEEN @BirthdateFrom AND @BirthdateTo");
                    cmd.Parameters.AddWithValue("@BirthdateFrom", dateTimePickerBirthdateFrom.Value);
                    cmd.Parameters.AddWithValue("@BirthdateTo", dateTimePickerBirthdateTo.Value);
                }

                sql.AppendLine("ORDER BY ExamineeID");

                cmd.CommandText = sql.ToString();
                dt.Clear();
                adapter.Fill(dt);
            }
        }

        private void SetReadOnly()
        {
            dateTimePickerBirthdateFrom.Enabled = checkBoxBirthdate.Checked;
            dateTimePickerBirthdateTo.Enabled = checkBoxBirthdate.Checked;
        }

        private void ExamineeList_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            textBoxIDFrom.Clear();
            textBoxIDTo.Clear();
            textBoxName.Clear();
            checkBoxBirthdate.Checked = false;
            dateTimePickerBirthdateFrom.Value = new DateTime(2000, 1, 1);
            dateTimePickerBirthdateTo.Value = DateTime.Today;

            SetReadOnly();
            buttonSelect.Visible = IsSearch;
            buttonInsert.Visible = !IsSearch;
            buttonUpdate.Visible = !IsSearch;
            buttonDelete.Visible = !IsSearch;

            Fetch();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }
        private void checkBoxBirthdate_CheckedChanged(object sender, EventArgs e)
        {
            SetReadOnly();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Fetch();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(this, "条件を満たす受験者が見つかりませんでした。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            using (var f = new ExamineeRegister())
            {
                f.IsNew = true;
                f.ShowDialog();
            }
            Fetch();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var dr = dt.Rows[dataGridView1.CurrentRow.Index];
            var id = dr.Field<int>("ExamineeID");
            var firstName = dr.Field<string>("FirstName");
            var lastName = dr.Field<string>("LastName");
            var birthdate = dr.Field<DateTime>("Birthdate");

            using (var f = new ExamineeRegister())
            {
                f.IsNew = false;
                f.InitID = id;
                f.InitFirstName = firstName;
                f.InitLastName = lastName;
                f.InitBirthdate = birthdate;
                f.ShowDialog();
            }
            Fetch();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var result = MessageBox.Show(this, "削除します。よろしいですか？", "システム", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            var dr = dt.Rows[dataGridView1.CurrentRow.Index];
            var id = dr.Field<int>("ExamineeID");

            var sql = @"DELETE FROM Examinee WHERE ExamineeID = @ExamineeID";
            try
            {
                using (var conn = new SqlConnection(Program.ConnStr))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@ExamineeID", id);
                    cmd.ExecuteNonQuery();
                }

                Fetch();
                MessageBox.Show(this, "削除しました。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "削除に失敗しました。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var dr = dt.Rows[dataGridView1.CurrentRow.Index];
            var id = dr.Field<int>("ExamineeID");
            SelectedID = id;
            SelectedFirstName = dr.Field<string>("FirstName");
            SelectedLastName = dr.Field<string>("LastName");
            SelectedBirthdate = dr.Field<DateTime>("Birthdate");

            Close();
        }
    }
}

