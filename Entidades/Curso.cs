using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public TiposJornada Jornada { get; set; }

        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }   
        public string Direccion { get; set; }


    }
}