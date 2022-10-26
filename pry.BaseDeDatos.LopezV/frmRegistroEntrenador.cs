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
    public partial class frmRegistroEntrenador : Form
    {
        public OleDbConnection conexionBD; //declaracion deconexion a Base de datos
        public OleDbCommand comandoBD; //representa una instruccion

        //declarar la ruta que esta la Base de Datos
        public string RutaBD = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DEPORTE.accdb";

        public frmRegistroEntrenador()
        {
            InitializeComponent();
        }

        private void cmdRegistrarEntr_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistroEntrenador_Load(object sender, EventArgs e)
        {
            string IdEntrenador = txtNombreEntr.Text;
            string NombreEntrenador = txtApellidoEntr.Text;
            string ApellidoEntrenador = txtApellidoEntr.Text;
            string DireccionEntrenador = txtDireccionEntr.Text;
            string ProvinciaEntrenador = Convert.ToString(lstProvinciaEntr.SelectedItem);
            string DeporteEntrenador = Convert.ToString(lstDeporteEntr);

            try
            {
                conexionBD = new OleDbConnection(RutaBD);
                conexionBD.Open();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD; //conexion al origen de los datos
                comandoBD.CommandType = CommandType.Text; //comando para insertar datos
                comandoBD.CommandText = "INSERT INTO ENTRENADORES ([CODIGO DEPORTISTA], NOMBRE, APELLIDO, DIRECCION, PROVINCIA, DEPORTE)" +
                    "VALUES(" + "'" + IdEntrenador + "'" + "," + "'" + NombreEntrenador + "'" + "," + "'" + ApellidoEntrenador + "'" + "," + "'" +
                    DireccionEntrenador + "'" + "," + "'" + ProvinciaEntrenador + "'" + "," + "'" + DeporteEntrenador + "'" + "," + "'" + ")";
                comandoBD.ExecuteNonQuery(); //numero de filas afectuadas
                MessageBox.Show("Datos cargados correctamente. :)");
            }
            catch (Exception mensaje)
            {
                MessageBox.Show("Datos Incorrectos. " + mensaje);
                //throw;
            }

        }
    }
}
