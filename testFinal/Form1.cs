using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testFinal.clases;

namespace testFinal
{
    public partial class FormNotas : Form
    {
        int cantidadMaximaNotas = 100;
        string[] permisos = new string[4];
        string ListadoPermisosGeneral = "crear,editar,visualizar,buscar";
        Notas[] notas;
        int cantidadNotasRegistradas = 0;
        int idSeleccionadoEdicionNota;
        char[] caracteresEscapar = { '*', ' ', '\'' };

        public FormNotas()
        {
            InitializeComponent();
            CrearPermisos();
            CrearArregloNotas();
            MostrarOcultarElementosPermisosUsuarios("disabled");
        }

        private void CrearArregloNotas()
        {
            notas = new Notas[cantidadMaximaNotas];
        }

        private void CrearPermisos()
        {
            permisos[0] = "crear";
            permisos[1] = "visualizar";
            permisos[2] = "crear,editar";
            permisos[3] = "visualizar,buscar";
        }

        private void VerificarPermisosUsuario()
        {
            int indiceUsuario;
            int.TryParse(cbUsuario.SelectedIndex.ToString(), out indiceUsuario);

            if (indiceUsuario > -1)
            {
                MostrarOcultarElementosPermisosUsuarios(permisos[indiceUsuario]);
            }
            else
            {
                MostrarOcultarElementosPermisosUsuarios("disable");
            }
        }

        private void MostrarOcultarElementosPermisosUsuarios(string permisosUsuario)
        {
            string[] permisosDivididos = ListadoPermisosGeneral.Split(',');
            OcultarDesactivarTodosElementos();
            foreach(String ValorPermisos in permisosDivididos)
            {
                if(((ValorPermisos == "crear") || (ValorPermisos == "editar")) && permisosUsuario.Contains(ValorPermisos))
                {
                    CrearEditarElementosNotas(true);
                }
                
                if (ValorPermisos == "visualizar" && permisosUsuario.Contains(ValorPermisos))
                {
                    VisualizarElementosNotas(true);
                }
               
                
                if (ValorPermisos == "buscar" && permisosUsuario.Contains(ValorPermisos))
                {
                    BuscarElementoNotas(true);
                }
            }
        }

        private void BuscarElementoNotas(bool v)
        {
            tbBuscador.Enabled = v;
            tbBuscador.ReadOnly = !v;
        }

        private void OcultarDesactivarTodosElementos()
        {
            CrearEditarElementosNotas(false);
            VisualizarElementosNotas(false);
            BuscarElementoNotas(false);
        }

        private void VisualizarElementosNotas(bool v)
        {
            if (v)
            {
                agregarRowsListadoNotas();
            }
            else
            {
                removerRowsListadoNotas();
            }
        }

        private void CrearEditarElementosNotas(bool v)
        {
            btnGuardar.Visible = v;
            btnLimpiar.Visible = v;
            tbTitulo.Enabled = v;
            tbCuerpo.Enabled = v;
            tbTitulo.ReadOnly = !v;
            tbCuerpo.ReadOnly = !v;
            dtpFecha.Enabled = v;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                validarCantidadNotasAgregadas();
                string titulo = ValidarNull(tbTitulo.Text) && validarLonguitudTexto(tbTitulo.Text) ? tbTitulo.Text : throw new Exception("titulo invalido");
                string cuerpo = ValidarNull(tbCuerpo.Text) && validarLonguitudTexto(tbCuerpo.Text) ? tbCuerpo.Text : throw new Exception("cuerpo invalido");
                string fecha = ValidarNull(dtpFecha.Text) && validarLonguitudTexto(dtpFecha.Text) ? dtpFecha.Text : throw new Exception("fecha no seleccionada");
                ValidarFormatoFecha(fecha);
                Notas notasTemporal = new Notas(cantidadNotasRegistradas,titulo, cuerpo,fecha);
                int indice = idSeleccionadoEdicionNota >= 0 ? idSeleccionadoEdicionNota : cantidadNotasRegistradas;
                notas[indice] = notasTemporal;
                string mensaje = "Nota agregada Exitosamente";

                if (idSeleccionadoEdicionNota >= 0 && labModoEdicion.Visible)
                {
                    mensaje = "Nota Actualizada Exitosamente";
                }
                else
                {
                    cantidadNotasRegistradas++;
                }

                limpiarCampos();
                VerificarPermisosUsuario();
                MessageBox.Show(mensaje);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validarLonguitudTexto(string text)
        {
            if(text.Length <= 1)
            {
                throw new Exception("El texto ingresado debe tener al menos dos letras");
            }

            return true;
        }

        private void validarCantidadNotasAgregadas()
        {
            if (cantidadNotasRegistradas == cantidadMaximaNotas)
            {
                throw new Exception("Ha llegado al límite de notas que se pueden agregar");
            }
        }

        private void removerRowsListadoNotas()
        {
            dgvListadoNotas.Rows.Clear();
        }

        private void agregarRowsListadoNotas()
        {
            for (int indice = 0; indice <= cantidadNotasRegistradas; indice++)
            {
                if(notas[indice] != null)
                {
                    string titulo = notas[indice].Titulo.ToString();
                    string cuerpo = notas[indice].Cuerpo.ToString();
                    string fecha = notas[indice].Fecha.ToString();
                    dgvListadoNotas.Rows.Add(indice, titulo, cuerpo, fecha);
                }
            }

        }

        private void ValidarFormatoFecha(string fecha)
        {
            string[] fechaDividida = fecha.Split('/');
            if (fechaDividida.Length != 3)
            {
                throw new Exception("El formato no es el adecuado");
            }

            for (int indice = 0; indice < fechaDividida.Length; indice++)
            {
                string numero = fechaDividida[indice];
                if (!(int.TryParse(numero, out _)))
                {
                    throw new Exception("El formato no es correcto");
                }
            }
        }

        private bool ValidarNull(string text)
        {
            text = text.Trim(caracteresEscapar);
            return !(text.Equals(null) || text.Equals(' ') || text.Length <= 0);
        }

        private void CbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                limpiarCampos();
                VerificarPermisosUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            tbTitulo.Text = "";
            tbCuerpo.Text = "";
            mostrarOcultarModoEdicion(false);
            idSeleccionadoEdicionNota = -1;
        }

        private void mostrarOcultarModoEdicion(bool valor)
        {
            labModoEdicion.Visible = valor;
            
        }

        private void dgvListadoNotas_CellDoubleClick(object sender, EventArgs e)
        {
            try
            {
                
                int.TryParse(this.dgvListadoNotas.CurrentRow.Cells[0].Value.ToString(), out idSeleccionadoEdicionNota);
                string titulo = this.dgvListadoNotas.CurrentRow.Cells[1].Value.ToString();
                string cuerpo = this.dgvListadoNotas.CurrentRow.Cells[2].Value.ToString(); 
                string fecha = this.dgvListadoNotas.CurrentRow.Cells[3].Value.ToString();

                tbTitulo.Text = titulo;
                tbCuerpo.Text = cuerpo;
                dtpFecha.Value = Convert.ToDateTime(fecha);

                mostrarOcultarModoEdicion(true);

                MessageBox.Show("Se muestra la informacion de la nota en el apartado de creacion/edicion de notas");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbBuscador_TextChanged(object sender, EventArgs e)
        {
           
            string palabraABuscar = tbBuscador.Text.Trim(caracteresEscapar);
            if(palabraABuscar.Length <= 0)
            {
                removerRowsListadoNotas();
                agregarRowsListadoNotas();
            }
            else
            {
                obtenerMostrarResultadosBusqueda(palabraABuscar);
            }
        }

        private void obtenerMostrarResultadosBusqueda(string palabra)
        {
            removerRowsListadoNotas();
            for (int indice = 0; indice <= cantidadNotasRegistradas; indice++)
            {
                if (notas[indice] != null)
                {
                    string titulo = notas[indice].Titulo.ToString();
                    string cuerpo = notas[indice].Cuerpo.ToString();
                    string fecha = notas[indice].Fecha.ToString();

                    if(buscarEntrePalabras(titulo, palabra) || buscarEntrePalabras(cuerpo,palabra))
                    {
                        dgvListadoNotas.Rows.Add(indice, titulo, cuerpo, fecha);
                    }
                }
            }
        }

        public bool buscarEntrePalabras(string texto, string palabraBuscar)
        {
            if (texto.Contains(palabraBuscar))
            {
                return true;
            }

            return false;
        }
    }
}
