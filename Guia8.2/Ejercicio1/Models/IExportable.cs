using Ejercicio1.Models.Exportadores;

namespace Ejercicio1.Models;

public interface IExportable
{
    public bool Importar(string data, IExportador exportador);
    public string Exportar(IExportador exportador);
}
