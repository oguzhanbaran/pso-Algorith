using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _163311052_pso
{
    public partial class pso_Form : Form
    {
        public pso_Form()
        {
            InitializeComponent();
        }
        int parcacikSayisi,parcacikAltSinir,parcacikUstSinir,c1,iterasyonSayisi;

        private void NumericPUst_ValueChanged(object sender, EventArgs e)
        {
            numericPAlt.Value = -numericPUst.Value;
        }

        private void Pso_Form_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Parçacık", 100);
            listView1.Columns.Add("x1", 70);
            listView1.Columns.Add("v1", 70);
            listView1.Columns.Add("k1", 70);
            listView1.Columns.Add("x2", 70);
            listView1.Columns.Add("v2", 70);
            listView1.Columns.Add("k2", 70);
            listView1.Columns.Add("pBest", 70);

        }

        private void NumericPAlt_ValueChanged(object sender, EventArgs e)
        {
            numericPUst.Value = Math.Abs(numericPAlt.Value);
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            chart1.ResetAutoValues();
            chart1.Series.Clear();
            listView1.Items.Clear();
            parcacikSayisi = (int)numericParcaSayisi.Value;
            parcacikAltSinir = (int)numericPAlt.Value;
            parcacikUstSinir= (int)numericPUst.Value;
            c1 = (int)numericOFaktor.Value;
            iterasyonSayisi = (int)numericISayisi.Value;
            PSO yeniSuru = new PSO(parcacikSayisi,parcacikAltSinir,parcacikUstSinir,c1,iterasyonSayisi);
            double[,] konum = yeniSuru.konumDegerleri;
            double[,] hiz = yeniSuru.hızDegerleri;
            double[,] parcacikDeger = yeniSuru.parcacikDegerleri;
            double[] uygunlukDegerleri = yeniSuru.uygunlukDegeri;
            double gbest = yeniSuru.gBest;
            for (int i = 0; i < parcacikSayisi; i++)
            {
                string[] row = new string[] { (i+1).ToString() ,parcacikDeger[i,0].ToString(), hiz[i, 0].ToString(),konum[i,0].ToString(),
                    parcacikDeger[i, 1].ToString(), hiz[i, 1].ToString(), konum[i, 1].ToString(),uygunlukDegerleri[i].ToString()};
                
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);
                if (row[7] == gbest.ToString())
                {
                    listView1.Items[i].BackColor = Color.Black;
                    listView1.Items[i].ForeColor = Color.White;
                }
            }
            label6.Text = iterasyonSayisi+". iterasyon sonucunda oluşan en iyi değer :"+gbest.ToString();
            for (int i = 0; i < parcacikSayisi; i++)
            {
                chart1.Series.Add("Parçacık" + (i+1));
                chart1.Series["Parçacık" + (i+1)].Points.Add(uygunlukDegerleri[i]);
            }

        }
    }
}
