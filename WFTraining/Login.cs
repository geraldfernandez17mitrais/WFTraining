using Npgsql;

namespace WFTraining
{
    public partial class Login : Form
    {
        private NpgsqlConnection _connection;
        private string connString = "Host=localhost;Username=postgres;Password=postgres;Port=5432;Database=FruitTest20221113;";
        private string sqlQuery = "";
        public static NpgsqlCommand cmd;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _connection = new NpgsqlConnection(connString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();

                int roleId = 0;

                if(rbPembeli.Checked)
                    roleId = 1;
                else
                    roleId = 2;

                sqlQuery = @"select * from pengguna_r_login(:_username, :_password, :_roleid)";
                cmd = new NpgsqlCommand(sqlQuery, _connection);
                cmd.Parameters.AddWithValue("_username", tbUsername.Text);
                cmd.Parameters.AddWithValue("_password", tbPassword.Text);
                cmd.Parameters.AddWithValue("_roleid", roleId);

                if((int)cmd.ExecuteScalar() == 1)
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
