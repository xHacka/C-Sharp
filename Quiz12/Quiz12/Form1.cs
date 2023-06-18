using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace Quiz12 {
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            dbConnection.Close();
        }

        private String RandomString(int length) {
            const String characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new String(
                Enumerable.Repeat(characters, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
        }

        private void update6thBtn_Click(object sender, EventArgs e) {
            String tableName = "Personali";
            using (SqlCommand command = new SqlCommand($@"
                    UPDATE {tableName}
                    SET staji = @newValue 
                    WHERE personaliID = @personaliID
                    ", dbConnection)
                ) {
                command.Parameters.AddWithValue("@newValue", random.Next(1, 10));
                command.Parameters.AddWithValue("@personaliID", 6);

                int rowsAffected = command.ExecuteNonQuery();
                String msg = rowsAffected > 0 ? "Value Updated Successfully" : "Failed To Update Value";
                MessageBox.Show(msg);
            }
        }

        private void AddRowBtn_Click(object sender, EventArgs e) {
            using (SqlCommand command = new SqlCommand(@"
                INSERT INTO Personali (staji, asaki)
                VALUES (@staji, @asaki)
            ", dbConnection)) {
                command.Parameters.AddWithValue("@staji", random.Next(1, 10));
                command.Parameters.AddWithValue("@asaki", random.Next(18, 34));
                int rowsAffected = command.ExecuteNonQuery();
                String msg = rowsAffected > 0 ? "New Row Successfully Added" : "Failed To Add New Row";
                MessageBox.Show(msg);
            }
        }

        private void delete2ndBtn_Click(object sender, EventArgs e) {
            using (SqlCommand command = new SqlCommand(@"
                    DELETE FROM Personali
                    WHERE personaliID = @personaliID
                    ", dbConnection)
                ) {
                command.Parameters.AddWithValue("@personaliID", 2);
                int rowsAffected = command.ExecuteNonQuery();
                String msg = rowsAffected > 0 ? "2nd Row Successfully Deleted" : "Failed To Delete 2nd Row (maybe already deleted)";
                MessageBox.Show(msg);
            }
        }

        // Should Work..........But Doesnt....................
        private void joinTablesBtn_Click(object sender, EventArgs e) {
            String table1 = "Xelshekruleba";
            String table2 = "Personali";
            using (SqlCommand command = new SqlCommand($@"
                ALTER TABLE {table1}
                ADD CONSTRAINT FK_{table1}_{table2} FOREIGN KEY (shemkvetiID) 
                REFERENCES {table2}(personaliID)
                ", dbConnection)
             ) {
                int rowsAffected = command.ExecuteNonQuery();
                String msg = rowsAffected > 0 ? "Table Altered" : "Failed To Alter Table";
                MessageBox.Show(msg);
            }
        }
    }
}