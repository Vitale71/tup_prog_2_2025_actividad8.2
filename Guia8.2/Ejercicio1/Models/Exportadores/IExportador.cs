namespace Ejercicio1.Models.Exportadores;

public interface IExportador
{
    public bool Importar(string data, Multa m);
    public string Exportar(Multa m);
}
