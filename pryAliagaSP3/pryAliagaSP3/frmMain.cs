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
        }
        private void LimpiarControles()
        {
            txtDominio.Clear(); 
            txtNumeroTurno.Clear();
            txtTitular.Clear();
            nudAñoFabricacion.Value = 2022;
        }

    }
}
