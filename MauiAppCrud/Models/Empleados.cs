﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCrud.Models
{
    public class Empleados
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public decimal Sueldo { get; set; }
        public DateTime FechaContrato { get; set; }

    }
}
