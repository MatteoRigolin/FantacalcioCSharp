using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Fantacalcio
{
    class Fantacalcio
    {
        List<Giocatore> giocatori = new List<Giocatore>();
        public Fantacalcio(List<Giocatore> giocatori)
        {
            this.giocatori = giocatori;
        }
        public List<Giocatore> creaGiocatori(List<Giocatore> giocatori, List<Calciatore> calciatori)
        {
            int numeroGiocatori;
            string nomeGiocatore;
            string nomeSquadra;
            string ruoloCalciatore;
            string nomeCalciatore;
            int prezzoCalciatore;
            int votoCalciatore;
            bool controllo;

            Console.WriteLine("Inserisci un numero di giocatori compreso tra 2 e 8 inclusi: ");
            Console.WriteLine("Inserisci il numero di giocatori:\n ");
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
                for (int j = 0; j < 3; j++) 
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

                    } while (!controllo || prezzoCalciatore < 1); // Viene chiesto il prezzo finchè esso non è non è un numero double maggiore di 0
                    calciatori.Add(new Calciatore(nomeCalciatore, ruoloCalciatore, nomeSquadra, prezzoCalciatore, votoCalciatore));
                }
                for (int j = 0; j < 8; j++)
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

                    } while (!controllo || prezzoCalciatore < 1); // Viene chiesto il prezzo finchè esso non è non è un numero double maggiore di 0
                    calciatori.Add(new Calciatore(nomeCalciatore, ruoloCalciatore, nomeSquadra, prezzoCalciatore, votoCalciatore));
                }
                for (int j = 0; j < 8; j++)
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
                        controllo = int.TryParse(prezzo, out prezzoCalciatore);

                    } while (!controllo || prezzoCalciatore < 1); // Viene chiesto il prezzo finchè esso non è non è un numero double maggiore di 0
                    calciatori.Add(new Calciatore(nomeCalciatore, ruoloCalciatore, nomeSquadra, prezzoCalciatore, votoCalciatore));
                }
                for (int j = 0; j < 6; j++)
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

                    } while (!controllo || prezzoCalciatore < 1); // Viene chiesto il prezzo finchè esso non è non è un numero double maggiore di 0
                    calciatori.Add(new Calciatore(nomeCalciatore, ruoloCalciatore, nomeSquadra, prezzoCalciatore, votoCalciatore));
                }
                //fileSq.WriteLine($"Nome: {nomeCalciatore}, Prezzo d'acquisto: {prezzoCalciatore}"); // Viene scritto nel file della singola squadra il nome del giocatore con il relativo prezzo

                giocatori.Add(new Giocatore(nomeGiocatore, 500, nomeSquadra, 0, 0));
            }
            return giocatori;
        }
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
        string nomeSquadra;
        List<Calciatore> rosa;
        List<Calciatore> formazione;
        int puntiSquadra;
        int punteggio;
        public Giocatore(string nome, int fantamilioni, string nomeSquadra, int puntiSquadra, int punteggio)
        {
            this.nome = nome;
            this.fantamilioni = fantamilioni;
            this.nomeSquadra = nomeSquadra;
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
    class Programm
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
            List<Giocatore> giocatori = new List<Giocatore>();
            List<Calciatore> calciatori = new List<Calciatore>();
            Fantacalcio fantacalcio = new Fantacalcio(giocatori);
            fantacalcio.creaGiocatori(giocatori, calciatori);
            fantacalcio.asta();
        }
        
        static void caricaCampionato()
        {

        }
    }
}
