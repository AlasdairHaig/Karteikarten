using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Deutsch_Englisch_Karteikarten.DataAccess;
using Deutsch_Englisch_Karteikarten.Modell;

namespace Deutsch_Englisch_Karteikarten
{
    public partial class NeuerEintrag : UserControl
    {

        private string _sDeutschText;
        private string _sEnglischText;

        public NeuerEintrag()
        {
            InitializeComponent();

            _sDeutschText = DeutschComboBx.Text;
            _sEnglischText = EnglischComboBx.Text;


        }

        public string DeutschTxt
        {
            set { _sDeutschText = value; }
            get { return _sDeutschText; }
        }

        public string EnglischTxt
        {
            set { _sEnglischText = value; }
            get { return _sEnglischText; }
        }



        private void _alterDatabaseBtn_Click(object sender, EventArgs e)
        {
            DeutschTxt = DeutschComboBx.Text;
            EnglischTxt = EnglischComboBx.Text;

            Deutsch dt = new Deutsch(DeutschTxt);
            Englisch en = new Englisch(EnglischTxt);

            while (DeutschTxt == "")
            {
                MessageBox.Show("Deutsch Word fehlt!");
                return;
            } 

            while (EnglischTxt == "")
            {
                MessageBox.Show("Englisch Word fehlt!");
                return;
            } 

            if ((DeutschComboBx.Text != "") && (EnglischComboBx.Text != ""))
            {
                dt.func(dt, en);
                DeutschComboBx.Text = "";
                EnglischComboBx.Text = "";
            }
        }

        private void DeutschTxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void NeuerEintrag_Load(object sender, EventArgs e)
        {

        }

    }
}
