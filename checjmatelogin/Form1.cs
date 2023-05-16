namespace checjmatelogin
{
    public partial class Checkmate : Form
    {
        public Checkmate()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            login2 lg= new login2();
            lg.Show();
            this.Hide();

        }
    }
}