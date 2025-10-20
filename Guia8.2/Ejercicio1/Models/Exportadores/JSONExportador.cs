
using System.Text.RegularExpressions;

namespace Ejercicio1.Models.Exportadores;

public class JSONExportador : IExportador
{
    public string Exportar(Multa m)
    {
        return "";
    }

    public bool Importar(string data, Multa m)
    {
        Regex R = new Regex(@"{Patente:([a-z]{3}\d{3}), Vencimiento: ([^<]+), Importe:([^<]+)}", RegexOptions.IgnoreCase);
        Match mat = R.Match(data);
        if (mat.Success)
        {
            string patente = mat.Groups[1].Value;
            DateOnly vencimiento = DateOnly.ParseExact(mat.Groups[2].Value,"dd/MM/yyyy");
            double importe = Convert.ToDouble(mat.Groups[3].Value);


            m.Patente = patente;
            m.Importe = importe;
            m.Vencimiento = vencimiento;
            return true;
        }
        return false;
    }
}
