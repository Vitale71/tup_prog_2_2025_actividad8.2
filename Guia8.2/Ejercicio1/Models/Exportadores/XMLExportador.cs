using System.Text.RegularExpressions;

namespace Ejercicio1.Models.Exportadores;

public class XMLExportador : IExportador
{
    public string Exportar(Multa m)
    {
      
    }

    public bool Importar(string data, Multa m)
    {
        Regex R = new Regex(@"<patente>([A-Z]{3}[0-9]{3}</patente><vencimiento>([1-31]{2}/[1-12]{2}/[0-9]{4})</vencimiento><importe>(\d+,\d+)</importe>");
        Match mat = R.Match(data);
        if (mat.Success)
        {
            string patente = mat.Groups[1].Value;
            DateOnly vencimiento = DateOnly.ParseExact(mat.Groups[2].Value,"dd/MM/yyyy");
            double importe = Convert.ToDouble(mat.Groups[3].Value);

            m.Patente = patente;
            return true;
        }
        return false;
    }
}
