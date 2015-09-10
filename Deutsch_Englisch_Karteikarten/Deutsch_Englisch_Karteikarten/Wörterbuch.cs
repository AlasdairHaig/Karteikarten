using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Deutsch_Englisch_Karteikarten.DataAccess;

namespace Deutsch_Englisch_Karteikarten
{
    public partial class Wörterbuch : UserControl
    {
        public string _sLanguage = "Deutsch";

        private List<string> searchResults;
        AutoCompleteStringCollection acsc;

        public Wörterbuch()
        {           
            InitializeComponent();
            searchResults = new List<string>();
            acsc = new AutoCompleteStringCollection();
        }

        private void Wörterbuch_Load(object sender, EventArgs e)
        {
            comboBox1.AutoCompleteCustomSource = acsc;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_sLanguage == "Deutsch")
            {
                button1.Text = "Englisch -> Deutsch";
                _sLanguage = "Englisch";
            }
            else if (_sLanguage == "Englisch")
            {
                button1.Text = "Deutsch -> Englisch";
                _sLanguage = "Deutsch";
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            searchResults = DataFactory.dpf.DP.findMatchesKreuzTabl(comboBox1.Text);
            acsc.AddRange(searchResults.ToArray());
        }
        
    }
}
