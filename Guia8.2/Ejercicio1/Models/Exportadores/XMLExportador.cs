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
        //Regex R = new Regex(@"<Patente>([a-z]{3}\d{3})</Patente><Vencimiento>(\d{2}/\d{2}/\d{4})</Vencimiento><Importe>(\d+,\d*)</Importe>", RegexOptions.IgnoreCase);
        Regex R = new Regex(@"<Patente>([a-z]{3}\d{3})</Patente><Vencimiento>([^<]+)</Vencimiento><Importe>([^<]+)</Importe>", RegexOptions.IgnoreCase);
        Match mat = R.Match(data);
        if (mat.Success)
        {
            /*string patente = mat.Groups[1].Value;
            DateOnly vencimiento = DateOnly.ParseExact(mat.Groups[2].Value,"dd/MM/yyyy");
            double importe = Convert.ToDouble(mat.Groups[3].Value);
            /*otras formas*/
            string patente = mat.Groups[1].Value.ToUpper();
            DateTime fecha = Convert.ToDateTime(mat.Groups[2].Value);
            DateOnly vencimiento = new DateOnly(fecha.Year,fecha.Month,fecha.Day);
            double importe = Convert.ToDouble(mat.Groups[3].Value);


            m.Patente = patente;
            m.Importe = importe;
            m.Vencimiento = vencimiento;
            return true;
        }
        return false;
    }
}
