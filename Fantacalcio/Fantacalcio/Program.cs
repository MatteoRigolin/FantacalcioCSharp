using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantacalcio
{
    class Fantacalcio
    {
        protected void aggiungiGiocatori()
        {

        }
        protected void asta()
        {

        }
        protected void creaGironi()
        {

        }
        protected void partita()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel simulatore di fantacalcio");
            int numeroGiocatori;
            
            Console.WriteLine("Scegli il numero di giocatori:\n ");
            Console.WriteLine("Premi 2 per la modalità a 2 giocatori");
        }
    }
    class Giocatore
    {
        string nome;
        List<Calciatore> rosa;
        List<Calciatore> formazione;
        int puntiSquadra;
        int punteggio;
        public Giocatore()
        {
            
        }
        protected string setNomeGiocatore()
        {
            return nome;
        }
        protected void setRosa()
        {

        }
        protected void setFormazione()
        {

        }
        protected int setBonus()
        {
            return puntiSquadra;
        }
        protected int setMalus()
        {
            return puntiSquadra;
        }
        protected int setPunteggioGiocatore()
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
        public Calciatore()
        {

        }
        protected int setVotoGiocatore()
        {
            return voto;
        }
    }
}
