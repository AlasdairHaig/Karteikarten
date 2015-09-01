using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deutsch_Englisch_Karteikarten.Modell
{
    public class Englisch
    {
        private string m_sWord;
        private string m_sGUID;

        private Deutsch m_Deutsch;

        //List of deutsche Woerter Übersetzungen
        private List<Deutsch> m_listDeutsch;

        //Konstruktor
        public Englisch(string word)
        {
            m_sWord = word;
            m_listDeutsch = new List<Deutsch>();
        }

        #region Getter\Setter

        public string Word
        {
            get { return m_sWord; }
            set { m_sWord = value; }
        }

        public string GUID
        {
            get { return m_sGUID; }
            set { m_sGUID = value; }
        }

        public Deutsch Deutsch
        {
            set { m_listDeutsch.Add(value); }
        }

        public List<Deutsch> Uebersetzungen
        {
            get { return m_listDeutsch; }
        }

        #endregion
    }
}
