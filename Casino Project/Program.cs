// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

int token;
string reponse;
string miserdm; 
Random hsr = new Random();
int hasard = hsr.Next(1, 301);
Random mse = new Random();
int mise = mse.Next(1, 31);


Console.WriteLine("[Haut Parleur] Bienvenue au Casino MonteSIO \n");

bool wantsToPlay = true;

while (wantsToPlay) {
    Console.WriteLine("Bonjour utilisateur " + hasard + " Voulez vous jouer au jeu ?");
    reponse = Console.ReadLine();
    Console.Clear();

    if (reponse.ToLower() == "oui") {
        bool inBetLoop = true;

        while (inBetLoop) {
            Console.WriteLine("Notre système peut vous faire miser au hasard si vous le souhaitez.\n");
            Console.WriteLine("Accepter/Refuser");
            miserdm = Console.ReadLine();
            Console.Clear();

            if (miserdm.ToLower() == "accepter") {
                Console.WriteLine("Votre mise sera alors : " + mise + " jetons");
                inBetLoop = false; // on sort de la boucle
            } else if (miserdm.ToLower() == "refuser") {
                Console.WriteLine("Combien de jetons voulez-vous mettre en jeu?");
                token = int.Parse(Console.ReadLine());
                Console.WriteLine("Votre mise de " + token + " jeton(s) à été acceptée, nous allons procéder au jeu. (Cliquer pour continuer)");
                inBetLoop = false; // on sort de la boucle
                Console.ReadKey();
                Console.Clear();
                
                Console.WriteLine("Nous allons prendre un nombre au hasard et vous aurez 6 chances pour essayer de le deviner.\n");
                Console.WriteLine("C'est parti!");
                Console.Clear();
                Random rdmnb = new Random();
                int game = rdmnb.Next(1, 151); // La machine choisit un nombre entre 1 et 150

                int answergame = 0; // Réponse du joueur
                int chances = 6;    // Nombre de chances max

                Console.WriteLine("[Vous avez " + token + " jetons en jeu]");
                while (answergame != game && chances > 0) { // On joue tant que le joueur n’a pas trouvé ET qu'il reste des chances
                
                    Console.WriteLine("Vous avez  " + chances + " chances pour deviner le nombre (entre 1 et 150) :");
    
                    string input = Console.ReadLine(); // <- l’utilisateur tape sa réponse (string)
    
                    if (int.TryParse(input, out answergame)) {
                        if (answergame > 150 || answergame < 1)
                        {
                            Console.WriteLine("[MACHINE] Le nombre doit être entre 1 et 150 !\n");
                        }
                        else if (answergame < game)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("[MACHINE] Plus grand !\n");
                            Console.ResetColor();
                            chances--; // on enlève une chance
                        }
                        else if (answergame > game)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("[MACHINE] Plus petit !\n");
                            chances--; // on enlève une chance
                        }
                        else
                        {
                            Console.WriteLine("[MACHINE] Bravo, vous avez gagné !\n");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Votre mise de " + token + " jetons va être doublée.");
                            Console.WriteLine("En éspérant vous revoir très vite!\n");
                            Console.WriteLine("Vous avez maintenant " + token*2 + " Voulez-vous continer (remise de " + token*2 + " ou repartir avec votre récompense?\n");
                            Console.WriteLine("Continuer/Partir");

                            string continueornot; 
                            continueornot = Console.ReadLine(); 
                            if (continueornot == "Continuer") ; {
                                
                            }
                            if (continueornot=="Partir"); {
                                Console.WriteLine("\nAu plaisir de vous revoir");
                                Console.ReadKey();
                                return;
                            }
                            
                        


                        }
                    }
                    else
                    {
                        Console.WriteLine("[MACHINE] Veuillez entrer un nombre valide.\n");
                    }
                }

// Si on sort de la boucle et que le joueur n’a plus de chances
                if (answergame != game) {
                    Console.WriteLine("[MACHINE] Perdu ! Le nombre était : " + game);
                    Console.WriteLine("Votre mise de " + token + " à donc disparu. \n");
                    Console.WriteLine(token + " => " + 0);
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Repartir avec le ventre vide ou continuer? (Continuer/Partir)\n");
                    string continueornot;
                    continueornot = Console.ReadLine();
                    if (continueornot == "Continuer") {

                    }

                    if (continueornot == "Partir") {
                        Console.WriteLine("\nAu plaisir de vous revoir");
                        Console.ReadKey();
                        return;
                    }

            }
                
                
                    
                Console.ReadKey();
                Console.Clear();
                
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