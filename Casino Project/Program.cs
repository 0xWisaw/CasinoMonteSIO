// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

int jetons;
string reponse;
string miserdm;
Random hsr = new Random();
int hasard = hsr.Next(1, 300);
Random mse = new Random();
int mise = mse.Next(1, 30);

Console.WriteLine("[Haut Parleur] Bienvenue au Casino MonteSIO \n");

bool wantsToPlay = true;

while (wantsToPlay) {
    Console.WriteLine("Bonjour utilisateur " + hasard + " Voulez vous jouer au jeu ?");
    reponse = Console.ReadLine();

    if (reponse.ToLower() == "oui") {
        bool inBetLoop = true;

        while (inBetLoop) {
            Console.WriteLine("Notre système peut vous faire miser au hasard si vous le souhaitez.\n");
            Console.WriteLine("Accepter/Refuser");
            miserdm = Console.ReadLine();

            if (miserdm.ToLower() == "accepter") {
                Console.WriteLine("Votre mise sera alors : " + mise);
                inBetLoop = false; // on sort de la boucle
            } else if (miserdm.ToLower() == "refuser") {
                Console.WriteLine("Combien de jetons voulez-vous mettre en jeu?");
                jetons = int.Parse(Console.ReadLine());
                Console.WriteLine("Votre mise de " + jetons + " jeton(s) à été acceptée, allez-vous doubler votre mise?");
                inBetLoop = false; // on sort de la boucle
            } else {
                Console.WriteLine("Nous n'avons pas compris votre réponse, merci de répondre par Accepter ou par Refuser");
                Console.Clear();
            }
        }

        wantsToPlay = false; // Comme ça quand il repart dans le while, c'est en faux et du coup ça stop le programme
    } else if (reponse.ToLower() == "non") {
        Console.WriteLine("Très bien, à la prochaine!");
        Console.ReadKey();
        return;
    } else {
        Console.WriteLine("Nous n'avons pas compris votre réponse veuillez réessayer\n");
        Console.WriteLine("Cliquer pour continuer.");
        Console.ReadKey();
        Console.Clear();
    }
}