﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivosException : Exception
    {
        public ArchivosException(Exception innerException) : base("Error en la carga de archivos", innerException)
        { }
    }
}
