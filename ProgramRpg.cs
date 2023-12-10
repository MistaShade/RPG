using System;
using System.Threading;

namespace JustYourAverageGrade9Fixer
{
    class Fight
    {
        static void Main(string[] args)
        {
            ShowTutorial();
            RunFight();
        }

        static void ShowTutorial()
        {
            Console.WriteLine("Welcome to the Battle Tutorial!");
            Console.WriteLine("In this game, you can choose to either ATTACK or DEFEND during your turn.");
            Console.WriteLine("During ATTACK, you will flip coins to increase your damage.");
            Console.WriteLine("During DEFEND, you will take reduced damage from the enemy's attack.");
            Console.WriteLine("Let's get started!");

            Console.WriteLine("\nTUTORIAL: ATTACK");
            Console.WriteLine("Press Enter to see the attack options...");
            Console.ReadLine();
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");

            string playerChoice1;
            do
            {
                Console.Write("To ATTACK, type 1 and press Enter: ");
                playerChoice1 = Console.ReadLine();
                if (playerChoice1 != "1")
                {
                    Console.WriteLine("Try Again!");
                }
            } while (playerChoice1 != "1");

            Console.WriteLine("\nTUTORIAL: DEFEND");
            Console.WriteLine("Press Enter to see the defend options...");
            Console.ReadLine();
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");

            string playerChoice2;
            do
            {
                Console.Write("To DEFEND, type 2 and press Enter: ");
                playerChoice2 = Console.ReadLine();
                if (playerChoice2 != "2")
                {
                    Console.WriteLine("Try again!");
                }
            } while (playerChoice2 != "2");

            SimulatePlayerInput(playerChoice2);

            Console.WriteLine("\nGreat job! Now you're ready for battle.");
            Console.WriteLine("Press Enter to start the fight!");
            Console.ReadLine();
        }

        static void RunFight()
        {
            int playerHealth = 150;
            int player2Health = 80;
            int enemyHealth = 90;
            int enemy2Health = 54;
            int enemy3Health = 60;
            int playerBaseDamage = 3;
            int player2BaseDamage = 3;
            int enemyBaseDamage = 2;
            int enemy2BaseDamage = 2;
            int enemy3BaseDamage = 3;
            int playerCoin = 3;
            int playerCoin2 = 3;
            int enemyCoin = 2;
            int enemyCoin2 = 2;
            int enemyCoin3 = 3;
            int firstCompanionHealth = 90;
            int firstCompanionBaseDamage = 10;
            int firstCompanionCoin = 3;
            int firstCompanionCoinPower = 3;
            int playerCoinPower = 2;
            int playerCoinPower2 = 2;
            int enemyCoinPower = 3;
            int enemyCoinPower2 = 2;
            int enemyCoinPower3 = 3;
            int NaimonCheck = 0;
            int PeteCheck = 0;
            int LennyCheck = 0;
            string enemyName;
            string enemyName2 = "";
            string enemyName3 = "";

            Console.WriteLine("What is your Name?");
            string playerName = Console.ReadLine();
            if (playerName == "Orlando" || playerName == "orlando" || playerName == "Roland" || playerName == "roland")
            {
                Console.WriteLine("My real name.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Welcome " + playerName + "!");
                Console.ReadLine();
            }

            while (playerHealth > 0 && NaimonCheck != 1)
            {
                enemyName = "Mang-Chi";
                Console.WriteLine(playerName + " Health: " + playerHealth + " | Enemy Health: " + enemyHealth);
                Console.WriteLine("Press Enter to choose your action!");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string playerAction = Console.ReadLine();

                switch (playerAction)
                {
                    case "1":
                        PerformAttack(playerName,ref playerHealth, ref playerBaseDamage, playerCoin, playerCoinPower, ref enemyHealth, ref enemyBaseDamage);
                        break;

                    case "2":
                        PerformDefend(playerName, ref playerBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;
                }

                if (playerName.Equals("Orland", StringComparison.OrdinalIgnoreCase) || playerName.Equals("Roland", StringComparison.OrdinalIgnoreCase))
                {
                    if (enemyHealth <= 0)
                    {
                        Console.WriteLine("Alright Alright, you've proven your point.");
                        Console.ReadLine();
                        Console.WriteLine("Just one more thing...");
                        Console.ReadLine();
                        Console.WriteLine("Dodge this!");
                        Console.ReadLine();
                        Console.WriteLine("*Naimon suddenly lunges at you*");
                        Console.ReadLine();
                        Console.WriteLine("Final Phase: Dodge Check.");

                        Console.WriteLine("Press Enter to Dodge!");
                        Console.ReadLine();

                        Random coinflip = new Random(); // Random Number Generator for coinflips
                        string[] coinflipresults = new string[playerCoin];
                        string resultString = "";

                        for (int i = 0; i < playerCoin; i++)
                        {
                            int rndcf = coinflip.Next(0, 2);
                            if (rndcf == 0)
                            {
                                playerBaseDamage += playerCoinPower;
                                coinflipresults[i] = "Heads";
                                Console.WriteLine(playerName + "'s Coin Power: " + "+" + playerCoinPower);
                            }
                            else if (rndcf == 1)
                            {
                                coinflipresults[i] = "Tails";
                                Console.WriteLine(playerName + "'s Coin Power: +0");
                            }
                        }

                        for (int i = 0; i < coinflipresults.Length; i++)
                        {
                            resultString += coinflipresults[i];
                            if (i < coinflipresults.Length - 1)
                            {
                                resultString += ", ";
                            }
                        }
                        Console.WriteLine("Check results for " + playerName + ": " + resultString + "|| Final Count: " + playerBaseDamage);

                        if (playerBaseDamage < 5)
                        {
                            Console.WriteLine("You failed to dodge Naimon's attack!");
                            Console.ReadLine();
                            Console.WriteLine("Naimon: 'You're not ready yet kid.'");
                            Console.ReadLine();
                            Console.WriteLine("Naimon: 'Come back when you're stronger.'");
                            Console.ReadLine();
                            Console.WriteLine("Naimon: 'I'll be waiting.'");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        else if (playerBaseDamage >= 5)
                        {
                            Console.WriteLine("You dodged Naimon's attack!");
                            Console.ReadLine();
                            Console.WriteLine("Naimon: 'You passed kid!'");
                            NaimonCheck = 1;
                        }
                    }

                    Console.ReadLine();
                }

                if (enemyHealth <= 0)
                {
                    Console.WriteLine(playerName + ": '*sigh* that was tough'");
                    Console.ReadLine();
                }
            }

            if (playerHealth <= 0)
            {
                Console.WriteLine("You have been defeated!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (NaimonCheck == 1)
            {
                Console.WriteLine("Naimon: 'Nyahaha! It's been a while since I've got these old bones moving.'");
                Console.ReadLine();
            }

            Console.ReadLine();
            Companion1 companion1 = new Companion1("Companion1");

            Console.WriteLine("You encountered a mysterious figure..");
            Console.ReadLine();
            Console.WriteLine("Stranger: Greetings, " + playerName + "...");
            Console.ReadLine();
            Console.WriteLine("Stranger: I've been watching how you fight...");
            Console.ReadLine();
            Console.WriteLine("Stranger: I wish to fight alongside you.");
            Console.ReadLine();
            Console.Write("You may call me: ");
            string companionName = Console.ReadLine();
            Console.WriteLine(companionName + ": Is that fine with you?");
            Console.ReadLine();
            Console.WriteLine("1. Accept " + companionName + "'s offer");
            Console.WriteLine("2. Decline " + companionName + "'s offer");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine(companionName + ": Wise choice, " + playerName + "!");
                Console.ReadLine();
                Console.WriteLine(companionName + ": Shoot! Enemies! Let me show you what I am made of " + playerName + "!");
                Console.ReadLine();
                Console.WriteLine("You accepted " + companionName + "'s offer. Your bonds strengthen!");
                Console.ReadLine();
                Console.WriteLine(companionName + " and " + playerName + " gained + 10 health + 2 damage + coinPower");
                Console.ReadLine();
                Console.WriteLine(companionName + ": H-huh?");
                Console.ReadLine();
                Console.WriteLine("Pete" + ": You haven't paid your debt " + companionName + "...");
                Console.ReadLine();
                Console.WriteLine(companionName + ": I already told you " + "Pete" + "! " + " I'll pay you next week! ");
                Console.ReadLine();
                Console.WriteLine("Lenny" + ": HA! " + "You promised to pay this week " + companionName + "!" + " We're not leaving empty handed");
                Console.ReadLine();
                Console.WriteLine("Pete" + ": Bad for business.");
                Console.ReadLine();
                Console.WriteLine("Lenny" + ": Oh, I know! How about we'll take a part of you~ ");
                Console.ReadLine();
                Console.WriteLine("Pete" + ": Along with your friend!");
                Console.ReadLine();
                Console.WriteLine(companionName + ": Come on " + playerName + "!" + " Let's fight these freaks and get out of here!");
                Console.ReadLine();
                Console.WriteLine(playerName + ": Ugghhh, why'd I get involved in this?");
                Console.ReadLine();
                companion1.ApplyBonusEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                            ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower);
            }
            else
            {
                Console.WriteLine(companionName + ": Tragic...");
                Console.ReadLine();
                Console.WriteLine(companionName + ": Damnit... We've got company! " + playerName + ", Watch out!");
                Console.ReadLine();
                Console.WriteLine("You rejected " + companionName + "'s offer. Your bonds weaken!");
                Console.ReadLine();
                Console.WriteLine(companionName + " and " + playerName + "reduced - 10 health - 2 damage - coinPower");
                Console.ReadLine();
                companion1.ApplyNegativeEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                               ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower);
                Console.WriteLine(companionName + ": H-huh?");
                Console.ReadLine();
                Console.WriteLine("Pete" + ": You haven't paid your debt " + companionName + "...");
                Console.ReadLine();
                Console.WriteLine(companionName + ": I already told you " + "Pete" + "! " + " I'll pay you next week! ");
                Console.ReadLine();
                Console.WriteLine("Lenny" + ": HA! " + "You promised to pay this week " + companionName + "!" + " We're not leaving empty handed");
                Console.ReadLine();
                Console.WriteLine("Pete" + ": Bad for business.");
                Console.ReadLine();
                Console.WriteLine("Lenny" + ": Oh, I know! How about we'll take a part of you~ ");
                Console.ReadLine();
                Console.WriteLine("Pete" + ": Along with your friend!");
                Console.ReadLine();
                Console.WriteLine(companionName + ": Come on " + playerName + "!" + " Let's fight these freaks and get out of here!");
                Console.ReadLine();
                Console.WriteLine(playerName + ": Ugghhh, why'd I get involved in this?");
                Console.ReadLine();
            }

            while (playerHealth > 0 && PeteCheck != 1 && LennyCheck != 1)
            {

                Console.WriteLine(playerName + " Health: " + playerHealth + " " + companionName + " Health:  " + firstCompanionHealth + " | Pete's Health: " + enemy2Health + "Lenny's Health: " + enemy3Health );
                Console.WriteLine("What will " + playerName + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string playerAction = Console.ReadLine();

                switch (playerAction)
                {
                    case "1":
                        PerformAttack2(playerName, ref playerHealth, companionName, enemyName2, enemyName3, ref playerBaseDamage, ref firstCompanionBaseDamage, playerCoin, playerCoinPower, firstCompanionCoin, firstCompanionCoinPower, ref enemy2Health, ref enemy3Health, ref enemy2BaseDamage, ref enemy3BaseDamage, ref enemyBaseDamage);
                        break;



                    case "2":
                        PerformDefend(playerName, ref playerBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;
                }

                Console.WriteLine("What will " + companionName + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                
                string companionAction = Console.ReadLine();

                switch (companionAction)
                {
                    case "1":
                        PerformAttack3(playerName, ref firstCompanionHealth, companionName, enemyName2, enemyName3, ref playerBaseDamage, ref firstCompanionBaseDamage, playerCoin, playerCoinPower, firstCompanionCoin, firstCompanionCoinPower, ref enemy2Health, ref enemy3Health, ref enemy2BaseDamage, ref enemy3BaseDamage, ref enemyBaseDamage);
                        break;
                    case "2":
                        PerformDefend(companionName, ref firstCompanionBaseDamage); 
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;
                }

                if (enemy2Health <= 0)
                    {
                        Console.WriteLine(enemyName2 + "Pete: Arrrghh! Damn you! ");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "Pete: Let's finish this...");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "Pete: HA!");
                        Console.ReadLine();
                        Console.WriteLine("*Pete suddenly lunges at you*");
                        Console.ReadLine();
                        Console.WriteLine("Final Phase: Dodge Check.");

                        Console.WriteLine("Press Enter to Dodge!");
                        Console.ReadLine();

                        Random coinflip = new Random(); // Random Number Generator for coinflips
                        string[] coinflipresults = new string[playerCoin];
                        string resultString = "";

                        for (int i = 0; i < playerCoin; i++)
                        {
                            int rndcf = coinflip.Next(0, 2);
                            if (rndcf == 0)
                            {
                                playerBaseDamage += playerCoinPower;
                                coinflipresults[i] = "Heads";
                                Console.WriteLine(playerName + "'s Coin Power: " + "+" + playerCoinPower);
                            }
                            else if (rndcf == 1)
                            {
                                coinflipresults[i] = "Tails";
                                Console.WriteLine(playerName + "'s Coin Power: +0");
                            }
                        }

                        for (int i = 0; i < coinflipresults.Length; i++)
                        {
                            resultString += coinflipresults[i];
                            if (i < coinflipresults.Length - 1)
                            {
                                resultString += ", ";
                            }
                        }
                        Console.WriteLine("Check results for " + playerName + ": " + resultString + "|| Final Count: " + playerBaseDamage);

                        if (playerBaseDamage < 5)
                        {
                            Console.WriteLine("You failed to dodge! " + enemyName2 + "Pete's attack!");
                            Console.ReadLine();
                            Console.WriteLine(playerName + ": Ngh!");
                            Console.ReadLine();
                            Console.WriteLine(enemyName2 + ": Another one bites the dust!");
                            Console.ReadLine();
                            Console.WriteLine(companionName + ": " + playerName + "! No!");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        else if (playerBaseDamage >= 5)
                        {
                            Console.WriteLine("You dodged " + enemyName2 + "Pete's attack!" );
                            Console.ReadLine();
                            Console.WriteLine(playerName + ": Now's my chance!");
                            Console.ReadLine();
                            Console.WriteLine(playerName + "Countered Pete's Attack!");
                            Console.ReadLine();
                            Console.WriteLine("Pete: Arghhh!! ");
                            Console.ReadLine();
                            Console.WriteLine("Pete ran away...");
                            Console.ReadLine();
                            PeteCheck = 1;
                        }
                    }

                    Console.ReadLine();

                
                
                if (enemy3Health <= 0)
                {
                    Console.WriteLine(enemyName3 + "Lenny: Arrrghh! I am going to gut you like a fish! ");
                    Console.ReadLine();
                    Console.WriteLine(enemyName3 + "Lenny: Stand very still...");
                    Console.ReadLine();
                    Console.WriteLine(enemyName3 + "Lenny: HA!");
                    Console.ReadLine();
                    Console.WriteLine("*Lenny suddenly lunges at you*");
                    Console.ReadLine();
                    Console.WriteLine("Final Phase: Dodge Check.");

                    Console.WriteLine("Press Enter to Dodge!");
                    Console.ReadLine();

                    Random coinflip = new Random(); // Random Number Generator for coinflips
                    string[] coinflipresults = new string[firstCompanionCoin];
                    string resultString = "";

                    for (int i = 0; i < firstCompanionCoin; i++)
                    {
                        int rndcf = coinflip.Next(0, 3);
                        if (rndcf == 0)
                        {
                            firstCompanionBaseDamage += firstCompanionCoinPower;
                            coinflipresults[i] = "Heads";
                            Console.WriteLine(companionName + "'s Coin Power: " + "+" + firstCompanionCoinPower);
                        }
                        else if (rndcf == 1)
                        {
                            coinflipresults[i] = "Tails";
                            Console.WriteLine(playerName + "'s Coin Power: +0");
                        }
                    }

                    for (int i = 0; i < coinflipresults.Length; i++)
                    {
                        resultString += coinflipresults[i];
                        if (i < coinflipresults.Length - 1)
                        {
                            resultString += ", ";
                        }
                    }
                    Console.WriteLine("Check results for " + companionName + ": " + resultString + "|| Final Count: " + firstCompanionBaseDamage);

                    if (firstCompanionBaseDamage < 5)
                    {
                        Console.WriteLine("You failed to dodge! " + enemyName3 + "Lenny's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName3 + "Lenny: That's what you get!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": " + companionName + "! Get up!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (playerBaseDamage >= 5)
                    {
                        Console.WriteLine("You dodged " + enemyName3 + "Lenny's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": An opening!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + " Countered Lenny's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("Lenny: Ngghhh!! ");
                        Console.ReadLine();
                        Console.WriteLine("Lenny ran away...");
                        Console.ReadLine();
                        LennyCheck = 1;
                    }
                }
                Console.ReadLine();
            }
            if (playerHealth <= 0)
            {
                Console.WriteLine("You have been defeated!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else if (firstCompanionHealth <= 0)
            {
                Console.WriteLine("Your companion have been defeated!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else if (PeteCheck == 1 && LennyCheck == 0)
            {
                Console.WriteLine("Pete: I'm out of here! " );
                Console.ReadLine();
            }
            else if (LennyCheck == 1 && PeteCheck == 0)
            {
                Console.WriteLine("Lenny: I'm out!");
                Console.ReadLine();
            }

            else if (PeteCheck == 1 && LennyCheck == 1)
            {
                Console.WriteLine("Both Pete and Lenny ran away! You are victorious!");
                Console.ReadLine();
            }

            Console.ReadLine();

            Console.WriteLine(companionName + ": Phew! That was rough!");
            Console.ReadLine();
            Console.WriteLine(playerName + ": Great... Now I'm in trouble with their organization..");
            Console.ReadLine();
            Console.WriteLine(playerName + ": Why the hell do you even have a debt to them? What did you do?");
            Console.ReadLine();
            Console.WriteLine(companionName + ": I just needed some cash " + playerName + ".");
            Console.ReadLine();
            Console.WriteLine(playerName + ": I see?");
            Console.ReadLine();
            Console.WriteLine(playerName + ": But of all people you could've loaned. The rats is a deathwish! They are full of people that want to kill you");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Yeh yeehh~ I know! I just wanted a quick cash man! Nothing too out of the ordinary");
            Console.ReadLine();
            Console.WriteLine(playerName + ": *sigh*");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Hey! Don't get upset with me!");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Wanna go get a drink? Let's unwind for a little bit!");
            Console.ReadLine();
            Console.WriteLine("1. Accept " + companionName + "'s offer");
            Console.WriteLine("2. Decline " + companionName + "'s offer");

            string choice1 = Console.ReadLine();

            if (choice1 == "1")
            {
                Console.WriteLine(companionName + ": Very Wise Decision " + playerName + "!");
                Console.ReadLine();
                Console.WriteLine(companionName + ": Let's have a drink! ");
                Console.ReadLine();
                Console.WriteLine("You accepted " + companionName + "'s offer. Your bonds strengthen!");
                Console.ReadLine();
                Console.WriteLine(companionName + " and " + playerName + " gained + 10 health + 2 damage + coinPower");
                Console.ReadLine();

                companion1.ApplyBonusEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                            ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower);
            }
            else
            {
                Console.WriteLine(companionName + ": Ack! You're no fun!");
                Console.ReadLine();
                Console.WriteLine(companionName + ": but, fine I guess... You're the boss");
                Console.ReadLine();
                Console.WriteLine("You rejected " + companionName + "'s offer. Your bonds weaken!");
                Console.ReadLine();
                Console.WriteLine(companionName + " and " + playerName + "reduced - 10 health - 2 damage - coinPower");
                Console.ReadLine();
                companion1.ApplyNegativeEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                               ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower);
            }
            Console.ReadLine();

            Console.WriteLine("After hanging out with" + companionName + ", you decided to part ways with him");
            Console.ReadLine();
            Console.WriteLine(playerName + ": That was fun, " + companionName + " let's do that again sometime");
            Console.ReadLine();
            Console.WriteLine(companionName + ": It's getting late we should part ways for now! See you, " + playerName);
            Console.ReadLine();
            Console.WriteLine(playerName + ": See you, " + companionName + " and take care");
            Console.ReadLine();
            Console.WriteLine("You decided to go back to your home and rest...");
            Console.ReadLine();
            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();





        }



        static void SimulatePlayerInput(string input)

        {
            Console.Write("Player enters: ");
            foreach (char c in input)
            {
                Console.Write(c);
                Thread.Sleep(300); // Simulate typing delay
            }
            Console.WriteLine();
        }

        static void PerformAttack(string playerName,ref int playerHealth, ref int playerBaseDamage, int playerCoin, int playerCoinPower, ref int enemyHealth, ref int enemyBaseDamage)
        {
            Console.WriteLine(playerName + " chose to ATTACK!");

            Random coinflip = new Random(); // Random Number Generator for coinflips
            int totalPlayerDamage = playerBaseDamage;
            int totalEnemyDamage = enemyBaseDamage;

            for (int i = 0; i < playerCoin; i++)
            {
                int rndcf = coinflip.Next(0, 2);
                if (rndcf == 0) //heads
                {
                    totalPlayerDamage += playerCoinPower;
                    Console.WriteLine(playerName + "'s Coin Power: " + "+ " + playerCoinPower);

                    totalEnemyDamage += playerCoinPower; // Update this line if you want to use a different value for enemyCoinPower
                    Console.WriteLine("Enemy's Coin Power: " + "+ " + playerCoinPower);
                }
                else if (rndcf == 1) //tails
                {
                    Console.WriteLine(playerName + "'s Coin Power: +0");
                    Console.WriteLine("Enemy's Coin Power +0");
                }
            }

            Console.WriteLine("Total damage dealt by " + playerName + ": " + totalPlayerDamage);
            Console.WriteLine("Total damage dealt by the enemy: " + totalEnemyDamage);

            enemyHealth -= totalPlayerDamage;

            playerHealth -= totalEnemyDamage;
            

            Console.WriteLine("Remaining enemy health: " + enemyHealth);
        }

        static void PerformAttack2(string playerName,ref int playerHealth, string companionName, string enemyName2, string enemyName3, ref int playerBaseDamage, ref int firstCompanionBaseDamage, int playerCoin, int playerCoinPower, int firstCompanionCoin, int firstCompanionCoinPower, ref int enemy2Health, ref int enemy3Health, ref int enemy2BaseDamage, ref int enemy3BaseDamage, ref int enemyBaseDamage)

        {
            Console.WriteLine(playerName + " chose to ATTACK!");

            Random coinflip = new Random(); // Random Number Generator for coinflips

            int totalPlayerDamage = playerBaseDamage;
            int totalCompanionDamage = firstCompanionBaseDamage;
            int totalEnemy2Damage = enemy2BaseDamage;
            int totalEnemy3Damage = enemy3BaseDamage;



            for (int i = 0; i < playerCoin; i++)
            {
                int rndcf = coinflip.Next(0, 2);
                if (rndcf == 0)
                {
                    totalPlayerDamage += playerCoinPower;
                    Console.WriteLine(playerName + "'s Coin Power: " + "+ " + playerCoinPower);

                    totalEnemy2Damage += playerCoinPower; // Update this line if you want to use a different value for enemyCoinPower
                    Console.WriteLine("Enemy's Coin Power: " + "+ " + playerCoinPower);
                }
                else if (rndcf == 1) //tails
                {
                    Console.WriteLine(playerName + "'s Coin Power: +0");
                    Console.WriteLine("Enemy's Coin Power +0");
                }
            }

            Console.WriteLine("Total damage dealt by " + playerName + ": " + totalPlayerDamage);
            Console.WriteLine("Total damage dealt by the enemy: " + totalEnemy2Damage);

            enemy2Health -= totalPlayerDamage;

            playerHealth -= totalEnemy2Damage;

            Console.WriteLine("Remaining enemy health: " + enemy2Health);

        }

        static void PerformAttack3(string playerName, ref int firstCompanionHealth, string companionName, string enemyName2, string enemyName3, ref int playerBaseDamage, ref int firstCompanionBaseDamage, int playerCoin, int playerCoinPower, int firstCompanionCoin, int firstCompanionCoinPower, ref int enemy2Health, ref int enemy3Health, ref int enemy2BaseDamage, ref int enemy3BaseDamage, ref int enemyBaseDamage)

        {
            Console.WriteLine(companionName + " chose to ATTACK!");

            Random coinflip = new Random(); // Random Number Generator for coinflips

            int totalCompanionDamage = firstCompanionBaseDamage;
            int totalEnemy3Damage = enemy3BaseDamage;

            for (int j = 0; j < firstCompanionCoin; j++)
            {
                int rng = coinflip.Next(0, 3);
                if (rng == 0)
                {
                    totalCompanionDamage += firstCompanionCoinPower;
                    Console.WriteLine(companionName + "'s Coin Power: " + "+ " + firstCompanionCoinPower);

                    totalEnemy3Damage += firstCompanionCoinPower;
                    Console.WriteLine(enemyName3 + "'s Coin Power: " + "+ " + firstCompanionCoinPower);
                }
                else if (rng == 1)
                {
                    Console.WriteLine(companionName + "'s Coin Power: +0");
                    Console.WriteLine(enemyName3 + "'s Coin Power +0");
                }
            }

            Console.WriteLine("Total damage dealt by " + companionName + ": " + totalCompanionDamage);
            Console.WriteLine("Total damage dealt by the enemy: " + totalEnemy3Damage);

            enemy3Health -= totalCompanionDamage;

            firstCompanionHealth -= totalEnemy3Damage;

            Console.WriteLine("Remaining enemy health: " + enemy3Health);
        }









        static void PerformDefend(string playerName, ref int playerBaseDamage)
        {
            Console.WriteLine(playerName + " chose to DEFEND!");
            // Implement defend logic if needed
        }

    }
    class Companion1
    {
        private string name;

        public Companion1(string name)
        {
            this.name = name;
        }

        public void ApplyBonusEffect(ref int playerHealth, ref int playerBaseDamage, ref int playerCoinPower,
                                     ref int firstCompanionHealth, ref int firstCompanionBaseDamage, ref int firstCompanionCoinPower)
        {
            playerHealth += 10;
            playerBaseDamage += 2;
            playerCoinPower += 1;

            firstCompanionHealth += 10;
            firstCompanionBaseDamage += 2;
            firstCompanionCoinPower += 1;
        }

        public void ApplyNegativeEffect(ref int playerHealth, ref int playerBaseDamage, ref int playerCoinPower,
                                        ref int firstCompanionHealth, ref int firstCompanionBaseDamage, ref int firstCompanionCoinPower)
        {
            playerHealth -= 10;
            playerBaseDamage -= 2;
            playerCoinPower -= 1;

            firstCompanionHealth -= 10;
            firstCompanionBaseDamage -= 2;
            firstCompanionCoinPower -= 1;
        }
    }
}
