namespace sistema_ingresos_egresos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Form1 new_form1 = new Form1();
            //new_form1.Hide();
            InicioSecion inicio_seion = new InicioSecion();
            this.Hide();

            inicio_seion.Show();
        }
    }
}