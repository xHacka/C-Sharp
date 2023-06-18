using System.Data;
using System.Data.SqlClient;

namespace Quiz13 {
    public partial class Form1 : Form {
        Random random = new Random();
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
            String tableName = "Personali";
            DataTable dataTable = RunQuery($"SELECT * FROM {tableName}");
            TABLE.DataSource = dataTable;
        }

        private void viewTableBtn2_Click(object sender, EventArgs e) {
            String tableName = "Shemkveti";
            DataTable dataTable = RunQuery($"SELECT * FROM {tableName}");
            TABLE.DataSource = dataTable;
        }

        private String RandomString(int length) {
            const String characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new String(
                Enumerable.Repeat(characters, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
        }

        private void tbilisiOrdersBtn_Click(object sender, EventArgs e) {
            String query = "SELECT COUNT(*) FROM Shemkveti WHERE qalaqi = N'თბილისი'";
            using (SqlCommand command = new SqlCommand(query, dbConnection)) {
                int count = (int)command.ExecuteScalar();
                MessageBox.Show($"Number Of Customers From Tbilisi: {count}");
            }
        }

        private void contractsBtn_Click(object sender, EventArgs e) {
            String query = "SELECT COUNT(*) FROM Xelshekruleba WHERE gadasaxdeli_l > 3000";
            using (SqlCommand command = new SqlCommand(query, dbConnection)) {
                int count = (int)command.ExecuteScalar();
                MessageBox.Show($"Number Of Contracts With Amount >3000 GEL: {count}");
            }
        }

        private void avgSalaryBtn_Click(object sender, EventArgs e) {
            String query = "SELECT AVG(xelfasi) FROM Personali";
            using (SqlCommand command = new SqlCommand(query, dbConnection)) {
                double avgSalary = (double)command.ExecuteScalar();
                MessageBox.Show($"Employees Average Salary: {avgSalary} GEL");
            }
        }

        private void salaryRaiseBtn_Click(object sender, EventArgs e) {
            string query = @"UPDATE Personali 
                             SET xelfasi = xelfasi * 1.
                             WHERE qalaqi = N'თბილისი'
                            ";
            using (SqlCommand command = new SqlCommand(query, dbConnection)) {
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"Salary Increased For {rowsAffected} Employees In Tbilisi");
            }
        }

        private void newRowBtn_Click(object sender, EventArgs e) {
            string query = @"INSERT INTO Shemkveti ( saxeli,  gvari,  qalaqi) 
                             VALUES                (@saxeli, @gvari, @qalaqi)
                            ";
            using (SqlCommand command = new SqlCommand(query, dbConnection)) {
                command.Parameters.AddWithValue("@saxeli", RandomString(6));
                command.Parameters.AddWithValue("@gvari", RandomString(10));
                command.Parameters.AddWithValue("@qalaqi", "თბილისი");
                int rowsAffected = command.ExecuteNonQuery();
                String msg = rowsAffected > 0 ? "Row Successfully Inserted Into The Shemkveti Table" : "Failed To Insert Row";
                MessageBox.Show(msg);
            }
        }

        private void deleteTbilisiRowsBtn_Click(object sender, EventArgs e) {
            string query = "DELETE FROM Shemkveti WHERE qalaqi = @city";

            using (SqlCommand command = new SqlCommand(query, dbConnection)) {
                command.Parameters.AddWithValue("@city", "თბილისი");
                int rowsAffected = command.ExecuteNonQuery();
                String msg = rowsAffected > 0 ? $"{rowsAffected} Row(s) Deleted From The Shemkveti Tabl1e" : "Failed To Delete Rows";
                MessageBox.Show(msg);
            }

        }

    }
}