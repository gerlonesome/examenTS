using Examen.DataAccesses;
using Examen.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class NewClient: Form
    {
        public NewClient()
        {
            InitializeComponent();
            button1.Text = "Guardar Cliente";
            label1.Text = "Nombre";
            label2.Text = "Telefono";
            label3.Text = "Mail";
        }
        string nombre;
        string telefono;
        string mail;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientDataAccess clientDataAccess = new ClientDataAccess();
            Client client = new Client();
            client.nombreCliente = nombre;
            client.telefono = telefono;
            client.mail = mail;
            clientDataAccess.AgregarPaciente(client);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          telefono = textBox2.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
         mail = textBox3.Text;
        }
    }
}
