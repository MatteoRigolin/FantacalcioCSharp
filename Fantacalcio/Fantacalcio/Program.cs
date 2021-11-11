using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fantacalcio
{
    
    class Giocatore
    {
        string nome;
        int fantamilioni;
        string nomeSquadra;
        List<Calciatore> formazione;
        int puntiSquadra;
        int punteggio;
        public Giocatore(string nome, int fantamilioni, string nomeSquadra, List<Calciatore> formazione, int puntiSquadra, int punteggio)
        {
            this.nome = nome;
            this.fantamilioni = fantamilioni;
            this.nomeSquadra = nomeSquadra;
            this.formazione = formazione;
            this.puntiSquadra = puntiSquadra;
            this.punteggio = punteggio;
        }
        public string setNomeGiocatore()
        {
            return nome;
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
        public int setVotoCalciatore()
        {
            return voto;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            menù();
            Console.ReadKey();
        }
        static void menù()
        {

            Console.WriteLine("Benvenuto nel simulatore di fantacalcio");
            Console.WriteLine("Menù\n");
            Console.WriteLine("Inserisci 1 per iniziare un nuovo campionato\n");
            Console.WriteLine("Inserisci 2 per continuare un campionato esistente\n");
            Console.WriteLine("Inserisci 3 per uscire dal programma\n");
            string numeroMenù = Console.ReadLine(); //assunzione valore da tastiera
            while (numeroMenù != "1" && numeroMenù != "2" && numeroMenù != "3")
            {
                Console.Write("Il valore inserito non è valido, reinserire il valore: ");
                numeroMenù = Console.ReadLine();
            }
            //selezione menù
            switch (numeroMenù)
            {
                case "1": nuovoCampionato(); break;
                case "2": caricaCampionato(); break;
                case "3": Environment.Exit(1); break;
            }

        }
        static void nuovoCampionato()
        {
            List<Giocatore> giocatori = creaGiocatori();
            foreach(Giocatore giocatore in giocatori)
            {
                
            }
        }

        static void caricaCampionato()
        {
            
        }
        public static List<Giocatore> creaGiocatori()
        {
            List<Giocatore> giocatori = new List<Giocatore>();
            List<Calciatore> formazione = new List<Calciatore>();
            int numeroGiocatori;
            string nomeGiocatore;
            string nomeSquadra;
            int creditiGiocatore = 500;

            Console.WriteLine("Inserisci un numero di giocatori compreso tra 2 e 8 inclusi: ");
            Console.WriteLine("Inserisci il numero di giocatori: ");
            while (!Int32.TryParse(Console.ReadLine(), out numeroGiocatori) || numeroGiocatori < 2 || numeroGiocatori > 8)
            {
                Console.Write("Puoi inserire solo un numero compreso fra 2 e 8 inclusi, riprova:  ");
            }
            for (int i = 0; i < numeroGiocatori; i++)
            {
                Console.WriteLine($"Inserisci il nome del giocatore {i + 1}");
                nomeGiocatore = Console.ReadLine();
                Console.WriteLine($"Inserisci il nome della squadra del giocatore {i + 1}");
                nomeSquadra = Console.ReadLine();
                creaFormazione(formazione, nomeSquadra, creditiGiocatore);
                //fileSq.WriteLine($"Nome: {nomeCalciatore}, Prezzo d'acquisto: {prezzoCalciatore}"); // Viene scritto nel file della singola squadra il nome del giocatore con il relativo prezzo

                giocatori.Add(new Giocatore(nomeGiocatore, creditiGiocatore, nomeSquadra, formazione, 0, 0));
            }
            return giocatori;
        }
        public static List<Calciatore> creaFormazione(List<Calciatore> formazione, string nomeSquadra, int creditiGiocatore)
        {
            string ruoloCalciatore;
            string nomeCalciatore;
            int prezzoCalciatore;
            int votoCalciatore;
            bool controllo;

            Console.WriteLine($"Crediti posseduti: {creditiGiocatore}");
            for (int j = 0; j < 1; j++)
            {
                ruoloCalciatore = "portiere";
                do
                {
                    Console.WriteLine($"Inserisci il nome del {j + 1}° portiere della squadra {nomeSquadra}\n");
                    nomeCalciatore = Convert.ToString(Console.ReadLine()); // Vengono letti i nomi dei giocatori
                } while (nomeCalciatore == ""); // Viene chiesto di inserire il nome del calciatore finchè esso non è vuoto
                do
                {
                    Console.WriteLine($"Inserisci il voto del {j + 1}° portiere della squadra {nomeSquadra}\n");
                    string voto = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(voto, out votoCalciatore);
                } while (!controllo || votoCalciatore < 0 || votoCalciatore > 12);
                do
                {
                    Console.WriteLine($"Inserisci il prezzo d'acquisto di {nomeCalciatore} della squadra {nomeSquadra}\n");
                    string prezzo = Convert.ToString(Console.ReadLine()); // Viene letto il prezzo d'acquisto dei giocatori
                    controllo = int.TryParse(prezzo, out prezzoCalciatore);
                } while (!controllo || prezzoCalciatore < 1 || prezzoCalciatore > 45); // Viene chiesto il prezzo finchè esso non è non è un numero double maggiore di 0
                creditiGiocatore = creditiGiocatore - prezzoCalciatore;
                Console.WriteLine($"Crediti rimanenti: {creditiGiocatore}");
                formazione.Add(new Calciatore(nomeCalciatore, ruoloCalciatore, nomeSquadra, prezzoCalciatore, votoCalciatore));
            }
            for (int j = 0; j < 3; j++)
            {
                ruoloCalciatore = "difensore";
                do
                {
                    Console.WriteLine($"Inserisci il nome del {j + 1}° difensore della squadra {nomeSquadra}\n");
                    nomeCalciatore = Convert.ToString(Console.ReadLine()); // Vengono letti i nomi dei giocatori
                } while (nomeCalciatore == ""); // Viene chiesto di inserire il nome del calciatore finchè esso non è vuoto
                do
                {
                    Console.WriteLine($"Inserisci il voto del {j + 1}° difensore della squadra {nomeSquadra}\n");
                    string voto = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(voto, out votoCalciatore);
                } while (!controllo || votoCalciatore < 0 || votoCalciatore > 12);
                do
                {
                    Console.WriteLine($"Inserisci il prezzo d'acquisto di {nomeCalciatore} della squadra {nomeSquadra}\n");
                    string prezzo = Convert.ToString(Console.ReadLine()); // Viene letto il prezzo d'acquisto dei giocatori
                    controllo = int.TryParse(prezzo, out prezzoCalciatore);
                } while (!controllo || prezzoCalciatore < 1 || prezzoCalciatore > 45); // Viene chiesto il prezzo finchè esso non è non è un numero double maggiore di 0
                creditiGiocatore = creditiGiocatore - prezzoCalciatore;
                Console.WriteLine($"Crediti rimanenti: {creditiGiocatore}");
                formazione.Add(new Calciatore(nomeCalciatore, ruoloCalciatore, nomeSquadra, prezzoCalciatore, votoCalciatore));
            }
            for (int j = 0; j < 4; j++)
            {
                ruoloCalciatore = "centrocampista";
                do
                {
                    Console.WriteLine($"Inserisci il nome del {j + 1}° centrocampista della squadra {nomeSquadra}\n");
                    nomeCalciatore = Convert.ToString(Console.ReadLine()); // Vengono letti i nomi dei giocatori
                } while (nomeCalciatore == ""); // Viene chiesto di inserire il nome del calciatore finchè esso non è vuoto
                do
                {
                    Console.WriteLine($"Inserisci il voto del {j + 1}° centrocampista della squadra {nomeSquadra}\n");
                    string voto = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(voto, out votoCalciatore);
                } while (!controllo || votoCalciatore < 0 || votoCalciatore > 12);
                do
                {
                    Console.WriteLine($"Inserisci il prezzo d'acquisto di {nomeCalciatore} della squadra {nomeSquadra}\n");
                    string prezzo = Convert.ToString(Console.ReadLine()); // Viene letto il prezzo d'acquisto dei giocatori
                    controllo = int.TryParse(prezzo, out prezzoCalciatore); ;
                } while (!controllo || prezzoCalciatore < 1 || prezzoCalciatore > 45); // Viene chiesto il prezzo finchè esso non è non è un numero double maggiore di 0
                creditiGiocatore = creditiGiocatore - prezzoCalciatore;
                Console.WriteLine($"Crediti rimanenti: {creditiGiocatore}");
                formazione.Add(new Calciatore(nomeCalciatore, ruoloCalciatore, nomeSquadra, prezzoCalciatore, votoCalciatore));
            }
            for (int j = 0; j < 3; j++)
            {
                ruoloCalciatore = "attaccante";
                do
                {
                    Console.WriteLine($"Inserisci il nome del {j + 1}° attaccante della squadra {nomeSquadra}\n");
                    nomeCalciatore = Convert.ToString(Console.ReadLine()); // Vengono letti i nomi dei giocatori
                } while (nomeCalciatore == ""); // Viene chiesto di inserire il nome del calciatore finchè esso non è vuoto
                do
                {
                    Console.WriteLine($"Inserisci il voto del {j + 1}° attaccante della squadra {nomeSquadra}\n");
                    string voto = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(voto, out votoCalciatore);
                } while (!controllo || votoCalciatore < 0 || votoCalciatore > 12);
                do
                {
                    Console.WriteLine($"Inserisci il prezzo d'acquisto di {nomeCalciatore} della squadra {nomeSquadra}\n");
                    string prezzo = Convert.ToString(Console.ReadLine()); // Viene letto il prezzo d'acquisto dei giocatori
                    controllo = int.TryParse(prezzo, out prezzoCalciatore);
                } while (!controllo || prezzoCalciatore < 1 || prezzoCalciatore > 45); // Viene chiesto il prezzo finchè esso non è non è un numero double maggiore di 0
                creditiGiocatore = creditiGiocatore - prezzoCalciatore;
                Console.WriteLine($"Crediti rimanenti: {creditiGiocatore}");
                formazione.Add(new Calciatore(nomeCalciatore, ruoloCalciatore, nomeSquadra, prezzoCalciatore, votoCalciatore));
            }
            return formazione;
        }
        public static int setPuntiSquadre()
        {
            return ;
        }
        public static void creaGironi()
        {

        }
        public static void partita()
        {

        }
    }
}
