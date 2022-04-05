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
    public partial class TestResultList : Form
    {
        private DataTable dt;
        public bool IsSearch { get; set; } = false;
        private List<ComboBoxItem> testEventItems = new List<ComboBoxItem>();

        public TestResultList()
        {
            InitializeComponent();
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

        private void Fetch()
        {
            using (var conn = new SqlConnection(Program.ConnStr))
            using (var cmd = conn.CreateCommand())
            using (var adapter = new SqlDataAdapter(cmd))
            {
                var sql = new StringBuilder();
                sql.AppendLine("SELECT TestResult.*, Examinee.LastName + ' ' + Examinee.FirstName AS FullName, TestEvent.TestEventName FROM TestResult");
                sql.AppendLine("LEFT JOIN Examinee ON TestResult.ExamineeID = Examinee.ExamineeID");
                sql.AppendLine("LEFT JOIN TestEvent ON TestResult.TestEventID = TestEvent.TestEventID");
                sql.AppendLine("WHERE 1 = 1");

                cmd.Parameters.Clear();

                int examineeID;
                if (int.TryParse(textBoxExamineeID.Text, out examineeID))
                {
                    sql.AppendLine("AND Examinee.ExamineeID = @ExamineeID");
                    cmd.Parameters.AddWithValue("@ExamineeID", examineeID);
                }

                var testEvent = comboBoxTestEvents.SelectedItem as ComboBoxItem;
                if (testEvent != null && testEvent.ID > 0)
                {
                    sql.AppendLine("AND TestEvent.TestEventID = @TestEventID");
                    cmd.Parameters.AddWithValue("@TestEventID", testEvent.ID);
                }

                sql.AppendLine("ORDER BY TestResult.ExamineeID, TestResult.TestEventID");

                cmd.CommandText = sql.ToString();
                dt.Clear();
                adapter.Fill(dt);
            }
        }

        private void TestResultList_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            textBoxExamineeID.Clear();

            try
            {
                var sql = @"SELECT * FROM TestEvent";
                using (var dt = new DataTable())
                using (var adapter = new SqlDataAdapter(sql, Program.ConnStr))
                {
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        var id = dr.Field<int>("TestEventID");
                        var name = dr.Field<string>("TestEventName");
                        var item = new ComboBoxItem { ID = id, Name = name };
                        testEventItems.Add(item);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "データを取得できませんでした。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }

            comboBoxTestEvents.Items.Clear();
            comboBoxTestEvents.Items.Add(new ComboBoxItem { ID = -1, Name = "" });
            foreach (var testEventItem in testEventItems)
            {
                comboBoxTestEvents.Items.Add(testEventItem);
            }

            buttonSelect.Visible = IsSearch;
            buttonInsert.Visible = !IsSearch;
            buttonUpdate.Visible = !IsSearch;
            buttonDelete.Visible = !IsSearch;

            Fetch();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
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
                MessageBox.Show(this, "条件を満たす結果が見つかりませんでした。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            using (var f = new TestResultRegister())
            {
                f.IsNew = true;
                f.InitTestEventItems = testEventItems;
                f.ShowDialog();
            }
            Fetch();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var dr = dt.Rows[dataGridView1.CurrentRow.Index];
            var examineeID = dr.Field<int>("ExamineeID");
            var fullName = dr.Field<string>("FullName");
            var testEventID = dr.Field<int>("TestEventID");
            var score = dr.Field<decimal>("Score");

            using (var f = new TestResultRegister())
            {
                f.IsNew = false;
                f.InitTestEventItems = testEventItems;
                f.InitExamineeID = examineeID;
                f.InitFullName = fullName;
                f.InitTestEventIndex = testEventItems.FindIndex(x => x.ID == testEventID) + 1;
                f.InitScore = score;
                f.ShowDialog();
            }
            Fetch();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //TODO:
        }
    }

    public class ComboBoxItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            if (ID > 0)
            {
                var idStr = ID.ToString().PadLeft(4, ' ');
                return $"{idStr}: {Name}";
            }
            else
            {
                return "";
            }
        }
    }
}
