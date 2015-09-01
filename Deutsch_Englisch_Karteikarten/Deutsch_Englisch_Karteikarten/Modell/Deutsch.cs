using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Deutsch_Englisch_Karteikarten.DataAccess;

namespace Deutsch_Englisch_Karteikarten.Modell
{
    public class Deutsch
    {
        //Variablen
        private string m_sWort;
        private string m_sArtikel;
        private string m_sGUID;

        private Englisch m_Englisch;

        //List of Englisch Word translations
        private List<Englisch> m_listEnglisch;

        //Konstruktor
        public Deutsch(string wort, string artikel = "")
        {
            Wort = wort;
            Artikel = artikel;

            m_listEnglisch = new List<Englisch>();
        }

        #region Getter/Setter

        public string Wort
        {
            get { return m_sWort; }
            set { m_sWort = value; }
        }

        public string Artikel
        {
            get { return m_sArtikel; }
            set { m_sArtikel = value; }
        }

        public string GUID
        {
            get { return m_sGUID; }
            set { m_sGUID = value; }
        }

        //Accepts Englisch object and saves it to the list
        public Englisch Englisch
        {
            set { m_listEnglisch.Add(value); }
        }

        //returns the Englisch Translation list
        public List<Englisch> Uebersetzungen
        {
            get { return m_listEnglisch; }
        }

        #endregion

        public void func(Deutsch deutsch, Englisch englisch)
        {
            DataFactory.dpf.DP.saveDeutscheRekord(deutsch, englisch);
        }


    }
}
