using Ejercicio1.Models.Exportadores;

namespace Ejercicio1.Models;

public class Multa : IExportable, IComparable
{
    public string Patente {  get; set; }
    public double Importe { get; set; }
    public DateOnly Vencimiento { get; set; }
    public Multa (string patente, double importe, DateOnly V)
    {
        this.Patente = patente;
        this.Importe = importe;
        this.Vencimiento = V;
    }

    public bool Importar(string data, IExportador exportador)
    {
        return exportador.Importar(data, this);
    }

    public string Exportar(IExportador exportador)
    {
        return exportador.Exportar(this);
    }

    public override string ToString()
    {
        return $"Patente: {Patente}, " +
            $"Importe: {Importe}, " +
            $"Vencimiento: {Vencimiento:dd/MM/yyyy}";
    }

    public int CompareTo(object obj)
    {
        Multa multa = obj as Multa;
        if (multa != null) 
            return this.Patente.CompareTo(this.Importe);
        return -1;
    }
}
