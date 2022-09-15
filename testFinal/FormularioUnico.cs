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
        readonly int CantidadMaximaNotas = 100;
        Nota[] Notas;
        UsuarioPermisos Permisos;
        int CantidadNotasAgregadas = 0;
        int IdSeleccionadoEdicionNota;
        readonly char[] CaracteresEscapar = { '*', ' ', '\'' };

        public FormNotas()
        {
            InitializeComponent();
            CrearPermisosUsuarios();
            CrearArregloNotas();
            MostrarOcultarElementosPermisosUsuarios("disabled");
        }
        /*
         * Crea los permisos para los usuarios
         */
        private void CrearPermisosUsuarios()
        {
            this.Permisos = new UsuarioPermisos();
            this.Permisos.CrearPermisosUsuarios();
            
        }

        /*
         * Crear un arreglo de Nota con el tamaño fijo estipulado en la variable del FormularioUnico
         */
        private void CrearArregloNotas()
        {
            Notas = new Nota[CantidadMaximaNotas];
        }

        /*
         * Verifica los permisos por medio del indice seleccionado
         */
        private void VerificarPermisosUsuario()
        {
            int IndiceUsuario = -1;
            int.TryParse(cbUsuario.SelectedIndex.ToString(), out IndiceUsuario);

            if (IndiceUsuario > -1)
            {
                MostrarOcultarElementosPermisosUsuarios(this.Permisos.ObtenerPermisosUsuario(IndiceUsuario));
            }
            else
            {
                MostrarOcultarElementosPermisosUsuarios("disabled");
            }
        }

        /*
         * verifica el permiso disabled que inhabilita todo a excepcion la seleccion de usuarios
         * en caso de no ser el permiso disabled se habilita los elementos estipulados por los permisos (Ver clase UsuarioPermisos)
         */
        private void MostrarOcultarElementosPermisosUsuarios(string PermisosUsuario)
        {
            OcultarDesactivarTodosElementos();
            string[] PermisosDivididos = this.Permisos.ObtenerListadoGeneralPermisosDividos();
            foreach (String ValorPermisos in PermisosDivididos)
            {
                if (((ValorPermisos == "crear") || (ValorPermisos == "editar")) && PermisosUsuario.Contains(ValorPermisos))
                {
                    CrearEditarElementosNotas(true);
                }

                if (ValorPermisos == "visualizar" && PermisosUsuario.Contains(ValorPermisos))
                {
                    VisualizarElementosNotas(true);
                }


                if (ValorPermisos == "buscar" && PermisosUsuario.Contains(ValorPermisos))
                {
                    BuscarElementoNotas(true);
                }

            }
        }

        /*
         * Habilita o inhabilita la busqueda del elemento Textbox utilizado como buscador
         */
        private void BuscarElementoNotas(bool v)
        {
            tbBuscador.Enabled = v;
            tbBuscador.ReadOnly = !v;
        }

        /*
         * inhabilita todos los elementos visuales a excepcion del selector de usuarios
         */
        private void OcultarDesactivarTodosElementos()
        {
            CrearEditarElementosNotas(false);
            VisualizarElementosNotas(false);
            BuscarElementoNotas(false);
        }

        /*
         * En dependencia del parametro visualiza todas las notas o las remueve del DatagridView asociado al listado de notas
         */
        private void VisualizarElementosNotas(bool v)
        {
            if (v)
            {
                AgregarRowsListadoNotas();
            }
            else
            {
                RemoverRowsListadoNotas();
            }
        }

        /*
         * Habilita los elementos para agregar Notas
         */
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

        /*
         * Valida la cantidad de notas agregadas (no puede sobrepasar a 100)
         * Valida campos titulo, cuerpo, fecha
         * valida formato de fecha
         * Funciona como nueva nota y edicion de notas
         * limpia campos para agregar nueva nota
         * verifica permisos del usuario para habilitar o inhabilitar los componentes asociados al permiso del usuario
         */
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCantidadNotasAgregadas();
                string Titulo = ValidarNull(tbTitulo.Text) && ValidarLonguitudTexto(tbTitulo.Text) ? tbTitulo.Text : throw new Exception("titulo invalido");
                string Cuerpo = ValidarNull(tbCuerpo.Text) && ValidarLonguitudTexto(tbCuerpo.Text) ? tbCuerpo.Text : throw new Exception("cuerpo invalido");
                string Fecha = ValidarNull(dtpFecha.Text) && ValidarLonguitudTexto(dtpFecha.Text) ? dtpFecha.Text : throw new Exception("fecha no seleccionada");
                ValidarFormatoFecha(Fecha);
                Nota NotaTemporal = new Nota(CantidadNotasAgregadas, Titulo, Cuerpo,Fecha);
                int Indice = IdSeleccionadoEdicionNota >= 0 ? IdSeleccionadoEdicionNota : CantidadNotasAgregadas;
                Notas[Indice] = NotaTemporal;
                string mensaje = "Nota agregada Exitosamente";

                if (IdSeleccionadoEdicionNota >= 0 && labModoEdicion.Visible)
                {
                    mensaje = "Nota Actualizada Exitosamente";
                }
                else
                {
                    CantidadNotasAgregadas++;
                }

                LimpiarCampos();
                VerificarPermisosUsuario();
                MessageBox.Show(mensaje);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
         * valida que el texto enviado por parametro tenga mas de un caracter
         */
        private bool ValidarLonguitudTexto(string Texto)
        {
            Texto = Texto.Trim(CaracteresEscapar);
            if(Texto.Length <= 1)
            {
                throw new Exception("El texto ingresado debe tener al menos dos letras");
            }

            return true;
        }

        /*
         * Valida que la cantidad de notas agregadas no sobrepase la cantidad estipulada de 100
         */
        private void ValidarCantidadNotasAgregadas()
        {
            if (CantidadNotasAgregadas == CantidadMaximaNotas)
            {
                throw new Exception("Ha llegado al límite de notas que se pueden agregar");
            }
        }

        /*
         Remueve todas las notas del listado
         */
        private void RemoverRowsListadoNotas()
        {
            dgvListadoNotas.Rows.Clear();
        }
        /*
         Agrega todas las notas al listado
         */
        private void AgregarRowsListadoNotas()
        {
            for (int Indice = 0; Indice <= CantidadNotasAgregadas; Indice++)
            {
                if(Notas[Indice] != null)
                {
                    string Titulo = Notas[Indice].Titulo.ToString();
                    string Cuerpo = Notas[Indice].Cuerpo.ToString();
                    string Fecha = Notas[Indice].Fecha.ToString();
                    dgvListadoNotas.Rows.Add(Indice, Titulo, Cuerpo, Fecha);
                }
            }

        }
        /*
         Valida el formato de fecha, que tenga 3 numeros separados por / y sean enteros
         */
        private void ValidarFormatoFecha(string Fecha)
        {
            string[] FechaDividida = Fecha.Split('/');
            if (FechaDividida.Length != 3)
            {
                throw new Exception("El formato no es el adecuado");
            }

            for (int Indice = 0; Indice < FechaDividida.Length; Indice++)
            {
                string Numero = FechaDividida[Indice];
                if (!(int.TryParse(Numero, out _)))
                {
                    throw new Exception("El formato no es correcto");
                }
            }
        }

        /*
         Valida que el texto no sea vacio y nulo
         */
        private bool ValidarNull(string Texto)
        {
            Texto = Texto.Trim(CaracteresEscapar);
            return !(Texto.Equals(null) || Texto.Equals(' ') || Texto.Length <= 0);
        }

        private void CbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
                VerificarPermisosUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        /*
         Limpia campos de titulo, cuerpo y cambia el estado de modo edicion a nuevo en caso que se estuviera en modo edicion
         */
        private void LimpiarCampos()
        {
            tbTitulo.Text = "";
            tbCuerpo.Text = "";
            MostrarOcultarModoEdicion(false);
            IdSeleccionadoEdicionNota = -1;
        }
        /*
         Muestra mensaje que esta en modo edicion 
         */
        private void MostrarOcultarModoEdicion(bool valor)
        {
            labModoEdicion.Visible = valor;
            
        }
        /*
         Evento doble click sobre elementos del listado
        Se muestra el texto modo edicion
         */
        private void dgvListadoNotas_CellDoubleClick(object sender, EventArgs  e)
        {
            try
            {
                int.TryParse(this.dgvListadoNotas.CurrentRow.Cells[0].Value.ToString(), out IdSeleccionadoEdicionNota);
                string Titulo = this.dgvListadoNotas.CurrentRow.Cells[1].Value.ToString();
                string Cuerpo = this.dgvListadoNotas.CurrentRow.Cells[2].Value.ToString();
                string Fecha = this.dgvListadoNotas.CurrentRow.Cells[3].Value.ToString();

                tbTitulo.Text = Titulo;
                tbCuerpo.Text = Cuerpo;
                dtpFecha.Value = Convert.ToDateTime(Fecha);

                MostrarOcultarModoEdicion(true);

                MessageBox.Show("Se muestra la informacion de la nota en el apartado de creacion/edicion de notas");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
         Evento change del buscador
            Si esta vacio el buscador se eliminan los resultados anteriores y se agregan todos los resultados
            si no esta vacio se hace busqueda en los resultados y solo se muestran los que coincidan
         */
        private void tbBuscador_TextChanged(object sender, EventArgs e)
        {
           
            string PalabraABuscar = tbBuscador.Text.Trim(CaracteresEscapar);
            if(PalabraABuscar.Length <= 0)
            {
                RemoverRowsListadoNotas();
                AgregarRowsListadoNotas();
            }
            else
            {
                ObtenerMostrarResultadosBusqueda(PalabraABuscar);
            }
        }

        /*
         Se filtra las coincidencias de la busqueda y las notas agregadas por los usuarios
         */
        private void ObtenerMostrarResultadosBusqueda(string palabra)
        {
            RemoverRowsListadoNotas(); 
            for (int Indice = 0; Indice <= CantidadNotasAgregadas; Indice++)
            {
                if (Notas[Indice] != null)
                {
                    string Titulo = Notas[Indice].Titulo.ToString();
                    string Cuerpo = Notas[Indice].Cuerpo.ToString();
                    string Fecha = Notas[Indice].Fecha.ToString();

                    if(BuscarEntrePalabras(Titulo, palabra) || BuscarEntrePalabras(Cuerpo,palabra))
                    {
                        dgvListadoNotas.Rows.Add(Indice, Titulo, Cuerpo, Fecha);
                    }
                }
            }
        }
        /*
         busca las coincidencias entre el texto y la palabra que se envia para buscar
         */
        public bool BuscarEntrePalabras(string Texto, string PalabraBuscar)
        {
            if (Texto.Contains(PalabraBuscar))
            {
                return true;
            }

            return false;
        }
    }
}
