namespace EjercicioOperaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperaciones.Items.Add("suma");
            this.cmbOperaciones.Items.Add("resta");
            this.cmbOperaciones.Items.Add("multiplicacion");
            this.cmbOperaciones.Items.Add("division");



        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado=0;
            string operacion=this.cmbOperaciones.SelectedItem.ToString();
            switch (operacion)
            {
                case "suma":
                    resultado = int.Parse(this.txtNum1.Text) + int.Parse(this.txtnum2.Text);
                    break;
                case "resta":
                    resultado = int.Parse(this.txtNum1.Text) - int.Parse(this.txtnum2.Text);
                    break;
                case "multiplicacion":
                    resultado = int.Parse(this.txtNum1.Text) * int.Parse(this.txtnum2.Text);
                    break;
                case "division":
                    resultado = int.Parse(this.txtNum1.Text) / int.Parse(this.txtnum2.Text);
                    break;
                default:
                    break;
                   

            }
            this.txtresultado.Text = resultado.ToString();
        }
    }
}
