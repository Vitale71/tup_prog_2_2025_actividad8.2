using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models;

internal class FormatoPatenteNoValidaException : ApplicationException
{
    public FormatoPatenteNoValidaException() : base("Formato de patente no válida") { }
}
