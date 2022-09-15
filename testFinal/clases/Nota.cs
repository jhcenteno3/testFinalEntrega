using System;
using System.Collections.Generic;
using System.Text;

namespace testFinal.clases
{
    class Nota
    {
        int id;
        string titulo;
        string cuerpo;
        string fecha;

        public Nota(int id,string titulo, string cuerpo, string fecha)
        {
            this.id = id;
            this.Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            this.Cuerpo = cuerpo ?? throw new ArgumentNullException(nameof(cuerpo));
            this.Fecha = fecha ?? throw new ArgumentNullException(nameof(fecha));
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Cuerpo { get => cuerpo; set => cuerpo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
