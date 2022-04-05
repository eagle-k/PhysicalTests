using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace PhysicalTest
{
    public partial class TestEventRegister : Form
    {
        private DataTable dt;

        public TestEventRegister()
        {
            InitializeComponent();
        }

        private void TestEventRegister_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            var sql = @"SELECT * FROM TestEvent ORDER BY TestEventID";
            using (var adapter = new SqlDataAdapter(sql, Program.ConnStr))
            {
                adapter.Fill(dt);
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var deleteSql = @"DELETE FROM TestEvent";
                var insertSql = @"INSERT INTO TestEvent (TestEventID, TestEventName) VALUES (@TestEventID, @TestEventName)";
                using (var scope = new TransactionScope())
                using (var conn = new SqlConnection(Program.ConnStr))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();

                    cmd.CommandText = deleteSql;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = insertSql;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState == DataRowState.Deleted) continue;
                        var id = row.Field<int?>("TestEventID");
                        var name = row.Field<string>("TestEventName");
                        if (!id.HasValue) continue;

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@TestEventID", id.Value);
                        cmd.Parameters.AddWithValue("@TestEventName", name);
                        cmd.ExecuteNonQuery();
                    }

                    scope.Complete();
                }
                MessageBox.Show(this, "登録しました。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "登録に失敗しました。", "システム", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TestEventRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt?.Dispose();
            dt = null;
        }
    }
}
