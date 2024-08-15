namespace FormularioContacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            
            string nombre = textBoxNombre.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string mensaje = textBoxMensaje.Text.Trim();

         
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mensaje))
            {
                labelEstado.Text = "Por favor, complete todos los campos.";
            }
            else
            {
                
                labelEstado.Text = "Formulario enviado correctamente.";


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton para limpiar datos 
            textBoxNombre.Clear();
            textBoxEmail.Clear();
            textBoxMensaje.Clear();
        }
    }
}

