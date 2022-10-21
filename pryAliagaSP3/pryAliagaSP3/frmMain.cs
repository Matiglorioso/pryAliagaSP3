using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAliagaSP3
{
    public partial class frmAutoTest : Form
    {
        public frmAutoTest()
        {
            InitializeComponent();
        }
        public struct TURNOS
        {
            public int NumeroTurno;
            public string Dominio;
            public int AñoFabricacion;
            public string Titular;
        }
        const int MAX = 50;
        public TURNOS[] turnos;
        public int Cantidad = 0;


        private void frmAutoTest_Load(object sender, EventArgs e)
        {
            // creación del arreglo
            turnos = new TURNOS[MAX];
            // inicializar la variable que controla la cantidad de elementos cargados
            Cantidad = 0;
            // establecer el estado inicial de todos los componentes de la interfaz
            InicializarInterfaz();


        }
        private void InicializarInterfaz()
        {
            LimpiarControles(); // estado inicial de los controles de carga de datos
            // estado inicial de los controles de consultas
            txtCantidadTurnos.Clear();
            txtAñoAntiguo.Clear();
            txtCantidadDominio.Clear();
            txtNumeroTurno.Focus();
            btnRegistrar.Enabled = false;
            btnConsultar.Enabled = false;   
            txtDominio.Enabled = false; 
            nudAñoFabricacion.Enabled = false;
            txtTitular.Enabled = false; 
        }
        private void LimpiarControles()
        {
            txtDominio.Clear();
            txtNumeroTurno.Clear();
            txtTitular.Clear();
            nudAñoFabricacion.Value = 2022;
            txtNumeroTurno.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNumeroTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sin NO es un dígito y NO es Backspace (para borrar)
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // borrar la tecla ingresada
            }
        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // usamos los métodos de la clase 'Char', (IsLower y ToUpper)
            if (Char.IsLower(e.KeyChar)) // es una minúscula ?
            {
                e.KeyChar = Char.ToUpper(e.KeyChar); // convertir a mayúscula
            }
            // no es ni letra ni número y es distinto de Backspace ?
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // borrar la tecla
            }
        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



