using Oracle.ManagedDataAccess.Client;

namespace RestaurantInformationSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(@"Uid=sys;password=t110902a123456789");

            con.Open();
        }
    }
}