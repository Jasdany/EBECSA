using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresetacionWF
{
    public partial class FormProspecto : Form
    {
        LogicaNegocioProspecto logicaNR = new LogicaNegocioProspecto();
        public FormProspecto()
        {
            InitializeComponent();
        }

        private void tabPageProspecto_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           try
            {
                if (btnGuardar.Text=="Guardar")
                {
                    Prospecto objProspecto = new Prospecto();
                    objProspecto.nombres = txtNombre.Text;
                    objProspecto.cedula = txtCedula.Text;
                    objProspecto.apellidoPaterno = txtApellido1.Text;
                    objProspecto.apellidoMaterno = txtApellido2.Text;
                    objProspecto.correoElectronico = txtCorreo.Text;
                    objProspecto.TelefonoP = txtTelefono.Text;

                    if (logicaNR.insertarProspecto(objProspecto)>0)
                    {
                        MessageBox.Show("Agregado");
                        dataGridViewProspecto.DataSource = logicaNR.listarProspecto();
                        txtNombre.Text = "";
                        txtCedula.Text="";
                        txtApellido1.Text="";
                        txtApellido2.Text="";
                        txtCorreo.Text="";
                        txtTelefono.Text="";
                    }
                    else {MessageBox.Show("Error al Agregar");}
                    
                }

               if (btnGuardar.Text=="Actualizar")
	         {
		 
                   Prospecto objProspecto = new Prospecto();

                   objProspecto.idProspecto=Convert.ToInt32(txtID.Text);
                   objProspecto.nombres=txtNombre.Text;
                   objProspecto.apellidoPaterno=txtApellido1.Text;
                   objProspecto.apellidoMaterno=txtApellido2.Text;
                   objProspecto.cedula=txtCedula.Text;
                   objProspecto.correoElectronico=txtCorreo.Text;
                   objProspecto.TelefonoP=txtTelefono.Text;

                    if (logicaNR.EditarProspecto(objProspecto)>0)
	                {
                       MessageBox.Show("Actualizado");

                       dataGridViewProspecto.DataSource=logicaNR.listarProspecto();
                        
                        txtCedula.Text="";
                        txtNombre.Text=""; 
                        txtApellido1.Text="";
                        txtApellido2.Text="";
                        txtCorreo.Text="";
                        txtTelefono.Text="";

                       tabconProspecto.SelectedTab=tabPageDetalleProspecto;
		 
	                  }
                   else
                   {
                     MessageBox.Show("Error al Actualizar Prospecto");
                   }

                   btnGuardar.Text=("Guardar");
	         }

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void FormProspecto_Load(object sender, EventArgs e)
        {
            txtID.Visible = false;
            lblid.Visible = false;
            dataGridViewProspecto.DataSource = logicaNR.listarProspecto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            txtID.Visible = true;
            txtID.Enabled = false;
            lblid.Visible = true;

            //asigna datos seleccionados del data grid view a la caja de tx
            txtID.Text = dataGridViewProspecto.CurrentRow.Cells["idProspecto"].Value.ToString();
            txtCedula.Text = dataGridViewProspecto.CurrentRow.Cells["cedula"].Value.ToString();
            txtNombre.Text = dataGridViewProspecto.CurrentRow.Cells["nombres"].Value.ToString();
            txtApellido1.Text = dataGridViewProspecto.CurrentRow.Cells["apellidoPaterno"].Value.ToString();
            txtApellido2.Text = dataGridViewProspecto.CurrentRow.Cells["apellidoMaterno"].Value.ToString();
            txtCorreo.Text = dataGridViewProspecto.CurrentRow.Cells["correoElectronico"].Value.ToString();
            txtTelefono.Text = dataGridViewProspecto.CurrentRow.Cells["TelefonoP"].Value.ToString();

            tabconProspecto.SelectedTab = tabPageProspecto;
            btnGuardar.Text = "Actualizar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigoP = Convert.ToInt32(dataGridViewProspecto.CurrentRow.Cells["idProspecto"].Value.ToString());

            try
            {
                if (logicaNR.eliminarProspecto(codigoP)>0)
                {
                    MessageBox.Show("Eliminado");
                    dataGridViewProspecto.DataSource = logicaNR.listarProspecto();
                }
            }
            catch
            {
                MessageBox.Show("Error al Eliminar");
                
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Prospecto> listaProspecto = logicaNR.BuscarProspecto(txtBuscar.Text);
            dataGridViewProspecto.DataSource = listaProspecto;
        }
    }
}
