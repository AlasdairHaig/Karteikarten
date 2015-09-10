using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using Deutsch_Englisch_Karteikarten.Modell;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Deutsch_Englisch_Karteikarten.DataAccess
{
    /// <summary>
    /// DataProvider macht alles. Es enthält alle methoden, die den Datenbank sucht und ändert.
    /// </summary>
    public class DataProvider
    {
        private const string _connPath = @"C:\Users\b.wood\Desktop\Deutsch_Englisch_Datenbank.accdb";

        private readonly string _connString;

        public DataProvider()
        {
            _connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + _connPath + ";Persist Security Info=False;";

        }

        #region first

        /// <summary>
        /// Zurückliefert eine Bindinglist, die hält, das Deutsch Tabelle von Datenbank
        /// </summary>
        /// <returns></returns>
        public BindingList<Deutsch> GetAllDeutscheWoerter()
        {
            BindingList<Deutsch> list = new BindingList<Deutsch>();

            using (OleDbConnection conn = new OleDbConnection(_connString))
            {
                conn.Open();
                //select all from deutsch
                OleDbCommand command = new OleDbCommand("Select * From Deutsch", conn);
                OleDbDataReader reader = command.ExecuteReader();
                //while read
                while (reader.Read())
                {
                    Deutsch deutsch = new Deutsch("");
                    deutsch.GUID = reader[1].ToString();
                    deutsch.Wort = reader[2].ToString();
                    deutsch.Artikel = reader[3].ToString();
                    list.Add(deutsch);
                }
                conn.Close();
            }
            return list;
        }

        /// <summary>
        /// Zurückliefert eine Bindinglist, die hält, das Englisch Tabelle von Datenbank
        /// </summary>
        /// <returns></returns>
        public BindingList<Englisch> GetAllEnglischeWoerter()
        {
            BindingList<Englisch> list = new BindingList<Englisch>();

            using (OleDbConnection conn = new OleDbConnection(_connString))
            {
                conn.Open();
                //select all from Englisch
                OleDbCommand command = new OleDbCommand("Select * From Englisch", conn);
                OleDbDataReader reader = command.ExecuteReader();
                //while read
                while (reader.Read())
                {
                    Englisch englisch = new Englisch("");
                    englisch.GUID = reader[1].ToString();
                    englisch.Word = reader[2].ToString();
                    list.Add(englisch);
                }
                conn.Close();
            }
            return list;
        }

        /// <summary>
        /// Speichert deutsch und englisch elements, und GuiD in kreuztabelle
        /// </summary>
        /// <param name="deutsch"></param>
        /// <param name="englisch"></param>
        public void saveDeutscheRekord(Deutsch deutsch, Englisch englisch)
        {
            /*       
             * Ist deutsches Rekord in der datenbank ??
             * -->Nein --> deutsches wort in datenbank speichern
             *           + Ist englische Wort dazu in Englisch Tabelle   
             *           --> Ja --> getEngWort --> in kreuztabelle speichern
             *           --> Nein --> in datenbank speichern --> kreuztabelle speichern
             * -->Ja --> deutsches wort aus der datenbank laden 
             *           + Ist englische Wort dazu in Englisch Tabelle
             *           --> Ja --> getEngWort 
             *                      + Ist englishes Wort GUID und deutches Wort GUID schon in kreuztabelle
             *                      --> Ja --> Mach nichts
             *                      --> Nein --> in kreuztabelle speichern
             *           --> Nein --> in datenbank speichern --> kreuztabelle speichern          
             */

            if (!(pruefenDeutschList(deutsch)))
            {
                saveDeutschesWord(deutsch);

                if (pruefenEnglischList(englisch))
                {
                    saveKreuzGuid(suchenDeutschRekord(deutsch), suchenEnglischRekord(englisch));
                }
                else
                {
                    saveEnglischWord(englisch);

                    saveKreuzGuid(suchenDeutschRekord(deutsch), suchenEnglischRekord(englisch));
                }
            }
            else
            {
                Deutsch deu = suchenDeutschRekord(deutsch);

                if (pruefenEnglischList(englisch))
                {
                    Englisch eng = suchenEnglischRekord(englisch);

                    if (pruefenKreuzList(deu, eng))
                    {
                        return;
                    }
                    else
                    {
                        saveKreuzGuid(deu, eng);
                    }
                }
                else
                {
                    saveEnglischWord(englisch);

                    saveKreuzGuid(deu, suchenEnglischRekord(englisch));
                }
            }
        }

        /// <summary>
        /// Speichert deutsche Wort als neue Rekord in Datenbank
        /// </summary>
        /// <param name="deutsch"></param>
        public void saveDeutschesWord(Deutsch deutsch)
        {
                using (OleDbConnection conn = new OleDbConnection(_connString))
                {
                    conn.Open();
                    //erstellen in deutsch
                    OleDbCommand command = new OleDbCommand("Insert into Deutsch ([Wort],[Artikel]) values (?,?)", conn);
                    command.Parameters.AddWithValue("@Wort", deutsch.Wort);
                    command.Parameters.AddWithValue("@Artikel", deutsch.Artikel); 
                    command.ExecuteNonQuery(); 

                    conn.Close();
                }
        }

        /// <summary>
        /// Speichert englische Word als neue Rekord in Datenbank
        /// </summary>
        /// <param name="englisch"></param>
        public void saveEnglischWord(Englisch englisch)
        {
            using (OleDbConnection conn = new OleDbConnection(_connString))
            {
                conn.Open();
                //erstellen in englisch
                OleDbCommand command = new OleDbCommand("Insert into Englisch ([Word]) values (?)", conn);
                command.Parameters.AddWithValue("@Word", englisch.Word);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        /// <summary>
        /// Speichert zwei UUID nummer vom beiden Deutsch und Englisch Aufzeichnungen
        /// </summary>
        /// <param name="deutsch"></param>
        /// <param name="englisch"></param>
        public void saveKreuzGuid(Deutsch deutsch, Englisch englisch)
        {
            deutsch.Englisch = englisch;

            using (OleDbConnection conn = new OleDbConnection(_connString))
            {
                conn.Open();
                //erstellen EnglischGuid und DeutschGuid
                OleDbCommand command = new OleDbCommand("Insert into Deutsch_Englisch ([DeutschUUID],[EnglischUUID]) values (?,?)", conn);
                command.Parameters.AddWithValue("@DeutschUUID", deutsch.GUID);
                command.Parameters.AddWithValue("@EnglischUUID", englisch.GUID);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        /// <summary>
        /// Sucht ob einen Rekord gibt in den Deutsche Tabelle
        /// </summary>
        /// <param name="deutsch"></param>
        /// <returns></returns>
        public bool pruefenDeutschList(Deutsch deutsch)
        {
            BindingList<Deutsch> list = GetAllDeutscheWoerter();

            if (deutsch != null)
            {
                foreach (Deutsch deu in list)
                {
                    if (deu.Wort.Equals(deutsch.Wort, StringComparison.InvariantCultureIgnoreCase)) //if (deu.Wort == deutsch.Wort)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            { return false; }
        }

        /// <summary>
        /// Sucht ob einen Rekord gibt in den Englisch Tabelle
        /// </summary>
        /// <param name="englisch"></param>
        /// <returns></returns>
        public bool pruefenEnglischList(Englisch englisch)
        {
            BindingList<Englisch> list = GetAllEnglischeWoerter();

            if (englisch != null)
            {
                foreach (Englisch eng in list)
                {
                    if (eng.Word.Equals(englisch.Word, StringComparison.InvariantCultureIgnoreCase)) //if (eng.Word == englisch.Word)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            { return false; }
        }

        /// <summary>
        /// Sucht für eine Aufzeichnung mit deutsch element, und zurücklierfert den Rekord
        /// </summary>
        /// <param name="deutsch"></param>
        /// <returns></returns>
        public Deutsch suchenDeutschRekord(Deutsch deutsch)
        {
            BindingList<Deutsch> list = GetAllDeutscheWoerter();

            if (deutsch != null)
            {
                foreach (Deutsch deu in list)
                {
                    if (deu.Wort.Equals(deutsch.Wort, StringComparison.InvariantCultureIgnoreCase)) //if (deu.Wort == deutsch.Wort)
                    {
                        return deu;
                    }
                }
                return null;
            }
            else
            { return null; }
        }

        /// <summary>
        /// Sucht für eine Aufzeichnung mit english element, und zurückliefert den Rekord
        /// </summary>
        /// <param name="englisch"></param>
        /// <returns></returns>
        public Englisch suchenEnglischRekord(Englisch englisch)
        {
            BindingList<Englisch> list = GetAllEnglischeWoerter();

            if (englisch != null)
            {
                foreach (Englisch eng in list)
                {
                    if (eng.Word.Equals(englisch.Word, StringComparison.InvariantCultureIgnoreCase)) // if (eng.Word == englisch.Word)
                    {
                        return eng;
                    }
                }
                return null;
            }
            else
            { return null; }
        }

        /// <summary>
        /// Sucht ob einen Rekord ist schon im Deutsch_Englisch Tabelle
        /// </summary>
        /// <param name="deutsch"></param>
        /// <param name="englisch"></param>
        /// <returns></returns>
        public bool pruefenKreuzList(Deutsch deutsch, Englisch englisch)
        {
            /*
            if (deutsch.Uebersetzungen.Contains(englisch))
            {
                return true;
            }
            if (englisch.Uebersetzungen.Contains(deutsch))
            {
                return true;
            }
            */
            using (OleDbConnection conn = new OleDbConnection(_connString))
            {
                using (OleDbCommand command = new OleDbCommand("SELECT COUNT (*) FROM Deutsch_Englisch WHERE DeutschUUID LIKE @dUUID AND EnglischUUID LIKE @eUUID", conn))
                {
                    command.Parameters.AddWithValue("@dUUID", deutsch.GUID);
                    command.Parameters.AddWithValue("@eUUID", englisch.GUID);
                    conn.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count >= 1)
                    {
                        return true;
                    }
                    conn.Close();
                }
            }



            return false;
        }

#endregion


        /// <summary>
        /// Diese Methode findet Wörter, die mit bestimmte Bücherstaber anfängt
        /// Es gibt zurück eine string List
        /// </summary>
        /// <param name="substring"></param>
        /// <returns></returns>
        public List<string> findMatchesKreuzTabl(string substring)
        {
            List<string> searchResults = new List<string>();

            using (OleDbConnection conn = new OleDbConnection(_connString))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand("Select Wort FROM Deutsch WHERE Wort LIKE @string +'%' ORDER BY Wort", conn);
                command.Parameters.AddWithValue("@string", substring);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    searchResults.Add(reader[0].ToString());
                }
                conn.Close();
            }

            return searchResults;
        }
    }
}
