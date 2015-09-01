using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Deutsch_Englisch_Karteikarten
{
    public partial class Wörterbuch : UserControl
    {
        public string _sLanguage = "Deutsch";

        public Wörterbuch()
        {           
            InitializeComponent();
        }

        private void Wörterbuch_Load(object sender, EventArgs e)
        {

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
    }
}
