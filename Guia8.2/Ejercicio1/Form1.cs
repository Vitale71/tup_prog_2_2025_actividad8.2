using ej1.Models.Exportadores;
using Ejercicio1.Models;
using Ejercicio1.Models.Exportadores;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        List<IExportable> exportableslist = new List<IExportable>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lsbVer.Items.Clear();
            lsbVer.Items.AddRange(exportableslist.ToArray());
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Multa nuevo = null;

            string patente = tbPatente.Text;
            DateOnly vencimiento = new DateOnly(dtpVencimiento.Value.Year, dtpVencimiento.Value.Month, dtpVencimiento.Value.Day);
            double importe = Convert.ToDouble(tbImporte.Text);
            nuevo = new Multa(patente, importe, vencimiento);

            exportableslist.Sort();
            int idx = exportableslist.BinarySearch(nuevo);
            if (idx >= 0)
            {
                Multa multa = exportableslist[idx] as Multa;
                multa.Importe += importe;
                if (multa.Vencimiento < ((Multa)nuevo).Vencimiento) ;
                multa.Vencimiento = ((Multa)nuevo).Vencimiento;

            }
            else
            { exportableslist.Add(nuevo); }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(csv)|*.csv|(json)|*.json|(xml)|*.xml|(txt)|*.txt";
            FileStream fs = null;
            StreamReader sr = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                int tipo = openFileDialog1.FilterIndex;
                IExportador exportador = (new ExportadorFactory()).GetInstance(tipo);
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        IExportable nuevo = new Multa();
                        if (nuevo.Importar(line, exportador))
                        {

                            exportableslist.Add(nuevo);
                        }
                    }
                }
                catch (FormatoPatenteNoValidaException ex) 
                { 
                    MessageBox.Show(ex.Message); 
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show(ex.Message); 
                }
            }
        }
    }
}
