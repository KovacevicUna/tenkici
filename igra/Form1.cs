using System.Drawing;
using System.Windows.Forms;

namespace igra
{
    public partial class Form1 : Form
    {
        bool idiLevo, idiDesno, pucaj, igraJeGotova;
        int brzinaTenka = 8;
        int brzinaMete = 5;
        int rezultat = 0;
        public Form1()
        {
            InitializeComponent();
            int MetaSirina = 0;
            MetaSirina = panMeta.Width;
            int MetaVisina = 0;
            MetaVisina = panMeta.Height;
            
        }

        #region Metode
        public void PomeriDesno()
        {
            panTenk.Left += brzinaTenka;
        }
        public void PomeriLevo()
        {
            panTenk.Left -= brzinaTenka;
        }
        public void Restart()
        {
            idiLevo = false;
            idiDesno = false;
            pucaj = false;
            igraJeGotova = false;
            rezultat = 0;
            labRezultat.Text = $"Score :{rezultat}";
            panTenk.Left = 652;
            panTenk.Top = 691;
        }
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            labRezultat.Text = $"Score : {rezultat}";
            
        }
        #endregion
        #region DugmiciNaTastaturi
        private void Ukljuceno(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                idiLevo = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                idiDesno = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                pucaj = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                Restart();
            }

        }
        private void Iskljuceno(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                idiLevo = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                idiDesno = false;
            }
            if (pucaj == true)
            {
                pucaj = false;
            }

        }
        #endregion
        #region Akcija
        private void btnPucaj_Click(object sender, EventArgs e)
        {


        }
        private void btnDesno_Click(object sender, EventArgs e)
        {
            PomeriDesno();
        }
        #endregion

    }
}