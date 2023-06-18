using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Quiz11 {
    public partial class Form1 : Form {
        //SqlConnection dbConnection = new SqlConnection("server=BTU306-L\\SQLEXPRESS;database=Shekveta;uid=sa;pwd=1");
        SqlConnection dbConnection = new SqlConnection(@"
            Data Source=DESKTOP-JUQCHVR\SQLEXPRESS;
            Initial Catalog=Shekveta;
            Integrated Security=True
        ");

        public Form1() {
            dbConnection.Open();
            InitializeComponent();
            viewTableBtn_Click(null, null);
        }

        private DataTable RunQuery(String sql) {
            SqlCommand query = new SqlCommand(sql, dbConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        private void viewTableBtn_Click(object sender, EventArgs e) {
            String tableName = "Shemkveti";
            DataTable dataTable = RunQuery($"SELECT * FROM {tableName}");
            TABLE.DataSource = dataTable;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            dbConnection.Close();
        }

        private void filterBtn_Click(object sender, EventArgs e) {
            String tableName = "Shemkveti";
            String cityFilter = "qalaqi = N'თელავი'";
            String legalEntityTypeFilter = "iuridiuli_fizikuri = N'იურიდიული'";
            DataTable dataTable = RunQuery($@"
                 SELECT * FROM {tableName}
                 WHERE {cityFilter} AND {legalEntityTypeFilter}
            ");
            TABLE.DataSource = dataTable;
        }

        private void orderByBtn_Click(object sender, EventArgs e) {
            String tableName = "Xelshekruleba";
            String orderBy = "tarigi_dawyebis DESC, gadasaxdeli_l ASC";

            DataTable dataTable = RunQuery($@"
                select * from {tableName}
                order by {orderBy}
            ");
            TABLE.DataSource = dataTable;

            /// or
            // DataTable dataTable = RunQuery($"SELECT * FROM {tableName}");
            // DataView dataView = dataTable.DefaultView;
            // dataView.Sort = orderBy;
            // TABLE.DataSource = dataView;
        }

        private void findBtn_Click(object sender, EventArgs e) {
            String tableName = "Personali";
            String pid = "4";
            String findBy = $"personaliID = {pid}";

            DataTable dataTable = RunQuery($"SELECT * FROM {tableName} WHERE {findBy}");
            TABLE.DataSource = dataTable;

            // DataTable dataTable = RunQuery($"SELECT * FROM {tableName}");
            // DataColumn[] keys = { dataTable.Columns["PersonaliID"] };
            // dataTable.PrimaryKey = keys;
            // DataRow row = dataTable.Rows.Find(pid);
            // if (row is null) { MessageBox.Show("No Row Found By ID=4"); }
            // else { DataTable tmp = dataTable.Clone(); tmp.ImportRow(row); TABLE.DataSource = tmp; };
        }

        private void femalesCntBtn_Click(object sender, EventArgs e) {
            String tableName = "Personali as p";
            String joinTable = "Shemkveti as o ON p.personaliID = o.personaliID";
            String filterBy = "p.sqesi = N'ქალი' AND o.iuridiuli_fizikuri = N'ფიზიკური'";
            DataTable dataTable = RunQuery($@"
                SELECT p.* FROM {tableName} 
                JOIN {joinTable}
                WHERE {filterBy}
            ");
            TABLE.DataSource = dataTable;
            MessageBox.Show($"Found {dataTable.Rows.Count} Female Individual Records");
        }

        private void maxSalaryBtn_Click(object sender, EventArgs e) {
            String tableName = "Personali";
            DataTable dataTable = RunQuery($"SELECT * FROM {tableName}");
            object maxSalaryQueryResult = dataTable.Compute("Max(xelfasi)", "");
            decimal maxSalary = Convert.ToDecimal(maxSalaryQueryResult);
            MessageBox.Show($"Max Salary: ${maxSalary}");
        }

        private void minSalaryBtn_Click(object sender, EventArgs e) {
            String tableName = "Personali";
            DataTable dataTable = RunQuery($"SELECT * FROM {tableName}");
            object minSalaryQueryResult = dataTable.Compute("Min(xelfasi)", "");
            decimal minSalary = Convert.ToDecimal(minSalaryQueryResult);
            MessageBox.Show($"Min Salary: ${minSalary}");
        }

        private void avgSalaryBtn_Click(object sender, EventArgs e) {
            String tableName = "Personali";
            DataTable dataTable = RunQuery($"SELECT * FROM {tableName}");
            object avgSalaryQueryResult = dataTable.Compute("Avg(xelfasi)", "ganyofileba = 'სავაჭრო'");
            decimal avgSalary = Convert.ToDecimal(avgSalaryQueryResult);
            MessageBox.Show($"Marketing Average Salary: ${avgSalary}");
        }
    }
}
