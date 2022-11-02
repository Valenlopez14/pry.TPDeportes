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

           clsDeportista ModificarDepor = new clsDeportista();
           
            ModificarDepor.Nombre = txtNombre.Text;
            ModificarDepor.Apellido = txtApellido.Text;
            ModificarDepor.Direccion = txtDireccion.Text;
            ModificarDepor.Edad = Convert.ToInt32(mskEdad.Text);
            ModificarDepor.Telefono = Convert.ToInt32(mskTelefono.Text);
            ModificarDepor.Deporte = Convert.ToString(lstDeporte.SelectedItem);
            ModificarDepor.Modificar(txtCodigoDepor.Text);

            //Limpiar Controles
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtCodigoDepor.Text = "";
            txtCodigoDeporBusc.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            mskEdad.Text = "";
            mskTelefono.Text = "";
            lstDeporte.SelectedIndex = -1;


        }

        private void mskEdad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
