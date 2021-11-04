using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantacalcio
{
    class Fantacalcio
    {
        List<Giocatore> giocatori = new List<Giocatore>();
        public Fantacalcio(List<Giocatore> giocatori)
        {
            this.giocatori = giocatori;
        }
        //public List<Giocatore> setGiocatori()
        //{
            
        //    return giocatori;
        //}
        public void asta()
        {
            
        }
        public void creaGironi()
        {

        }
        public void partita()
        {

        }        
    }
    class Giocatore
    {
        string nome;
        int fantamilioni;
        List<Calciatore> rosa;
        List<Calciatore> formazione;
        int puntiSquadra;
        int punteggio;
        public Giocatore(string nome, int fantamilioni, int puntiSquadra, int punteggio)
        {
            this.nome = nome;
            this.fantamilioni = fantamilioni;
            this.puntiSquadra = puntiSquadra;
            this.punteggio = punteggio;
        }
        public string setNomeGiocatore()
        {
            nome = Console.ReadLine();
            return nome;
        }
        public void setRosa()
        {

        }
        public void setFormazione()
        {

        }
        public int setBonus()
        {
            return puntiSquadra;
        }
        public int setMalus()
        {
            return puntiSquadra;
        }
        public int setPunteggioGiocatore()
        {
            return punteggio;
        }
    }
    class Calciatore
    {
        string nome;
        string ruolo;
        string squadra;
        int prezzo;
        int voto;
        public Calciatore(string nome, string ruolo, string squadra, int prezzo, int voto)
        {
            this.nome = nome;
            this.ruolo = ruolo;
            this.squadra = squadra;
            this.prezzo = prezzo;
            this.voto = voto;
        }
        public int setVotoGiocatore()
        {
            return voto;
        }
    }
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel simulatore di fantacalcio");
            Console.WriteLine("Puoi scegliere tra tre modalità:\n2 giocatori\n4 giocatori\n8 giocatori");
            Console.WriteLine("Inserisci il numero di giocatori:\n ");
            int numeroGiocatori;
            numeroGiocatori = Convert.ToInt32(Console.ReadLine());
            while (numeroGiocatori == 2 || numeroGiocatori == 4 || numeroGiocatori == 8)
            {
                Console.WriteLine("Devi inserire solo 2, 4 o 8");
                numeroGiocatori = Convert.ToInt32(Console.ReadLine());
            }
            List<Giocatore> giocatori = new List<Giocatore>();
            Fantacalcio fantacalcio = new Fantacalcio(giocatori);
            for (int i = 0; i < numeroGiocatori; i++)
            {
                Console.WriteLine("Inserisci il nome del giocatore {0}", i + 1);
                giocatori.Add(new Giocatore("", 500, 0, 0));

            }
            Console.ReadKey();
        }
    }
}
