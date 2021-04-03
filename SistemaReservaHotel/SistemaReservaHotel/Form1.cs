using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReservaHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            completarcategoria();
            configurarlistview();
            completarTipoDocumento();
        }

        void completarcategoria()
        {
             cboCategoria.Items.Add("comun");
             cboCategoria.Items.Add("premium");
             cboCategoria.Items.Add("superPremium");
           
        }

        void completarTipoDocumento()
        {
             cboTipodoc.Items.Add("DNI");
             cboTipodoc.Items.Add("Carnet de Extranjero");
             cboTipodoc.Items.Add("Partida Nacimiento");
          
        }

        void configurarlistview()
        {
            lstReserva.View = View.Details;
            lstReserva.GridLines = true;
            lstReserva.Columns.Add("CLIENTE", 100);
            lstReserva.Columns.Add("Tipo Documento", 100);
            lstReserva.Columns.Add("num documento", 100);
            lstReserva.Columns.Add("numero telefonico", 100);
            lstReserva.Columns.Add("codigo habitacion", 100);
            lstReserva.Columns.Add("categoria hab", 80);
            lstReserva.Columns.Add("tiempo reserva", 80);
            lstReserva.Columns.Add("Pago total", 80);
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.Nombre = txtNombre.Text;
            obj.NumDoc = txtnumdoc.Text;
            obj.TipoDoc = cboTipodoc.Text;
            obj.Telefono = Convert.ToInt32(txtTelefono.Text);
            ListViewItem fila = new ListViewItem(obj.Nombre);

            ReservaHabitacion objreserva = new ReservaHabitacion();

            objreserva.TiempoReserva = Convert.ToInt32(txtDiasReserva.Text);
            objreserva.Categoria = cboCategoria.Text;
            objreserva.CodigoHabitacion = Convert.ToInt32(txtcodigohabit.Text);

            fila.SubItems.Add(obj.TipoDoc.ToString());
            fila.SubItems.Add(obj.NumDoc.ToString());
            fila.SubItems.Add(obj.Telefono.ToString());

            fila.SubItems.Add(objreserva.CodigoHabitacion.ToString());
            fila.SubItems.Add(objreserva.Categoria);
            fila.SubItems.Add(objreserva.TiempoReserva.ToString());
            fila.SubItems.Add(objreserva.pagototal().ToString());
            lstReserva.Items.Add(fila);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
