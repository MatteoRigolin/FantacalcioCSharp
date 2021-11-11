//Author: Matteo Rigolin
//Data: 29/10/2021
//Progettare un sistema di gestione del fantacalcio in modalità Console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantacalcio
{
    class Giocatore //Classe che rappresenta i giocatori che participano al fantacalcio
    {
        public string nome { get; set; } //nome del giocatore
        int fantamilioni;
        public string nomeSquadra { get; set; } //nome della sua squadra
        public List<Calciatore> formazione { get; set; } //formazione di 11 calciatori che possiede 
        public int puntiSquadra { get; set; }//somma dei voti dei calciatori con bonus e malus della squadra 
        public int golSquadra { get; set; }//gol segnati durante le partite, ottenuti convertendo i puntiSquadra
        public int punteggio { get; set; }//punteggio complessivo del giocatore, +3 per ogni vittoria e +1 per ogni pareggio, +0 per sconfitta
        public Giocatore(string nome, int fantamilioni, string nomeSquadra, List<Calciatore> formazione, int puntiSquadra, int golSquadra, int punteggio)//costruttore della classe giocatore
        {
            this.nome = nome;
            this.fantamilioni = fantamilioni;
            this.nomeSquadra = nomeSquadra;
            this.formazione = formazione;
            this.puntiSquadra = puntiSquadra;
            this.golSquadra = golSquadra;
            this.punteggio = punteggio;
        }
    }
    class Calciatore //classe che rappresenta i calciatori in gioco
    {
        public string nome { get; set; } //nome e cognome del calciatore
        public string ruolo { get; set; } //ruolo in squadra
        public string squadra { get; set; } //squadra di appartenenza
        public int prezzo { get; set; } //prezzo del calciatore nell'asta
        public int voto { get; set; } //voto del giocatore in gioco
        public Calciatore(string nome, string ruolo, string squadra, int prezzo, int voto)//costruttore della classe calciatore
        {
            this.nome = nome;
            this.ruolo = ruolo;
            this.squadra = squadra;
            this.prezzo = prezzo;
            this.voto = voto;
        }
    }
    class Program //classe principale del programma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel simulatore di fantacalcio"); //benvenuto all'utente nel gioco
            nuovoCampionato(); //richiamo la funzione per iniziare a giocare
            Console.ReadKey(); 
        }
        
        static void nuovoCampionato() //funzione che contiene lo svolgimento del gioco
        {
            List<Giocatore> giocatori = new List<Giocatore>(); //lista di giocatori che partecipano
            List<Calciatore> formazione = new List<Calciatore>(); //lista di 11 calciatori posseduti da ogni giocatore
            creaGiocatori(giocatori, formazione); //passo le liste tramite la funzione per creare i giocatori partecipanti
            foreach (Giocatore g in giocatori) //ripeto per ogni giocatore in lista
            {
                int i = 0;
                int[] voti = new int[11];//array con i voti di tutti i calciatori in formazione
                int puntiSq = 0; //punti squadra
                bool controllo;
                //malus e bonus
                int golSegnati;
                int golSubiti;
                int autogol;
                int assist;
                int rigoriParati;
                int rigoriSegnati;
                int rigoriSubiti;
                int cartelliniRossi;
                int cartelliniGialli;
                int portiereImbattuto;
                //gol segnati in partita dalla squadra
                int golSq;

                foreach (Calciatore c in formazione) //ripeto per ogni calciatore nella formazione
                {
                    voti[i] = c.voto; //assegno il voto al giocatore
                    i++; //aumento per passare al calciatore successivo
                }
                for (int j = 0; j < voti.Length; j++) //ripeto per il numero di voti
                {
                    puntiSq += voti[j]; //sommo i voti dei calciatori in formazione
                }
                Console.WriteLine($"Punti della squadra {g.nomeSquadra} : {puntiSq}");
                Console.WriteLine("Aggiunta Bonus e Malus della squadra");
                //cicli per assegnare bonus e malus
                do
                {
                    Console.WriteLine($"Inserisci i gol segnati della squadra {g.nomeSquadra}: "); 
                    string a = Convert.ToString(Console.ReadLine()); //l'utente inserisce il numero
                    controllo = int.TryParse(a, out golSegnati); //tento la conversione da stringa a intero e passo il valore alla variabile
                } while (!controllo || golSegnati < 0); //ripeto se la conversione fallisce o se il numero è 0 o è negativo
                do
                {
                    Console.WriteLine($"Inserisci i gol subiti della squadra {g.nomeSquadra}: ");
                    string a = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(a, out golSubiti);
                } while (!controllo || golSubiti < 0);
                do
                {
                    Console.WriteLine($"Inserisci gli autogol della squadra {g.nomeSquadra}: ");
                    string a = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(a, out autogol);
                } while (!controllo || autogol < 0);
                do
                {
                    Console.WriteLine($"Inserisci gli assist della squadra {g.nomeSquadra}: ");
                    string a = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(a, out assist);
                } while (!controllo || assist < 0);
                do
                {
                    Console.WriteLine($"Inserisci i rigori parati della squadra {g.nomeSquadra}: ");
                    string a = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(a, out rigoriParati);
                } while (!controllo || rigoriParati < 0);
                do
                {
                    Console.WriteLine($"Inserisci i rigori segnati della squadra {g.nomeSquadra}: ");
                    string a = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(a, out rigoriSegnati);
                } while (!controllo || rigoriSegnati < 0);
                do
                {
                    Console.WriteLine($"Inserisci i rigori subiti della squadra {g.nomeSquadra}: ");
                    string a = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(a, out rigoriSubiti);
                } while (!controllo || rigoriSubiti < 0);
                do
                {
                    Console.WriteLine($"Inserisci i cartellini rossi della squadra {g.nomeSquadra}: ");
                    string a = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(a, out cartelliniRossi);
                } while (!controllo || cartelliniRossi < 0);
                do
                {
                    Console.WriteLine($"Inserisci i cartellini gialli della squadra {g.nomeSquadra}: ");
                    string a = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(a, out cartelliniGialli);
                } while (!controllo || cartelliniGialli < 0);
                do
                {
                    Console.WriteLine($"Inserisci i portiere imbattuto della squadra {g.nomeSquadra}: ");
                    string a = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(a, out portiereImbattuto);
                } while (!controllo || portiereImbattuto < 0);
                //sommo ai punti della squadra i punti dei bonus e malus in base al loro peso per cui sono moltiplicati
                puntiSq = puntiSq + (golSegnati * 3) + assist + portiereImbattuto + (rigoriParati * 3) + (rigoriSegnati * 2) - golSubiti - cartelliniRossi - cartelliniGialli - (autogol * 2) - (rigoriSubiti * 3);
                g.puntiSquadra = puntiSq; //assegno il valore all'attributo
                Console.WriteLine($"I punti della squadra {g.nomeSquadra} sono {g.puntiSquadra}");
                if (puntiSq < 66) //se i punti sono minori di 66 i gol della squadra sono 0
                {
                    golSq = 0;
                    g.golSquadra = golSq;
                }
                else if (puntiSq == 66) //se sono uguali a 66 i gol sono pari a 1
                {
                    golSq = 1;
                    g.golSquadra = golSq;
                }
                else if (puntiSq > 66)// se sono maggiori di 66 assegno un gol + 1 per ogni 6 punti aggiuntivi rispetto al 66
                {
                    golSq = 1;
                    do
                    {
                        puntiSq -= 6;
                        golSq++;
                    } while (puntiSq > 66);
                    g.golSquadra = golSq;
                }
                Console.WriteLine($"I gol segnati della squadra {g.nomeSquadra} sono {g.golSquadra}");              
            }         
            string risposta = "1"; //valore che ripete il do while finchè l'utente inserisce 1, deve partire almeno una volta quindi è inizializzato a 1
            do //ciclo per svolgere più tornei se l'utente inserisce 1
            {
                int[] numeriSfidanti = creaGironi(giocatori.Count); //array che contiene i numeri dei giocatoriche giocheranno nei gironi
                int numGironi = 0; //numero che conta quanti gironi sono stati fatti, inizializzato a 0
                for (int b = 0; b < giocatori.Count; b += 2) //ogni volta che il ciclo si ripete faccio sfidare due giocatori in partita in base ai numeri in array
                {
                    numGironi++;
                    Console.WriteLine($"Girone {numGironi}");
                    Console.WriteLine($"Giocheranno {giocatori[numeriSfidanti[b]].nomeSquadra} contro {giocatori[numeriSfidanti[b + 1]].nomeSquadra}");            
                    if (giocatori[numeriSfidanti[b]].golSquadra > giocatori[numeriSfidanti[b + 1]].golSquadra)//se il primo giocatore ha più gol vince e guadagna 3 punti
                    {
                        Console.WriteLine($"Vince la squadra {giocatori[numeriSfidanti[b]].nomeSquadra}");//scrivo il vincitore
                        Console.WriteLine($"{giocatori[numeriSfidanti[b]].nomeSquadra} guadagna 3 punti");
                        giocatori[numeriSfidanti[b]].punteggio += 3;
                    }
                    else if (giocatori[numeriSfidanti[b]].golSquadra < giocatori[numeriSfidanti[b + 1]].golSquadra)//se primo giocatore ha meno gol del secondo perde, il secondo guadagna 3 punti
                    {
                        Console.WriteLine($"Vince la squadra {giocatori[numeriSfidanti[b + 1]].nomeSquadra}");//scrivo il vincitore
                        Console.WriteLine($"{giocatori[numeriSfidanti[b + 1]].nomeSquadra} guadagna 3 punti");
                        giocatori[numeriSfidanti[b + 1]].golSquadra += 3;
                    }
                    else if (giocatori[numeriSfidanti[b]].golSquadra == giocatori[numeriSfidanti[b + 1]].golSquadra)//se i gol sono pari allora è un pareggio ed entrabi prendono 1 punto
                    {
                        Console.WriteLine("Pareggio");
                        giocatori[numeriSfidanti[b]].punteggio += 1;
                        giocatori[numeriSfidanti[b + 1]].punteggio += 1;
                    }
                }
                Console.WriteLine("\nPremi 1 per fare dei nuovi gironi\nPremi 2 per finire il torneo");
                risposta = Console.ReadLine();
            } while (risposta == "1"); // se l'utente scrive 1 ripeto il ciclo      
            foreach(Giocatore g in giocatori) //ripeto per ogni giocatore
            {
                Console.WriteLine($"\nIl punteggio di {g.nome} è {g.punteggio}"); //scrivo i punteggi finali di tutti i giocatori       
            }
            giocatori = giocatori.OrderBy(x => x.punteggio).ToList(); //ordino i giocatori in base ai punteggi in ordine decrescente
            Giocatore vincitore = giocatori.First(); //il vincitore è il primo in lista, cioè chi ha più punti
            Console.WriteLine($"\nIl vincitore del torneo è {vincitore.nome} con {vincitore.punteggio}"); //scrivo il vincitore
        }  
        //funzione che crea giocatori
        public static List<Giocatore> creaGiocatori(List<Giocatore> giocatori, List<Calciatore> formazione)
        {         
            int numeroGiocatori;
            string nomeGiocatore;
            string nomeSquadra;
            int creditiGiocatore = 500; 
            //faccio inserire all'utente il numero di giocatori
            Console.WriteLine("Inserisci un numero di giocatori compreso tra 2 e 8 inclusi: ");
            Console.WriteLine("Inserisci il numero di giocatori: ");
            while (!Int32.TryParse(Console.ReadLine(), out numeroGiocatori) || numeroGiocatori < 2 || numeroGiocatori > 8) //controllo che il numero di giocatori sià compreso fra 2 e 8
            {
                Console.Write("Puoi inserire solo un numero compreso fra 2 e 8 inclusi, riprova:  ");
            }
            for (int i = 0; i < numeroGiocatori; i++) //ripero in base al numero di giocatori da creare
            {
                //faccio inserire il nome del giocatore e della sua squadra
                Console.WriteLine($"Inserisci il nome del giocatore {i + 1}");
                nomeGiocatore = Console.ReadLine();
                Console.WriteLine($"Inserisci il nome della squadra del giocatore {i + 1}");
                nomeSquadra = Console.ReadLine();
                creaFormazione(formazione, nomeSquadra, creditiGiocatore);//passo i valori alla funzione per creare la formazione
                giocatori.Add(new Giocatore(nomeGiocatore, creditiGiocatore, nomeSquadra, formazione, 0, 0, 0)); //aggiungo in lista un nuovo giocatore
            }
            return giocatori; //ritorno la lista
        }
        //funzione per creare la formazione
        public static List<Calciatore> creaFormazione(List<Calciatore> formazione, string nomeSquadra, int creditiGiocatore)
        {
            //dati dei calciatori
            string ruoloCalciatore;
            string nomeCalciatore;
            int prezzoCalciatore;
            int votoCalciatore;
            bool controllo;
            //mostro i crediti
            Console.WriteLine($"Crediti posseduti: {creditiGiocatore}");
            for (int j = 0; j < 1; j++) //creo un portiere
            {
                ruoloCalciatore = "portiere";
                do
                {
                    Console.WriteLine($"Inserisci il nome del {j + 1}° portiere della squadra {nomeSquadra}\n");
                    nomeCalciatore = Convert.ToString(Console.ReadLine()); // l'utente inserisce il nome
                } while (nomeCalciatore == ""); // controllo se il nome è vuoto
                do
                {
                    Console.WriteLine($"Inserisci il voto del {j + 1}° portiere della squadra {nomeSquadra}\n");
                    string voto = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(voto, out votoCalciatore); //l'utente inserisce il voto del calciatore che viene convertito in int
                } while (!controllo || votoCalciatore < 0 || votoCalciatore > 12); //controllo se il voto è valido
                do
                {
                    Console.WriteLine($"Inserisci il prezzo d'acquisto di {nomeCalciatore} della squadra {nomeSquadra}\n");
                    string prezzo = Convert.ToString(Console.ReadLine()); 
                    controllo = int.TryParse(prezzo, out prezzoCalciatore); //l'utente inserisce il prezzo che viene convertito in int
                } while (!controllo || prezzoCalciatore < 1 || prezzoCalciatore > 45); // controllo se il prezzo è un numero double maggiore di 0 e minore di 46
                creditiGiocatore = creditiGiocatore - prezzoCalciatore; //sottraggo il prezzo del calciatore ai crediti
                Console.WriteLine($"Crediti rimanenti: {creditiGiocatore}");
                formazione.Add(new Calciatore(nomeCalciatore, ruoloCalciatore, nomeSquadra, prezzoCalciatore, votoCalciatore)); //aggiungo il calciatore in formazione
            }
            for (int j = 0; j < 3; j++)//creo 3 difensori
            {
                ruoloCalciatore = "difensore";
                do
                {
                    Console.WriteLine($"Inserisci il nome del {j + 1}° difensore della squadra {nomeSquadra}\n");
                    nomeCalciatore = Convert.ToString(Console.ReadLine()); 
                } while (nomeCalciatore == ""); 
                do
                {
                    Console.WriteLine($"Inserisci il voto del {j + 1}° difensore della squadra {nomeSquadra}\n");
                    string voto = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(voto, out votoCalciatore);
                } while (!controllo || votoCalciatore < 0 || votoCalciatore > 12);
                do
                {
                    Console.WriteLine($"Inserisci il prezzo d'acquisto di {nomeCalciatore} della squadra {nomeSquadra}\n");
                    string prezzo = Convert.ToString(Console.ReadLine()); 
                    controllo = int.TryParse(prezzo, out prezzoCalciatore);
                } while (!controllo || prezzoCalciatore < 1 || prezzoCalciatore > 45); 
                creditiGiocatore = creditiGiocatore - prezzoCalciatore;
                Console.WriteLine($"Crediti rimanenti: {creditiGiocatore}");
                formazione.Add(new Calciatore(nomeCalciatore, ruoloCalciatore, nomeSquadra, prezzoCalciatore, votoCalciatore));
            }
            for (int j = 0; j < 4; j++)//creo 4 centrocampisti
            {
                ruoloCalciatore = "centrocampista";
                do
                {
                    Console.WriteLine($"Inserisci il nome del {j + 1}° centrocampista della squadra {nomeSquadra}\n");
                    nomeCalciatore = Convert.ToString(Console.ReadLine()); 
                } while (nomeCalciatore == ""); 
                do
                {
                    Console.WriteLine($"Inserisci il voto del {j + 1}° centrocampista della squadra {nomeSquadra}\n");
                    string voto = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(voto, out votoCalciatore);
                } while (!controllo || votoCalciatore < 0 || votoCalciatore > 12);
                do
                {
                    Console.WriteLine($"Inserisci il prezzo d'acquisto di {nomeCalciatore} della squadra {nomeSquadra}\n");
                    string prezzo = Convert.ToString(Console.ReadLine()); 
                    controllo = int.TryParse(prezzo, out prezzoCalciatore); ;
                } while (!controllo || prezzoCalciatore < 1 || prezzoCalciatore > 45); 
                creditiGiocatore = creditiGiocatore - prezzoCalciatore;
                Console.WriteLine($"Crediti rimanenti: {creditiGiocatore}");
                formazione.Add(new Calciatore(nomeCalciatore, ruoloCalciatore, nomeSquadra, prezzoCalciatore, votoCalciatore));
            }
            for (int j = 0; j < 3; j++)//creo 3 attaccanti
            {
                ruoloCalciatore = "attaccante";
                do
                {
                    Console.WriteLine($"Inserisci il nome del {j + 1}° attaccante della squadra {nomeSquadra}\n");
                    nomeCalciatore = Convert.ToString(Console.ReadLine()); 
                } while (nomeCalciatore == ""); 
                do
                {
                    Console.WriteLine($"Inserisci il voto del {j + 1}° attaccante della squadra {nomeSquadra}\n");
                    string voto = Convert.ToString(Console.ReadLine());
                    controllo = int.TryParse(voto, out votoCalciatore);
                } while (!controllo || votoCalciatore < 0 || votoCalciatore > 12);
                do
                {
                    Console.WriteLine($"Inserisci il prezzo d'acquisto di {nomeCalciatore} della squadra {nomeSquadra}\n");
                    string prezzo = Convert.ToString(Console.ReadLine()); 
                    controllo = int.TryParse(prezzo, out prezzoCalciatore);
                } while (!controllo || prezzoCalciatore < 1 || prezzoCalciatore > 45); 
                creditiGiocatore = creditiGiocatore - prezzoCalciatore;
                Console.WriteLine($"Crediti rimanenti: {creditiGiocatore}");
                formazione.Add(new Calciatore(nomeCalciatore, ruoloCalciatore, nomeSquadra, prezzoCalciatore, votoCalciatore));
            }
            return formazione; //ritorno la formazione del giocatore
        }
        //funzione che crea i gironi del torneo
        public static int[] creaGironi(int numeroGiocatori)
        {           
            Random random = new Random();//istanza della classe Random
            int numGen = 0;//numero generato del random
            int[] ordineGiocatori = new int[numeroGiocatori];//array che contiene gli indici dei giocatori generati per decidere gli scontri
            bool controllo = false;//controllo per i doppioni
            for (int i = 0; i < ordineGiocatori.Length; i++)//ripeto per il numero di squadre in gioco
            {
                numGen = random.Next(0, numeroGiocatori);//genero un numero random tra 0 e il numero di giocatori
                if (i >= 1)//controllo per il primo numero
                {
                    for (int j = 0; j < i; j++)//ripeto il ciclo per controllare i doppioni in tutti i numeri generati
                    {
                        if (ordineGiocatori[j] == numGen)//controllo se il numero generato è doppio
                        {
                            controllo = true;//il controllo diventa true
                        }
                    }
                }
                else//se è il primo non devo controllare i doppioni
                {
                    ordineGiocatori[i] = numGen;
                }
                if (controllo)//se genera un doppione si ripete il ciclo diminuendo la i
                {
                    i--;
                    controllo = false;
                }
                else//se il numero generato non è doppio lo salvo nell'array
                {
                    ordineGiocatori[i] = numGen;
                }
            }
            return ordineGiocatori;//ritorno l'array con i gironi pronti
        }
    }
}
