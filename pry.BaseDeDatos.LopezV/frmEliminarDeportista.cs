using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.BaseDeDatos.LopezV
{
    public partial class frmEliminarDeportista : Form
    {
        public frmEliminarDeportista()
        {
            InitializeComponent();
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
            string CodigoDepor = txtCodigoDeporBusc.Text;
            clsDeportista EliminarDepor = new clsDeportista();
            EliminarDepor.Eliminar(CodigoDepor);
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
    }
}
