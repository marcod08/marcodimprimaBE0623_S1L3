using System.Threading.Channels;

namespace S1L3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esercizio 3

            Console.WriteLine("Decidi la lunghezza dell'array");
            int lunghezzaArray = int.Parse(Console.ReadLine());
            int[] numArray = new int[lunghezzaArray];

            int somma = 0;
            double media;

            for (int i = 0; i < lunghezzaArray; i++) 
            {
                Console.WriteLine($"inserisci il numero {i +1}:");
                numArray[i] = int.Parse(Console.ReadLine());
                somma += numArray[i];
            }
            media = (double)somma / lunghezzaArray;

            Console.WriteLine($"La somma dei numeri è {somma} e la loro media è {media}");

            //esecizio 2

            /*
            Console.WriteLine("Inserisci quanti nomi vuoi inserire:");
            int numeroNomi = int.Parse(Console.ReadLine());
            string[] nomi = new string[numeroNomi];
            
            for (int i = 0; i < nomi.Length; i++) 
            {
                Console.WriteLine($"Inserisci il nome numero {i+1}:");
                nomi[i] = Console.ReadLine();
            }
            Console.WriteLine("Inserisci il nome da ricercare nella lista");
            string nome = Console.ReadLine();
            bool nomePresente = false;

            for (int i = 0;i < nomi.Length;i++) 
            {
                if(nome.ToLower() == nomi[i].ToLower())
                {
                    nomePresente= true;
                }
            }
            if (nomePresente) 
            {
                Console.WriteLine($"Il nome: {nome} è presente nella lista!");
            }
            else 
            {
                Console.WriteLine($"il nome non è presente nella lista!");
            }
            */

            // esercizio 1

            /*
            Console.WriteLine("Inserire un nome per l'apertura del conto corrente");
            string nome = Console.ReadLine();

            Console.WriteLine("Per l'apertura del conto è obbligatorio un versamento iniziale di almeno 1000 euro");
            int saldoIniziale = int.Parse(Console.ReadLine());

            ContoCorrente mioConto = new ContoCorrente(nome, saldoIniziale);
            Console.WriteLine($"Nome Account: {mioConto.Nome} Saldo attuale: {mioConto.Saldo} euro");

            while (true)
            {
                Console.WriteLine("Seleziona una opzione:");
                Console.WriteLine("1 - Prelievo");
                Console.WriteLine("2 - Versamento");
                Console.WriteLine("3 - Esci");

                int scelta = int.Parse(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Inserisce l'importo da prelevare");
                        int importoPrelievo = int.Parse(Console.ReadLine());
                        mioConto.Prelievo(importoPrelievo);
                        break;
                    case 2:
                        Console.WriteLine("Inserisce l'importo per il versamento");
                        int importoVersamento = int.Parse(Console.ReadLine());
                        mioConto.Versamento(importoVersamento);
                        break;
                    case 3:
                        return;
                }
                Console.WriteLine($"Nome Account: {mioConto.Nome} Saldo attuale: {mioConto.Saldo} euro");
            }*/

        }


















        //esercizio 1
        /*
        public class ContoCorrente
        {
            string _nome;
            int _saldo;
            bool _contoAperto;

            public string Nome
            {
                get { return _nome; }
                set { _nome = value; }
            }

            public int Saldo
            { 
                get { return _saldo; }
                set { _saldo = value; }
            }

            public bool ContoAperto
            {
                get { return _contoAperto;}
                set { _contoAperto = value;}
            }

            public ContoCorrente(string nome, int saldoIniziale) 
            {
                _nome = nome;
                if (saldoIniziale >= 1000)
                {
                    _saldo = saldoIniziale;
                    _contoAperto= true;
                } else
                {
                    Console.WriteLine("Versamento iniziale insufficiente. Il conto non è stato aperto.");
                    _contoAperto = false;
                }
            }

            public void Versamento(int importo)
            {
                if (importo > 0)
                {
                    _saldo += importo;
                    Console.WriteLine("Importo versato correttamento");
                } else
                {
                    Console.WriteLine("L'importo non è sufficiente per effettuare un versamento");
                }
            }

            public void Prelievo(int importo)
            {
                if (importo < Saldo)
                {
                    _saldo -= importo;
                    Console.WriteLine("Importo prelevato correttamente");
                }
                else
                {
                    Console.WriteLine("L'importo supera il tuo saldo");
                }
            }
        } */
    }
}
