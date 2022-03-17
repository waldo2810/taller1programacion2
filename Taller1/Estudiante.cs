﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taller1
{
    public class Estudiante : Persona
    {
        public Estudiante()
        {
            string edad;
            int facultad;
            string nombreFacultad;
        }

        public void settearFaculad(int facultad)
        {
            switch (facultad)
            {
                case 1:
                    nombreFacultad = "Ingenieria";
                    break;
                case 2:
                    nombreFacultad = "Medicina";
                    break;
                case 3:
                    nombreFacultad = "Ciencias Sociales";
                    break;
                case 4:
                    nombreFacultad = "ciencias administrativas";
                    break;
            }
        }

        public string edad { get; set; }
        public int facultad { get; set; }
        public string nombreFacultad { get; set; }
    }
}
