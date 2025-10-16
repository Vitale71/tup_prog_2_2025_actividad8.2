using System.Text.RegularExpressions;

namespace Ejercicio1.Models.Exportadores;

public class XMLExportador : IExportador
{
    public string Exportar(Multa m)
    {
        return $@"<Multa><Patente>{m.Patente}</Patente><Vencimiento>{m.Vencimiento}</Vencimiento><Importe>{m.Importe:f2}</Importe></Multa>";
    }

    public bool Importar(string data, Multa m)
    {
        Regex R = new Regex(@"<patente>([A-Z]{3}[0-9]{3}</patente><vencimiento>([1-31]{2}/[1-12]{2}/[0-9]{4})</vencimiento><importe>(\d+,\d+)</importe>", RegexOptions.IgnoreCase);
        Match mat = R.Match(data);
        if (mat.Success)
        {
            string patente = mat.Groups[1].Value;
            DateOnly vencimiento = DateOnly.ParseExact(mat.Groups[2].Value,"dd/MM/yyyy");
            double importe = Convert.ToDouble(mat.Groups[3].Value);
            /*otras formas
            string patente = match.Groups[1].Value.ToUpper();
            DateTime fecha = Convert.ToDateTime(match.Groups[2].Value);
            DateOnly vencimiento = new DateOnly(fecha.Year,fecha.Month,fecha.Day);
            double importe = Convert.ToDouble(match.Groups[3].Value); */


            m.Patente = patente;
            m.Importe = importe;
            m.Vencimiento = vencimiento;
            return true;
        }
        return false;
    }
}
