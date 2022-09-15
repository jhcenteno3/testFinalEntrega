using System;
using System.Collections.Generic;
using System.Text;

namespace testFinal.clases
{
    class UsuarioPermisos
    {
        String ListadoPermisosGeneral;
        String[] PermisosUsuario;

        public UsuarioPermisos(String PermisosGenerales = "crear,editar,visualizar,buscar", int CantidadUsuarios = 4)
        {
            this.ListadoPermisosGeneral = PermisosGenerales;
            this.PermisosUsuario = new string[CantidadUsuarios];
        }

        /**
         * Permiso crear: Permite crear notas
         * Permiso visualizar: Permite visualizar Notas agregadas por otros usuarios con permiso de crear
         * Permiso editar: Permite visualizar en listado las notas de los usuarios y editarlas
         * Permiso buscar: Permite buscar en listado de notas las coincidencias que existan en el listado
         */
        public void CrearPermisosUsuarios()
        {
            this.PermisosUsuario[0] = "crear";
            this.PermisosUsuario[1] = "visualizar";
            this.PermisosUsuario[2] = "editar,visualizar";
            this.PermisosUsuario[3] = "visualizar,buscar";
        }

        /*
         * Se obtienen los permisos por medio del indice y la seleccion del usuario
         */
        public String ObtenerPermisosUsuario(int IndiceUsuario)
        {
            ValidarPermisosUsuariosCreados();
            ValidarIndiceUsuario(IndiceUsuario);
            return this.PermisosUsuario[IndiceUsuario];
        }

        /*
         * Permisos Generales separados por medio de ,
         */
        public String[] ObtenerListadoGeneralPermisosDividos()
        {
            return this.ListadoPermisosGeneral.Split(",");
        }
        /*
         * Valida que el indice del usuario seleccionado exista en los permisos y tenga permisos
         */
        private void ValidarIndiceUsuario(int IndiceUsuario)
        {
            if(IndiceUsuario < -1 || IndiceUsuario > 4)
            {
                throw new Exception("El usuario no se encuentra");
            }

            if(!(this.PermisosUsuario[IndiceUsuario].Length > 0))
            {
                throw new Exception("El usuario seleccionado no posee ningun permiso");
            }
        }
        
        /*
         * Valida que se crearan los permisos a los usuarios
         */
        private void ValidarPermisosUsuariosCreados()
        {

            if(this.PermisosUsuario.Length != 4)
            {
                throw new Exception("No se han creado los permisos a los usuarios");
            }
        }

    }
}
