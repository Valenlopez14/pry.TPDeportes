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
        //variables globales a utilizar
        OleDbConnection conexionBase;
        OleDbCommand queQuieroDeportista;
        OleDbDataReader lectorDeportista;

        public string rutaDeportista = "DEPORTE.accdb";

        public frmModificarDeportista()
        {
            InitializeComponent();
        }

        private void frmModificarDeportista_Load(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigoDeporBusc.Text;
            try
            {
                 conexionBase.ConnectionString = rutaDeportista; //la conexion toma el valor de la ruta asignada
                conexionBase.Open();

                //El comando toma la conexxion
                queQuieroDeportista.Connection = conexionBase;
                //Este comando trae la tabla del acces 
                queQuieroDeportista.CommandType = CommandType.TableDirect;
                //Selecciona la tabla
                queQuieroDeportista.CommandText = "DEPORTISTA";
                //Trae todo lo que hay en la tabla y lo lee 
                lectorDeportista = queQuieroDeportista.ExecuteReader();
                //Este si revisa si la base de datos tiene registros
                if (lectorDeportista.HasRows)
                {
                    //Mientras lo lea hasta fin de archivo 
                    while (lectorDeportista.Read())
                    {
                        //Si Lo que esta leyendo el lector es = a Codigo;
                        if (lectorDeportista.GetString(0) == Codigo)
                        {
                            txtCodigoDepor.Text = lectorDeportista.GetString(0);
                            txtNombre.Text = lectorDeportista.GetString(1);
                            txtApellido.Text = lectorDeportista.GetString(2);
                            txtDireccion.Text = lectorDeportista.GetString(3);
                            txtTelefono.Text = lectorDeportista.GetString(4);
                            txtEdad.Text = lectorDeportista.GetString(5);
                            txtDeporte.Text = lectorDeportista.GetString(6);

                        }
                    }
                }

            }
            catch (Exception)
            {

               //throw;
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigoDeporBusc.Text;
            string SQL = "UPDATE DEPORTISTA SET ([DIRECCION], [TELEFONO], [EDAD], [DEPORTE]) WHERE ('" + Codigo + "'= [CODIGO DEPORTISTA])";

        }
    }
}
