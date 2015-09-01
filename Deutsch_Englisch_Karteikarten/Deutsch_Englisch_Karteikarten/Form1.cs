using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Deutsch_Englisch_Karteikarten
{
    public partial class Form1 : Form
    {

        UserControl _uc;

        /// <summary>
        /// Konstruktor, ladet KarteikartenUC ein
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            _uc = new KarteiKarten();
            InitUserControl();
        }

        private void SetUserControl(UserControl uc)
        {
            ClearUserControl();
            _uc = uc;
            InitUserControl();
        }

        private void InitUserControl()
        {
            _uc.Location = new Point(0, 0);
            this.Controls.Add(_uc);
            _uc.Show();
            
        }

        private void ClearUserControl()
        {
            this.Controls.Remove(_uc);
        }


        #region FormEvents


        private void neuerEintragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_uc.GetType() != typeof(NeuerEintrag))
            {
                NeuerEintrag ne = new NeuerEintrag();
                SetUserControl(ne);
            }
        }

        private void wörterbuchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_uc.GetType() != typeof(Wörterbuch))
            {
                Wörterbuch wb = new Wörterbuch();
                SetUserControl(wb);
            }
        }

        private void deutschToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_uc.GetType() != typeof(KarteiKarten))
            {
                KarteiKarten kk = new KarteiKarten();
                SetUserControl(kk);
            }
        }

        private void englischToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_uc.GetType() != typeof(KarteiKarten))
            {
                KarteiKarten kk = new KarteiKarten();
                SetUserControl(kk);
            }
        }
        #endregion

    }
}
