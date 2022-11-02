using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pry.BaseDeDatos.LopezV
{
    public partial class frmModificarDeportista : Form
    {


        public frmModificarDeportista()
        {
            InitializeComponent();
        }

        private void frmModificarDeportista_Load(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            clsDeportista BuscarDepor = new clsDeportista();
            BuscarDepor.Buscar(txtCodigoDeporBusc.Text);
            if (BuscarDepor.CodigoDeportista != txtCodigoDeporBusc.Text)
            {
                MessageBox.Show("El codigo no fue encontrado.");
            }
            else
            {
                txtCodigoDepor.Text = BuscarDepor.CodigoDeportista;
                txtNombre.Text = BuscarDepor.Nombre;
                txtApellido.Text = BuscarDepor.Apellido;
                txtDireccion.Text = BuscarDepor.Direccion;
                mskEdad.Text = Convert.ToString(BuscarDepor.Edad);
                mskTelefono.Text = Convert.ToString(BuscarDepor.Telefono);
                lstDeporte.Text = Convert.ToString(BuscarDepor.Deporte);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigoDeporBusc.Text;
            string SQL = "UPDATE DEPORTISTA SET ([DIRECCION], [TELEFONO], [EDAD], [DEPORTE]) WHERE ('" + Codigo + "'= [CODIGO DEPORTISTA])";

        }
    }
}
