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
    public partial class frmModificarEntrenador : Form
    {
        public frmModificarEntrenador()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            clsEntrenador BuscarEntrenador = new clsEntrenador();
            BuscarEntrenador.Buscar(txtCodigoBusc.Text);
            if (BuscarEntrenador.CodigoEntrenador!=txtCodigoBusc.Text)
            {
                MessageBox.Show("El codigo no fue encontrado");
            }
            else
            {
                txtCodigoEntr.Text = BuscarEntrenador.CodigoEntrenador;
                txtNombre.Text = BuscarEntrenador.NombreEntrenador;
                txtApellido.Text = BuscarEntrenador.ApellidoEntrenador;
                txtDireccion.Text = BuscarEntrenador.DireccionEntrenador;
                lstDeporte.Text = Convert.ToString(BuscarEntrenador.DeporteEntrenador);
                lstProvincia.Text = Convert.ToString(BuscarEntrenador.ProvinciaEntrenador);
                
            }

        }
           

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //clsDeportista ModificarDepor = new clsDeportista();


            //ModificarDepor.Nombre = txtNombre.Text;
            //ModificarDepor.Apellido = txtApellido.Text;
            //ModificarDepor.Direccion = txtDireccion.Text;
            //ModificarDepor.Edad = Convert.ToInt32(mskEdad.Text);
            //ModificarDepor.Telefono = Convert.ToInt32(mskTelefono.Text);
            //ModificarDepor.Deporte = Convert.ToString(lstDeporte.SelectedItem);
            //ModificarDepor.Modificar(txtCodigoDepor.Text);
            clsEntrenador ModificarEntr = new clsEntrenador();

            ModificarEntr.NombreEntrenador = txtNombre.Text;
            ModificarEntr.ApellidoEntrenador=txtApellido.Text;
            ModificarEntr.DireccionEntrenador= txtDireccion.Text;
            ModificarEntr.DeporteEntrenador = Convert.ToString(lstDeporte.SelectedItem);
            ModificarEntr.ProvinciaEntrenador = Convert.ToString(lstProvincia.SelectedItem);
            ModificarEntr.Modificar(txtCodigoEntr.Text);

        }
    }
}
