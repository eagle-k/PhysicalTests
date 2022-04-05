using Microsoft.VisualBasic;
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
    public partial class TestResultRegister : Form
    {
        public bool IsNew { get; set; }
        public int InitExamineeID { get; set; }
        public string InitFullName { get; set; }
        public List<ComboBoxItem> InitTestEventItems { get; set; }
        public int InitTestEventIndex { get; set; }
        public decimal InitScore { get; set; }

        public TestResultRegister()
        {
            InitializeComponent();
        }

        private void TestResultRegister_Load(object sender, EventArgs e)
        {
            comboBoxTestEvents.Items.Clear();
            comboBoxTestEvents.Items.Add(new ComboBoxItem { ID = -1, Name = "" });
            foreach (var testEventItem in InitTestEventItems)
            {
                comboBoxTestEvents.Items.Add(testEventItem);
            }

            if (!IsNew)
            {
                textBoxExamineeID.Text = InitExamineeID.ToString();
                textBoxFullName.Text = InitFullName;
                textBoxScore.Text = InitScore.ToString("N2");
                comboBoxTestEvents.SelectedIndex = InitTestEventIndex;
                textBoxExamineeID.ReadOnly = true;
                buttonExamineeSearch.Visible = false;
                comboBoxTestEvents.Enabled = false;
                ActiveControl = textBoxScore;
            }
        }

        private void buttonExamineeSearch_Click(object sender, EventArgs e)
        {
            using (var f = new ExamineeList())
            {
                f.IsSearch = true;
                f.ShowDialog();
                var id = f.SelectedID;
                if (id.HasValue)
                {
                    var fullName = $"{f.SelectedLastName} {f.SelectedFirstName}";
                    textBoxExamineeID.Text = id.ToString();
                    textBoxFullName.Text = fullName;
                }
            }
        }

        private void textBoxExamineeID_Leave(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBoxExamineeID.Text, out id))
            {
                try
                {
                    var sql = @"SELECT * FROM Examinee WHERE ExamineeID = @ExamineeID";
                    using (var dt = new DataTable())
                    using (var adapter = new SqlDataAdapter(sql, Program.ConnStr))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@ExamineeID", id);
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            var dr = dt.Rows[0];
                            var firstName = dr.Field<string>("FirstName");
                            var lastName = dr.Field<string>("LastName");
                            var fullName = $"{lastName} {firstName}";

                            textBoxExamineeID.Text = id.ToString();
                            textBoxFullName.Text = fullName;
                        }
                        else
                        {
                            textBoxExamineeID.Clear();
                            textBoxFullName.Clear();
                        }
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "データを取得できませんでした。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxExamineeID.Clear();
                    textBoxFullName.Clear();
                }
            }
            else
            {
                textBoxExamineeID.Clear();
                textBoxFullName.Clear();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            int examineeID;
            if (!int.TryParse(Strings.StrConv(textBoxExamineeID.Text, VbStrConv.Narrow), out examineeID))
            {
                MessageBox.Show(this, "IDは数字で入力してください。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (examineeID < 0 || 99999999 < examineeID)
            {
                MessageBox.Show(this, "IDは正の整数8桁まで入力できます。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var testEvent = comboBoxTestEvents.SelectedItem as ComboBoxItem;
            if (testEvent == null || testEvent.ID <= 0)
            {
                MessageBox.Show(this, "種目を選択してください。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal score;
            if (!decimal.TryParse(Strings.StrConv(textBoxScore.Text, VbStrConv.Narrow), out score))
            {
                MessageBox.Show(this, "得点は数字で入力してください。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string sql;
            if (IsNew)
            {
                sql = @"INSERT INTO TestResult (ExamineeID, TestEventID, Score) VALUES (@ExamineeID, @TestEventID, @Score)";
            }
            else
            {
                sql = @"UPDATE TestResult SET ExamineeID = @ExamineeID, TestEventID = @TestEventID, Score = @Score WHERE ExamineeID = @ExamineeID AND TestEventID = @TestEventID";
            }

            try
            {
                using (var conn = new SqlConnection(Program.ConnStr))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@ExamineeID", examineeID);
                    cmd.Parameters.AddWithValue("@TestEventID", testEvent.ID);
                    cmd.Parameters.AddWithValue("@Score", score);
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
