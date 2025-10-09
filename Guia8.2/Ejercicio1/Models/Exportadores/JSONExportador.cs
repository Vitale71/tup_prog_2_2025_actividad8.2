
namespace Ejercicio1.Models.Exportadores;

public class JSONExportador : IExportador
{
    public string Exportar(Multa m)
    {
        return "";
    }

    public bool Importar(string data, Multa m)
    {
        throw new NotImplementedException();
    }
}
