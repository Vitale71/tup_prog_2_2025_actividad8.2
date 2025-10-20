using Ejercicio1.Models.Exportadores;
using System.Text.RegularExpressions;

namespace Ejercicio1.Models;

public class Multa : IExportable, IComparable
{
    string patente;
    public string Patente {
        get { return patente; }
        set
        {
            Regex regex = new Regex(@"^[a-z]{3}\d{3}$", RegexOptions.IgnoreCase);
            Match match = regex.Match(value);
            if (match.Success)
            {
                this.patente = value;
            }
            else { throw new FormatoPatenteNoValidaException(); }
        }
    }
    public double Importe { get; set; }
    public DateOnly Vencimiento { get; set; }
    public Multa (string patente, double importe, DateOnly V)
    {
        this.Patente = patente;
        this.Importe = importe;
        this.Vencimiento = V;
    }
    public Multa() { }
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
            return this.Patente.CompareTo(multa.Patente);
        return -1;
    }
}
