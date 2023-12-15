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

            Console.WriteLine("\nGreat job! Now you're ready for battle.");
            Console.WriteLine("Press Enter to start the fight!");
            Console.ReadLine();
        }

        static void RunFight()
        {
            int playerHealth = 150;
            int player2Health = 80;

            int gold = 0;

            int RatRogueHealth = 100;
            int RatRogue2Health = 100;

            int FinalBossHealth = 500;
            int FinalBoss2Health = 600;
            int FinalBoss3Health = 400;

            int RatBruteHealth = 80;
            int RatBrute2Health = 80;
            int RatBrute3Health = 90;
            int RatBrute4Health = 100;
            int RatBrute5Health = 110;

            int RatLancerHealth = 90;
            int RatLancer2Health = 90;
            int RatLancer3Health = 100;
            int RatLancer4Health = 110;
            int RatLancer5Health = 120;

            int enemyHealth = 90;
            int enemy2Health = 50;
            int enemy3Health = 80;

            int playerBaseDamage = 8;
            int player2BaseDamage = 3;

            int enemyBaseDamage = 2;
            int enemy2BaseDamage = 2;
            int enemy3BaseDamage = 3;

            int FinalBossBaseDamage = 7;


            int RatRogueBaseDamage = 6;
            int RatRogue2BaseDamage = 6;

            int RatBruteBaseDamage = 4;
            int RatBrute2BaseDamage = 4;
            int RatBrute3BaseDamage = 5;
            int RatBrute4BaseDamage = 6;
            int RatBrute5BaseDamage = 6;

            int RatLancerBaseDamage = 3;
            int RatLancer2BaseDamage = 3;
            int RatLancer3BaseDamage = 4;
            int RatLancer4BaseDamage = 5;
            int RatLancer5BaseDamage = 5;

            int playerCoin = 3;
            int playerCoin2 = 3;

            int enemyCoin = 2;
            int enemyCoin2 = 2;
            int enemyCoin3 = 3;

            int FinalBossCoin = 6;

            int RatRogueCoin = 5;
            int RatRogue2Coin = 5;

            int RatBruteCoin = 1;
            int RatBruteCoin2 = 1;
            int RatBrute4Coin = 2;
            int RatBrute5Coin = 3;

            int RatLancerCoin = 3;
            int RatLancerCoin2 = 3;
            int RatLancer4Coin = 4;
            int RatLancer5Coin = 5;

            int firstCompanionHealth = 90;
            int firstCompanionBaseDamage = 6;
            int firstCompanionCoin = 3;
            int firstCompanionCoinPower = 3;

            int finalCompanionHealth = 80;
            int finalCompanionBaseDamage = 5;
            int finalCompanionCoin = 4;
            int finalCompanionCoinPower = 4;

            int playerCoinPower = 5;
            int playerCoinPower2 = 2;

            int RatRogueCoinPower = 5;
            int RatRogue2CoinPower = 5;

            int FinalBossCoinPower = 5;

            int enemyCoinPower = 3;
            int enemyCoinPower2 = 2;
            int enemyCoinPower3 = 3;

            int RatBruteCoinPower = 5;
            int RatBrute2CoinPower = 5;
            int RatBrute3CoinPower = 6;
            int RatBrute4CoinPower = 7;
            int RatBrute5CoinPower = 7;

            int RatLancerCoinPower = 2;
            int RatLancer2CoinPower = 2;
            int RatLancer3CoinPower = 3;
            int RatLancer4CoinPower = 4;
            int RatLancer5CoinPower = 4;

            int NaimonCheck = 0;
            int PeteCheck = 0;
            int LennyCheck = 0;

            int RatBruteCheck = 0;
            int RatBrute2Check = 0;
            int RatBrute3Check = 0;
            int RatBrute4Check = 0;
            int RatBrute5Check = 0;

            int RatLancerCheck = 0;
            int RatLancer2Check = 0;
            int RatLancer3Check = 0;
            int RatLancer4Check = 0;
            int RatLancer5Check = 0;

            int RatRogueCheck = 0;
            int RatRogue2Check = 0;

            int FinalBossCheck = 0;
            int FinalBoss2Check = 0;
            int FinalBoss3Check = 0;



            string enemyName;
            string enemyName2 = "";
            string enemyName3 = "";

            Console.Write("Your name is: ");
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
                        PerformAttack(playerName, ref playerHealth, ref playerBaseDamage, playerCoin, playerCoinPower, ref enemyHealth, ref enemyBaseDamage);
                        break;

                    case "2":
                        PerformDefend(playerName, ref playerBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;
                }


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
                Console.WriteLine("Naimon: It's been a while since I've got these old bones moving.'");
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
                Console.WriteLine(companionName + " and " + playerName + " gained + 20 health + 2 damage + coinPower");
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

                Console.WriteLine(playerName + " Health: " + playerHealth + " " + companionName + " Health:  " + firstCompanionHealth + " | Pete's Health: " + enemy2Health + "Lenny's Health: " + enemy3Health);
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
                        Console.WriteLine("Invalid choice. " + companionName + " stumbles.");
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
                        Console.WriteLine("You dodged " + enemyName2 + "Pete's attack!");
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
                    Console.WriteLine("*Lenny suddenly lunges at " + companionName + "*");
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
                            Console.WriteLine(companionName + "'s Coin Power: +0");
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
                        Console.WriteLine(companionName + " dodged " + enemyName3 + "Lenny's attack!");
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
                Console.WriteLine("Pete: I'm out of here! ");
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
            Console.WriteLine(playerName + ": But of all organization you could've loaned. The rats is a deathwish! They are full of people that want to kill you");
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
                Console.WriteLine(companionName + " and " + playerName + " gained + 20 health + 2 damage + coinPower");
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

            Console.WriteLine("After hanging out with " + companionName + ", you decided to part ways with him");
            Console.ReadLine();
            Console.WriteLine(playerName + ": That was fun, " + companionName + " let's do that again sometime");
            Console.ReadLine();
            Console.WriteLine(companionName + ": It's getting late we should part ways for now! See you, " + playerName);
            Console.ReadLine();
            Console.WriteLine(playerName + ": See you, " + companionName + " and take care");
            Console.ReadLine();
            Console.WriteLine("You decided to go back to your home and rest...");
            Console.ReadLine();
            Console.WriteLine("You woke up");
            Console.ReadLine();
            Console.WriteLine("Day 2");
            Console.ReadLine();
            Console.WriteLine("You prepared yourself before heading out...");
            Console.ReadLine();
            Console.WriteLine("Taskmaster: Ah, " + playerName + "Nice to see you again!");
            Console.ReadLine();
            Console.WriteLine(playerName + ": Morning, so. What's my objective for today?");
            Console.ReadLine();
            Console.WriteLine("Taskmaster: your objective for today is to go to this organization's boss and give this package to him");
            Console.ReadLine();
            Console.WriteLine(playerName + ": Wait, that's it?");
            Console.ReadLine();
            Console.WriteLine("Taskmaster: Yes.");
            Console.ReadLine();
            Console.WriteLine(playerName + ": Alright, sounds easy enough.");
            Console.ReadLine();
            Console.WriteLine("As you are going to your desntination, you suddenly found " + companionName + " getting attacked by a group of thugs");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Hey! " + playerName + ", a little help here?");
            Console.ReadLine();
            Console.WriteLine("1. Help " + companionName);
            Console.WriteLine("2. Leave " + companionName);

            string choice2 = Console.ReadLine();

            if (choice2 == "1")
            {
                Console.WriteLine("You decided to fight with " + companionName + ".");
                Console.ReadLine();
                Console.WriteLine("You accepted " + companionName + "'s offer. Your bonds strengthen!");
                Console.ReadLine();
                Console.WriteLine(companionName + " and " + playerName + " gained + 20 health + 2 damage + coinPower");
                Console.ReadLine();

                companion1.ApplyBonusEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                            ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower);

            }

            else
            {
                Console.WriteLine("You left " + companionName + ".");
                Console.ReadLine();
                Console.WriteLine(companionName + ": What an #$@");
                Console.ReadLine();
                Console.WriteLine("You rejected " + companionName + "'s offer. Your bonds weakens!");
                Console.ReadLine();
                Console.WriteLine(companionName + " and " + playerName + "reduced - 10 health - 2 damage - coinPower");
                Console.ReadLine();
                companion1.ApplyNegativeEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                               ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower);
                Console.WriteLine("*Some of the thugs approached you.*");
                Console.ReadLine();
                Console.WriteLine("Rat Lancer: Where do you think you're going?");
                Console.ReadLine();
                Console.WriteLine(playerName + ": Darn..");
                Console.ReadLine();

            }

            while (playerHealth > 0 && RatBruteCheck != 1 && RatLancerCheck != 1)
            {

                Console.WriteLine(playerName + " Health: " + playerHealth + " " + companionName + " Health:  " + firstCompanionHealth + " | Rat Brute's Health: " + RatBruteHealth + " Rat Lancer's Health: " + RatLancerHealth);
                Console.WriteLine("What will " + playerName + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string playerAction = Console.ReadLine();

                switch (playerAction)
                {
                    case "1":
                        PerformAttack4(playerName, ref playerHealth, ref playerBaseDamage, ref firstCompanionBaseDamage, playerCoin, playerCoinPower, firstCompanionCoin, firstCompanionCoinPower, ref RatBruteHealth, ref RatBruteBaseDamage);
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
                        PerformAttack5(ref firstCompanionHealth, companionName, "Rat Lancer", ref firstCompanionBaseDamage, ref firstCompanionCoin, firstCompanionCoinPower, RatLancerCoinPower, ref RatLancerHealth, ref RatLancerBaseDamage);
                        break;
                    case "2":
                        PerformDefend(companionName, ref firstCompanionBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;
                }

                if (RatBruteHealth <= 0)
                {
                    Console.WriteLine(enemyName2 + "Rat Brute: Ghhkk! ");
                    Console.ReadLine();
                    Console.WriteLine("*The Rat Brute suddenly lunges at you*");
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
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "Rat Brute's attack!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + ": HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": " + playerName + "! No!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (playerBaseDamage >= 5)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "Rat Brute's attack!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": Now's my chance!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + "Countered Rat Brute's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("Rat Brute: Arghhh!! ");
                        Console.ReadLine();
                        RatBruteCheck = 1;
                    }
                }

                Console.ReadLine();



                if (RatLancerHealth <= 0)
                {
                    Console.WriteLine(enemyName3 + "Rat Lancer: Aaargghh! ");
                    Console.ReadLine();
                    Console.WriteLine(enemyName3 + "Rat Lancer: HA!");
                    Console.ReadLine();
                    Console.WriteLine("*Rat Lancer suddenly lunges at " + companionName + "*");
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
                            Console.WriteLine(companionName + "'s Coin Power: +0");
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
                        Console.WriteLine("You failed to dodge! " + enemyName3 + "RatLancer's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName3 + "RatLancer: never mess with us again!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": " + companionName + "! Get up!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (playerBaseDamage >= 5)
                    {
                        Console.WriteLine(companionName + " dodged " + enemyName3 + "Rat Lancer's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": An opening!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + " Countered RatLancer's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("RatLancer: Ngghhh!! ");
                        Console.ReadLine();
                        RatLancerCheck = 1;
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

            else if (RatBruteCheck == 1 && RatLancerCheck == 0)
            {
                Console.WriteLine("Rat Brute has been defeated!");
                Console.ReadLine();
            }
            else if (RatLancerCheck == 1 && RatBruteCheck == 0)
            {
                Console.WriteLine("Rat Lancer has been defeated!");
                Console.ReadLine();
            }

            else if (RatBruteCheck == 1 && RatLancerCheck == 1)
            {
                Console.WriteLine("Both Rat Brute and Rat Lancer has been defeated! You are victorious!");
                Console.ReadLine();
            }
            Console.ReadLine();

            Console.WriteLine(companionName + " " + playerName + "! " + "More incoming");
            Console.ReadLine();
            Console.WriteLine("*Your bonds has slightly increased!*");
            Console.ReadLine();
            Console.WriteLine(playerName + " and " + companionName + " gained + 10 health and + 1 damage");
            companion1.ApplySemiBonusEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                     ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower);

            while (playerHealth > 0 && RatBrute2Check != 1 && RatLancer2Check != 1)
            {

                Console.WriteLine(playerName + " Health: " + playerHealth + " " + companionName + " Health:  " + firstCompanionHealth + " | Rat Brute's Health: " + RatBrute2Health + " Rat Lancer's Health: " + RatLancer2Health);
                Console.WriteLine("What will " + playerName + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string playerAction = Console.ReadLine();

                switch (playerAction)
                {
                    case "1":
                        PeformAttack6(playerName, ref playerHealth, ref playerBaseDamage, playerCoin, playerCoinPower, ref RatBrute2Health, ref RatBrute2BaseDamage);
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
                        PerformAttack7(playerName, ref firstCompanionHealth, companionName, "Rat Lancer", enemyName3, ref RatLancer2BaseDamage, ref firstCompanionBaseDamage, playerCoin, playerCoinPower, firstCompanionCoin, firstCompanionCoinPower, ref RatLancer2Health);
                        break;
                    case "2":
                        PerformDefend(companionName, ref firstCompanionBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;
                }

                if (RatBrute2Health <= 0)
                {
                    Console.WriteLine(enemyName2 + "RatBrute: Ghhkk! ");
                    Console.ReadLine();
                    Console.WriteLine("*The RatBrute suddenly lunges at you*");
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
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "RatBrute's attack!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + ": HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": " + playerName + "! No!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (playerBaseDamage >= 5)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "RatBrute's attack!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": Now's my chance!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + "Countered RatBrute's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("RatBrute: Arghhh!! ");
                        Console.ReadLine();
                        Console.WriteLine("RatBrute has been defeated...");
                        Console.ReadLine();
                        RatBrute2Check = 1;
                    }
                }

                Console.ReadLine();

                if (RatLancer2Health <= 0)
                {
                    Console.WriteLine(enemyName2 + "RatLancer: Ghhkk! ");
                    Console.ReadLine();
                    Console.WriteLine("*The RatLancer suddenly lunges at " + companionName + "*");
                    Console.ReadLine();
                    Console.WriteLine("Final Phase: Dodge Check.");
                    Console.WriteLine("Press Enter to Dodge!");
                    Console.ReadLine();

                    Random coinflip = new Random(); // Random Number Generator for coinflips
                    string[] coinflipresults = new string[firstCompanionCoin];
                    string resultString = "";

                    for (int i = 0; i < firstCompanionCoin; i++)
                    {
                        int rndcf = coinflip.Next(0, 2);
                        if (rndcf == 0)
                        {
                            firstCompanionBaseDamage += firstCompanionCoinPower;
                            coinflipresults[i] = "Heads";
                            Console.WriteLine(companionName + "'s Coin Power: " + "+" + firstCompanionCoinPower);
                        }
                        else if (rndcf == 1)
                        {
                            coinflipresults[i] = "Tails";
                            Console.WriteLine(companionName + "'s Coin Power: +0");
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

                    if (firstCompanionBaseDamage < 8)
                    {
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "RatLancer's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "RatLancer: HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": " + companionName + "! Get up!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (firstCompanionBaseDamage >= 8)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "RatLancer's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": Now's my chance!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + "Countered RatBrute's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("RatLancer: Arghhh!! ");
                        Console.ReadLine();
                        RatLancer2Check = 1;
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
                Console.WriteLine(companionName + " Fainted!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else if (RatBrute2Check == 1 && RatLancer2Check == 0)
            {
                Console.WriteLine("RatBrute has been defeated!");
                Console.ReadLine();
                Console.WriteLine("*RanLancer Ran Away!*");
                Console.ReadLine();
            }
            else if (RatLancer2Check == 1 && RatBrute2Check == 0)
            {
                Console.WriteLine("RatLancer has been defeated!");
                Console.ReadLine();
                Console.WriteLine("*RanBrute Ran Away!*");
                Console.ReadLine();
            }

            else if (RatBrute2Check == 1 && RatLancer2Check == 1)
            {
                Console.WriteLine("Both RatBrute and RatLance has been defeated! You are victorious!");
                Console.ReadLine();
            }
            Console.ReadLine();

            Console.WriteLine("Your bonds has increased!");
            Console.ReadLine();
            Console.WriteLine(playerName + " and " + companionName + " gained + 20 health, + 2 damage, and + 1 coin damage!");
            Console.ReadLine();
            companion1.ApplyBonusEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                            ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower);
            Console.WriteLine(companionName + ": Phew! That's all of them!");
            Console.ReadLine();
            Console.WriteLine(playerName + ": They're still after you huh?");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Yeah, I think they won't stop until they get what they want");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Anyways! Where were you going?");
            Console.ReadLine();
            Console.WriteLine(playerName + ": I'm just delivering a packagage");
            Console.ReadLine();
            Console.WriteLine(companionName + ": To who?");
            Console.ReadLine();
            Console.WriteLine(playerName + ": I'm not sure, I haven't see the note yet.");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Let's take a look it!");
            Console.ReadLine();
            Console.WriteLine(companionName + ": But, before that! Let's take a break. I feel a little bit tired");
            Console.ReadLine();
            Console.WriteLine(playerName + ": Not against that idea.");
            Console.ReadLine();
            Console.WriteLine("*" + playerName + " and " + companionName + " Took a break*");
            Console.ReadLine();
            Console.WriteLine(playerName + " and " + companionName + " restored 50 health!");
            companion1.TakeBreak(ref playerHealth, ref firstCompanionHealth);
            Console.ReadLine();

            // aight I give up, ahma put some lines here later, the note will say The Rats and they will be surprised and they will go to their building or whatever (That's where our dungeon crawler section begins)

            Console.WriteLine(companionName + ": so, this is their place. Huh.");
            Console.ReadLine();
            Console.WriteLine(companionName + ": It looks scary");
            Console.ReadLine();
            Console.WriteLine("Rat Brute: It's them!");
            Console.ReadLine();
            Console.WriteLine("*The Rat Brute charges at " + companionName + "*");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Huh!?");
            Console.ReadLine();
            Console.WriteLine(playerName + ": " + companionName + ", Watch out!");
            Console.ReadLine();
            Console.WriteLine("Press Enter to parry Rat Brute's attack!");
            Console.ReadLine();

            Random eventCoinflip = new Random(); // Random Number Generator for coinflips
            string[] eventCoinflipresults = new string[playerCoin];
            string eventResultString = "";

            for (int i = 0; i < playerCoin; i++)
            {
                int rndcf = eventCoinflip.Next(0, 2);
                if (rndcf == 0)
                {
                    playerBaseDamage += playerCoinPower;
                    eventCoinflipresults[i] = "Heads";
                    Console.WriteLine(playerName + "'s Coin Power: " + "+" + playerCoinPower);
                }
                else if (rndcf == 1)
                {
                    eventCoinflipresults[i] = "Tails";
                    Console.WriteLine(playerName + "'s Coin Power: +0");
                }
            }

            for (int i = 0; i < eventCoinflipresults.Length; i++)
            {
                eventResultString += eventCoinflipresults[i];
                if (i < eventCoinflipresults.Length - 1)
                {
                    eventResultString += ", ";
                }
            }
            Console.WriteLine("Check results for " + playerName + ": " + eventResultString + "|| Final Count: " + playerBaseDamage);

            if (playerBaseDamage < 30)
            {
                Console.WriteLine("You failed to parry " + enemyName2 + "Rat Brute's attack!");
                Console.ReadLine();
                Console.WriteLine(companionName + ": Guh!");
                Console.ReadLine();
                Console.WriteLine(companionName + " got hit!");
                Console.ReadLine();
                Console.WriteLine(companionName + " Took 20 damage!");
                Console.ReadLine();
                int EventTotalRatBruteDamage = 20;
                firstCompanionHealth -= EventTotalRatBruteDamage;
                Console.WriteLine(companionName + ": that hurts!");
                Console.ReadLine();
                Console.WriteLine(companionName + ": C'mon " + playerName + ", let's defeat them!");
                Console.ReadLine();

            }
            else if (playerBaseDamage >= 30)
            {
                Console.WriteLine("You parried " + enemyName2 + "Rat Brute's attack!");
                Console.ReadLine();
                Console.WriteLine(playerName + " Attacks the Rat Brute!");
                Console.ReadLine();
                Console.WriteLine("Rat Brute: Arghhh!! ");
                Console.ReadLine();
                Console.WriteLine("Rat Brute took 20 damage!");
                Console.ReadLine();
                int EventPlayerDamage = 20;
                RatBrute3Health -= EventPlayerDamage;
                Console.WriteLine(companionName + ": Thanks a lot!");
                Console.ReadLine();
                Console.WriteLine("Your bond strenghtens!");
                Console.ReadLine();
                Console.WriteLine(playerName + " and " + companionName + " gains + 20 Health, 2 Damage, and Coin Power!");
                Console.ReadLine();
                companion1.ApplyBonusEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                            ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower);
                Console.WriteLine(companionName + ": c'mon, let's defeat them.");
                Console.ReadLine();
            }

            while (playerHealth > 0 && RatBrute3Check != 1 && RatLancer3Check != 1)
            {

                Console.WriteLine(playerName + " Health: " + playerHealth + " " + companionName + " Health:  " + firstCompanionHealth + " | Rat Brute's Health: " + RatBrute3Health + " Rat Lancer's Health: " + RatLancer3Check);
                Console.WriteLine("What will " + playerName + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string playerAction = Console.ReadLine();

                switch (playerAction)
                {
                    case "1":
                        PeformAttack8(playerName, ref playerHealth, ref playerBaseDamage, playerCoin, playerCoinPower, ref RatBrute2Health, ref RatBrute2BaseDamage);
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
                        PerformAttack9(ref firstCompanionHealth, companionName, "RatLancer3", ref firstCompanionBaseDamage, ref RatLancer3CoinPower, firstCompanionCoin, firstCompanionCoinPower, ref RatLancer3Health, ref RatLancer3BaseDamage);
                        break;
                    case "2":
                        PerformDefend(companionName, ref firstCompanionBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;
                }

                if (RatBrute3Health <= 0)
                {
                    Console.WriteLine(enemyName2 + "RatBrute: Ghhkk! ");
                    Console.ReadLine();
                    Console.WriteLine("*The Rat Brute suddenly lunges at you*");
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
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "Rat Brute's attack!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "Rat Brute: HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": " + playerName + "! No!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (playerBaseDamage >= 5)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "Rat Brute's attack!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": Now's my chance!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + "Countered Rat Brute's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("Rat Brute: Arghhh!! ");
                        Console.ReadLine();
                        Console.WriteLine("Rat Brute has been defeated...");
                        Console.ReadLine();
                        RatBrute3Check = 1;
                    }
                }

                Console.ReadLine();

                if (RatLancer3Health <= 0)
                {
                    Console.WriteLine(enemyName2 + "Rat Lancer: Ghhkk! ");
                    Console.ReadLine();
                    Console.WriteLine("*The RatLancer suddenly lunges at " + companionName + "*");
                    Console.ReadLine();
                    Console.WriteLine("Final Phase: Dodge Check.");
                    Console.WriteLine("Press Enter to Dodge!");
                    Console.ReadLine();

                    Random coinflip = new Random(); // Random Number Generator for coinflips
                    string[] coinflipresults = new string[firstCompanionCoin];
                    string resultString = "";

                    for (int i = 0; i < firstCompanionCoin; i++)
                    {
                        int rndcf = coinflip.Next(0, 2);
                        if (rndcf == 0)
                        {
                            firstCompanionBaseDamage += firstCompanionCoinPower;
                            coinflipresults[i] = "Heads";
                            Console.WriteLine(companionName + "'s Coin Power: " + "+" + firstCompanionCoinPower);
                        }
                        else if (rndcf == 1)
                        {
                            coinflipresults[i] = "Tails";
                            Console.WriteLine(companionName + "'s Coin Power: +0");
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

                    if (firstCompanionBaseDamage < 15)
                    {
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "Rat Lancer's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "Rat Lancer: HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": " + companionName + "! Get up!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (firstCompanionBaseDamage >= 15)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "Rat Lancer's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": Now's my chance!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + "Countered Rat Lancer's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("Rat Lancer: Arghhh!! ");
                        Console.ReadLine();
                        RatLancer3Check = 1;
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
                Console.WriteLine(companionName + " Fainted!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else if (RatBrute3Check == 1 && RatLancer3Check == 0)
            {
                Console.WriteLine("Rat Brute has been defeated!");
                Console.ReadLine();
                Console.WriteLine("*Ran Lancer Ran Away!*");
                Console.ReadLine();
            }
            else if (RatLancer3Check == 1 && RatBrute3Check == 0)
            {
                Console.WriteLine("Rat Lancer has been defeated!");
                Console.ReadLine();
                Console.WriteLine("*Rat Brute Ran Away!*");
                Console.ReadLine();
            }

            else if (RatBrute3Check == 1 && RatLancer3Check == 1)
            {
                Console.WriteLine("Both Rat Brute and Rat Lance has been defeated! You are victorious!");
                Console.ReadLine();
            }
            Console.ReadLine();

            Console.WriteLine("Your bonds has increased!");
            Console.ReadLine();
            Console.WriteLine(playerName + " and " + companionName + " gained + 20 health, + 2 damage, and + 1 coin damage!");
            Console.ReadLine();
            companion1.ApplyBonusEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                            ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower);
            Console.WriteLine(companionName + ": Phew! That's all of them!");
            Console.ReadLine();
            Console.WriteLine(companionName + ": comeon! Let's head inside");
            Console.ReadLine();
            Console.WriteLine("*" + playerName + " and " + companionName + " went inside the building*");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Woah! This place is huge ");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Wait, " + playerName + " do you hear that?");
            Console.ReadLine();
            Console.WriteLine("*behind a locked door, you hear someone's voice*");
            Console.ReadLine();
            Console.WriteLine("Stranger: Hey! Can you guys hear me?");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Wa-? Who are you? ");
            Console.ReadLine();
            Console.WriteLine("Stranger: They locked me in here!");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Hey, " + playerName + "... Should we help them?");
            Console.ReadLine();
            Console.WriteLine("1. Help the stranger");
            Console.WriteLine("2. Don't help the stranger");

            string choice3 = Console.ReadLine();

            if (choice3 == "1")
            {
                Console.WriteLine("You decided to help the stranger ");
                Console.ReadLine();
                Console.WriteLine(companionName + ": found a key.");
                Console.ReadLine();
                Console.WriteLine("*You used the key...*");
                Console.ReadLine();
                Console.WriteLine("Stranger: Ah, freedom at last!");
                Console.ReadLine();
                Console.WriteLine("Stranger: Thanks for helping me out!");
                Console.ReadLine();
                Console.WriteLine("Stranger: Would you like to see my wares?");
                Console.ReadLine();
                Console.WriteLine(companionName + ": Not even a thank you?");
                Console.ReadLine();
                Console.WriteLine("Stranger: My wares is more valuable than words. ");
                Console.ReadLine();
                Console.WriteLine(companionName + ": ....");
                Console.ReadLine();
                Console.WriteLine(playerName + ": ....");
                Console.ReadLine();
                Console.WriteLine("Stranger: Are you guys buying or not?");
                Console.ReadLine();
                Console.WriteLine("1. Buy");
                Console.WriteLine("2. Don't buy");

                string choice4 = Console.ReadLine();

                if (choice4 == "1")
                {
                    Console.WriteLine(playerName + ": Ack! Fine we'll take a look");
                    Console.ReadLine();
                    Console.WriteLine("Stranger: Splendid!");
                    Console.ReadLine();
                    Console.WriteLine("Your bonds increases!");
                    Console.ReadLine();
                    Console.WriteLine(playerName + ", " + companionName + ", and the Stranger" + " gained + 20 health, + 2 damage, and + coin power!");
                    companion1.ApplyFinalBonusEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                     ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower,
                                     ref finalCompanionHealth, ref finalCompanionBaseDamage, ref finalCompanionCoinPower);
                    Console.ReadLine();
                    Console.WriteLine(companionName + ": hey, " + playerName + " I've got some gold.");
                    Console.ReadLine();
                    Console.WriteLine(companionName + ": here, take them.");
                    Console.ReadLine();
                    Console.WriteLine(playerName + ": Thanks. ");
                    Console.ReadLine();
                    Console.WriteLine("*You gained 20 gold!*");
                    Console.ReadLine();
                    gold += 20;
                    companion1.TakeBreakWithShop(ref playerHealth, ref playerBaseDamage, ref playerCoinPower, ref playerCoin,
                      ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower, ref firstCompanionCoin,
                      ref finalCompanionHealth, ref finalCompanionBaseDamage, ref finalCompanionCoinPower, ref finalCompanionCoin, ref gold);

                }
                else
                {
                    Console.WriteLine("Stranger: That's unfortunate...");
                    Console.ReadLine();
                    Console.WriteLine("You declined the stranger" + "'s offer.");
                    Console.ReadLine();
                    Console.WriteLine("Your bonds decreases!");
                    Console.ReadLine();
                    Console.WriteLine(playerName + ", " + companionName + ", and the stranger" + " reduced - 10 health, - 2 damage, and - coin power");
                    Console.ReadLine();
                    companion1.ApplyFinalNegativeBonusEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                     ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower,
                                     ref finalCompanionHealth, ref finalCompanionBaseDamage, ref finalCompanionCoinPower);
                    Console.WriteLine(companionName + ": Come on, " + playerName + "! Let's at least take a look! We might find something useful");
                    Console.ReadLine();
                    Console.WriteLine(playerName + ": I guess you're right");
                    Console.ReadLine();
                    Console.WriteLine(companionName + ": hey, " + playerName + " I've got some gold.");
                    Console.ReadLine();
                    Console.WriteLine(companionName + ": here, take them.");
                    Console.ReadLine();
                    Console.WriteLine(playerName + ": Thanks. ");
                    Console.ReadLine();
                    Console.WriteLine("*You gained 20 gold!*");
                    Console.ReadLine();
                    gold += 20;
                    companion1.TakeBreakWithShop(ref playerHealth, ref playerBaseDamage, ref playerCoinPower, ref playerCoin,
                      ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower, ref firstCompanionCoin,
                      ref finalCompanionHealth, ref finalCompanionBaseDamage, ref finalCompanionCoinPower, ref finalCompanionCoin, ref gold);
                }

            }

            else
            {
                Console.WriteLine("You left the stranger.");
                Console.ReadLine();
                Console.WriteLine("Stranger: Wait! I think I have a key!");
                Console.ReadLine();
                Console.WriteLine("Ah, good thing I have my skeleton key! I'm free!");
                Console.ReadLine();
                Console.WriteLine("No thanks to both of you!");
                Console.ReadLine();
                Console.WriteLine("*The stranger became sad*");
                Console.ReadLine();
                Console.WriteLine("*Your bonds decreases!*");
                Console.ReadLine();
                companion1.ApplyFinalNegativeBonusEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                     ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower,
                                     ref finalCompanionHealth, ref finalCompanionBaseDamage, ref finalCompanionCoinPower);
                Console.WriteLine(companionName + ": We're sorry for not trying to help you.");
                Console.ReadLine();
                Console.WriteLine("Stranger: You guys can make up for it by buying my wares~");
                Console.ReadLine();
                Console.WriteLine(companionName + ": alright! We'll take a look.");
                Console.ReadLine();
                Console.WriteLine("Stranger: Splendid!");
                Console.ReadLine();
                Console.WriteLine(companionName + ": Here, " + playerName + " You can have this.");
                Console.ReadLine();
                Console.WriteLine("*You gained 20 gold!*");
                Console.ReadLine();
                gold += 20;
                companion1.TakeBreakWithShop(ref playerHealth, ref playerBaseDamage, ref playerCoinPower, ref playerCoin,
                  ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower, ref firstCompanionCoin,
                  ref finalCompanionHealth, ref finalCompanionBaseDamage, ref finalCompanionCoinPower, ref finalCompanionCoin, ref gold);

            }
            Console.Write("You guys can call me: ");
            string companion2Name = Console.ReadLine();
            Console.WriteLine(companionName + ": nice to meet you " + companion2Name);
            Console.ReadLine();
            Console.WriteLine(companionName + ": I'm " + companionName + " and this is my buddy, " + playerName);
            Console.ReadLine();
            Console.WriteLine(companion2Name + ": Nice to meet both of you.");
            Console.ReadLine();
            Console.WriteLine("Rat Brute: Get them!");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Oh no! They're here!");
            Console.ReadLine();
            Console.WriteLine(companionName + ": " + companion2Name + ", can you fight?");
            Console.ReadLine();
            Console.WriteLine(companion2Name + ": Of course I can! Hold let me get my weapon.");
            Console.ReadLine();
            Console.WriteLine(companion2Name + " Took out their stun baton");
            Console.ReadLine();
            Console.WriteLine(companion2Name + ": Let's do this.");
            Console.ReadLine();

            while (playerHealth > 0 && RatBrute4Check != 1 && RatLancer4Check != 1 && RatRogueCheck != 1)
            {

                Console.WriteLine(playerName + " Health: " + playerHealth + " " + companionName + " Health:  " + firstCompanionHealth + " Health: " + finalCompanionHealth + "| Rat Brute's Health: " + "| Rat Brute's Health: " + RatBrute4Health + " Rat Lancer's Health: " + RatLancer4Health);
                Console.WriteLine("What will " + playerName + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string playerAction = Console.ReadLine();

                switch (playerAction)
                {
                    case "1":
                        PeformAttack10(playerName, ref playerHealth, ref playerBaseDamage, playerCoin, playerCoinPower, ref RatBrute4Health, ref RatBrute4BaseDamage);
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
                        PerformAttack11(ref firstCompanionHealth, companionName, "Rat Lancer", ref firstCompanionBaseDamage, ref RatLancer4CoinPower, firstCompanionCoin, firstCompanionCoinPower, ref RatLancer4Health, ref RatLancer4BaseDamage);
                        break;
                    case "2":
                        PerformDefend(companionName, ref firstCompanionBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;
                }

                Console.WriteLine("What will " + companion2Name + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string companion2Action = Console.ReadLine();

                switch (companion2Action)
                {
                    case "1":
                        PerformAttack12(playerName, ref finalCompanionHealth, companion2Name, enemyName2, enemyName3, ref playerBaseDamage, ref finalCompanionBaseDamage, playerCoin, playerCoinPower, finalCompanionCoin, finalCompanionCoinPower, ref RatRogueHealth, ref RatRogueBaseDamage, ref RatRogueCoin, ref RatRogueCoinPower);
                        break;
                    case "2":
                        PerformDefendFFC(companion2Name, ref finalCompanionBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;


                }

                if (RatBrute4Health <= 0)
                {
                    Console.WriteLine(enemyName2 + "Rat Brute: Ghhkk! ");
                    Console.ReadLine();
                    Console.WriteLine("*The Rat Brute suddenly lunges at you*");
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
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "Rat Brute's attack!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "Rat Brute: HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": " + playerName + "! No!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (playerBaseDamage >= 5)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "Rat Brute's attack!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": Now's my chance!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + "Countered Rat Brute's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("Rat Brute: Arghhh!! ");
                        Console.ReadLine();
                        Console.WriteLine("Rat Brute has been defeated...");
                        Console.ReadLine();
                        RatBrute4Check = 1;
                    }
                }

                Console.ReadLine();

                if (RatLancer4Health <= 0)
                {
                    Console.WriteLine(enemyName2 + "Rat Lancer: Ghhkk! ");
                    Console.ReadLine();
                    Console.WriteLine("*The Rat Lancer suddenly lunges at " + companionName + "*");
                    Console.ReadLine();
                    Console.WriteLine("Final Phase: Dodge Check.");
                    Console.WriteLine("Press Enter to Dodge!");
                    Console.ReadLine();

                    Random coinflip = new Random(); // Random Number Generator for coinflips
                    string[] coinflipresults = new string[firstCompanionCoin];
                    string resultString = "";

                    for (int i = 0; i < firstCompanionCoin; i++)
                    {
                        int rndcf = coinflip.Next(0, 2);
                        if (rndcf == 0)
                        {
                            firstCompanionBaseDamage += firstCompanionCoinPower;
                            coinflipresults[i] = "Heads";
                            Console.WriteLine(companionName + "'s Coin Power: " + "+" + firstCompanionCoinPower);
                        }
                        else if (rndcf == 1)
                        {
                            coinflipresults[i] = "Tails";
                            Console.WriteLine(companionName + "'s Coin Power: +0");
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

                    if (firstCompanionBaseDamage < 15)
                    {
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "Rat Lancer's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "Rat Lancer: HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": " + companionName + "! Get up!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (firstCompanionBaseDamage >= 15)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "Rat Lancer's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": Now's my chance!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + "Countered Rat Lancer's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("Rat Lancer: Arghhh!! ");
                        Console.ReadLine();
                        RatLancer4Check = 1;
                    }
                }

                if (RatRogueHealth <= 0)
                {
                    Console.WriteLine(enemyName2 + "Rat Rogue: Aggrhh! ");
                    Console.ReadLine();
                    Console.WriteLine("*The Rat Lancer suddenly lunges at " + companion2Name + "*");
                    Console.ReadLine();
                    Console.WriteLine("Final Phase: Dodge Check.");
                    Console.WriteLine("Press Enter to Dodge!");
                    Console.ReadLine();

                    Random coinflip = new Random(); // Random Number Generator for coinflips
                    string[] coinflipresults = new string[finalCompanionCoin];
                    string resultString = "";

                    for (int i = 0; i < finalCompanionCoin; i++)
                    {
                        int rndcf = coinflip.Next(0, 2);
                        if (rndcf == 0)
                        {
                            finalCompanionBaseDamage += finalCompanionCoinPower;
                            coinflipresults[i] = "Heads";
                            Console.WriteLine(companionName + "'s Coin Power: " + "+" + finalCompanionCoinPower);
                        }
                        else if (rndcf == 1)
                        {
                            coinflipresults[i] = "Tails";
                            Console.WriteLine(companionName + "'s Coin Power: +0");
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
                    Console.WriteLine("Check results for " + companionName + ": " + resultString + "|| Final Count: " + finalCompanionBaseDamage);

                    if (finalCompanionBaseDamage < 20)
                    {
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "Rat Rogue's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companion2Name + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "Rat Lancer: HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": " + companion2Name + "! Get up!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (finalCompanionBaseDamage >= 30)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "Rat Rogue's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companion2Name + ": You're wide open!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + "Countered Rat Rogue's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("Rat Rogue: Arghhh!! ");
                        Console.ReadLine();
                        RatRogueCheck = 1;
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
                Console.WriteLine(companionName + " Fainted!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else if (RatBrute4Check == 1 && RatLancer4Check == 0 && RatRogueCheck == 0)
            {
                Console.WriteLine("Rat Brute has been defeated!");
                Console.ReadLine();
                Console.WriteLine("*Ran Lancer Ran Away!*");
                Console.ReadLine();
                Console.WriteLine("*Ran Rogue Ran Away!*");
                Console.ReadLine();
            }
            else if (RatLancer4Check == 1 && RatBrute4Check == 0 && RatRogueCheck == 0)
            {
                Console.WriteLine("Rat Lancer has been defeated!");
                Console.ReadLine();
                Console.WriteLine("*Rat Brute Ran Away!*");
                Console.ReadLine();
                Console.WriteLine("*Rat Rogue Ran Away!*");
                Console.ReadLine();
            }

            else if (RatBrute4Check == 1 && RatLancer4Check == 1 && RatRogueCheck == 1)
            {
                Console.WriteLine("Both Rat Brute, Rat Lance, and Rat Rogue has been defeated! You are victorious!");
                Console.ReadLine();
            }
            Console.ReadLine();

            Console.WriteLine(companion2Name + ": Piece of cake.");
            Console.ReadLine();
            Console.WriteLine("*You gained 10 gold!*");
            Console.ReadLine();
            gold += 10;
            Console.WriteLine(companionName + ": More incoming!");
            Console.ReadLine();

            while (playerHealth > 0 && RatBrute5Check != 1 && RatLancer5Check != 1 && RatRogue2Check != 1)
            {

                Console.WriteLine(playerName + " Health: " + playerHealth + " " + companionName + " Health:  " + firstCompanionHealth + " Health: " + finalCompanionHealth + " | Rat Brute's Health: " + RatBrute5Health + " Rat Lancer's Health: " + RatLancer5Health);
                Console.WriteLine("What will " + playerName + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string playerAction = Console.ReadLine();

                switch (playerAction)
                {
                    case "1":
                        PeformAttack13(playerName, ref playerHealth, ref playerBaseDamage, playerCoin, playerCoinPower, ref RatBrute5Health, ref RatBrute5BaseDamage);
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
                        PerformAttack14(ref firstCompanionHealth, companionName, "Rat Lancer", ref firstCompanionBaseDamage, ref RatLancer5CoinPower, firstCompanionCoin, firstCompanionCoinPower, ref RatLancer5Health, ref RatLancer5BaseDamage);
                        break;
                    case "2":
                        PerformDefend(companionName, ref firstCompanionBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;
                }

                Console.WriteLine("What will " + companion2Name + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string companion2Action = Console.ReadLine();

                switch (companion2Action)
                {
                    case "1":
                        PerformAttack15(playerName, ref finalCompanionHealth, companion2Name, enemyName2, enemyName3, ref playerBaseDamage, ref finalCompanionBaseDamage, playerCoin, playerCoinPower, finalCompanionCoin, finalCompanionCoinPower, ref RatRogue2Health, ref RatRogue2BaseDamage, ref RatRogue2Coin, ref RatRogue2CoinPower);
                        break;
                    case "2":
                        PerformDefendFFC(companion2Name, ref finalCompanionBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;


                }

                if (RatBrute5Health <= 0)
                {
                    Console.WriteLine(enemyName2 + "Rat Brute: Ghhkk! ");
                    Console.ReadLine();
                    Console.WriteLine("*The Rat Brute suddenly lunges at you*");
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
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "Rat Brute's attack!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "Rat Brute: HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": " + playerName + "! No!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (playerBaseDamage >= 5)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "Rat Brute's attack!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": Now's my chance!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + "Countered Rat Brute's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("Rat Brute: Arghhh!! ");
                        Console.ReadLine();
                        Console.WriteLine("Rat Brute has been defeated...");
                        Console.ReadLine();
                        RatBrute5Check = 1;
                    }
                }

                Console.ReadLine();

                if (RatLancer5Health <= 0)
                {
                    Console.WriteLine(enemyName2 + "Rat Lancer: Ghhkk! ");
                    Console.ReadLine();
                    Console.WriteLine("*The Rat Lancer suddenly lunges at " + companionName + "*");
                    Console.ReadLine();
                    Console.WriteLine("Final Phase: Dodge Check.");
                    Console.WriteLine("Press Enter to Dodge!");
                    Console.ReadLine();

                    Random coinflip = new Random(); // Random Number Generator for coinflips
                    string[] coinflipresults = new string[firstCompanionCoin];
                    string resultString = "";

                    for (int i = 0; i < firstCompanionCoin; i++)
                    {
                        int rndcf = coinflip.Next(0, 2);
                        if (rndcf == 0)
                        {
                            firstCompanionBaseDamage += firstCompanionCoinPower;
                            coinflipresults[i] = "Heads";
                            Console.WriteLine(companionName + "'s Coin Power: " + "+" + firstCompanionCoinPower);
                        }
                        else if (rndcf == 1)
                        {
                            coinflipresults[i] = "Tails";
                            Console.WriteLine(companionName + "'s Coin Power: +0");
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

                    if (firstCompanionBaseDamage < 15)
                    {
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "Rat Lancer's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "Rat Lancer: HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": " + companionName + "! Get up!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (firstCompanionBaseDamage >= 15)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "Rat Lancer's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": Now's my chance!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + "Countered Rat Lancer's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("Rat Lancer: Arghhh!! ");
                        Console.ReadLine();
                        RatLancer5Check = 1;
                    }
                }

                if (RatRogue2Health <= 0)
                {
                    Console.WriteLine(enemyName2 + "Rat Rogue: Aggrhh! ");
                    Console.ReadLine();
                    Console.WriteLine("*The Rat Lancer suddenly lunges at " + companion2Name + "*");
                    Console.ReadLine();
                    Console.WriteLine("Final Phase: Dodge Check.");
                    Console.WriteLine("Press Enter to Dodge!");
                    Console.ReadLine();

                    Random coinflip = new Random(); // Random Number Generator for coinflips
                    string[] coinflipresults = new string[finalCompanionCoin];
                    string resultString = "";

                    for (int i = 0; i < finalCompanionCoin; i++)
                    {
                        int rndcf = coinflip.Next(0, 2);
                        if (rndcf == 0)
                        {
                            finalCompanionBaseDamage += finalCompanionCoinPower;
                            coinflipresults[i] = "Heads";
                            Console.WriteLine(companionName + "'s Coin Power: " + "+" + finalCompanionCoinPower);
                        }
                        else if (rndcf == 1)
                        {
                            coinflipresults[i] = "Tails";
                            Console.WriteLine(companionName + "'s Coin Power: +0");
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
                    Console.WriteLine("Check results for " + companionName + ": " + resultString + "|| Final Count: " + finalCompanionBaseDamage);

                    if (finalCompanionBaseDamage < 20)
                    {
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "Rat Rogue's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companion2Name + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "Rat Lancer: HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": " + companion2Name + "! Get up!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (finalCompanionBaseDamage >= 30)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "Rat Rogue's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companion2Name + ": You're wide open!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + "Countered Rat Rogue's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("Rat Rogue: Arghhh!! ");
                        Console.ReadLine();
                        RatRogue2Check = 1;
                    }
                }




            }
            if (playerHealth <= 0)
            {
                Console.WriteLine("You have been defeated!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else if (firstCompanionHealth <= 0)
            {
                Console.WriteLine(companionName + " Fainted!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else if (finalCompanionHealth <= 0)
            {
                Console.WriteLine(companion2Name + " Fainted!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else if (RatBrute5Check == 1 && RatLancer5Check == 0 && RatRogue2Check == 0)
            {
                Console.WriteLine("Rat Brute has been defeated!");
                Console.ReadLine();
                Console.WriteLine("*Ran Lancer Ran Away!*");
                Console.ReadLine();
                Console.WriteLine("*Ran Rogue Ran Away!*");
                Console.ReadLine();
            }
            else if (RatLancer5Check == 1 && RatBrute5Check == 0 && RatRogue2Check == 0)
            {
                Console.WriteLine("Rat Lancer has been defeated!");
                Console.ReadLine();
                Console.WriteLine("*Rat Brute Ran Away!*");
                Console.ReadLine();
                Console.WriteLine("*Rat Rogue Ran Away!*");
                Console.ReadLine();
            }

            else if (RatBrute5Check == 1 && RatLancer5Check == 1 && RatRogue2Check == 1)
            {
                Console.WriteLine("Both Rat Brute, Rat Lance, and Rat Rogue has been defeated! You are victorious!");
                Console.ReadLine();
            }
            Console.ReadLine();

            Console.WriteLine(companion2Name + ": Piece of cake.");
            Console.ReadLine();
            Console.WriteLine("*You gained 10 gold!*");
            Console.ReadLine();
            gold += 10;
            Console.WriteLine(companion2Name + ": Nicely done, both of you!");
            Console.ReadLine();
            Console.WriteLine(companionName + ": We need to find their boss.");
            Console.ReadLine();
            Console.WriteLine(companion2Name + ": He's right behind that door");
            Console.ReadLine();
            Console.WriteLine(companion2Name + ": Let's prepare for the worst. ");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Agreed");
            Console.ReadLine();
            companion1.TakeBreakWithShop(ref playerHealth, ref playerBaseDamage, ref playerCoinPower, ref playerCoin,
                  ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower, ref firstCompanionCoin,
                  ref finalCompanionHealth, ref finalCompanionBaseDamage, ref finalCompanionCoinPower, ref finalCompanionCoin, ref gold);
            Console.ReadLine();
            Console.WriteLine(companionName + ": Alright! We're all prepared, Let's fight him!");
            Console.ReadLine();
            Console.WriteLine("Your bonds increases!");
            Console.ReadLine();
            Console.WriteLine(playerName + ", " + companionName + ", and " + companion2Name + " Increased + 20 Health, + 2 damage, and + 1 coin power!");
            Console.ReadLine();
            companion1.ApplyFinalBonusEffect(ref playerHealth, ref playerBaseDamage, ref playerCoinPower,
                                     ref firstCompanionHealth, ref firstCompanionBaseDamage, ref firstCompanionCoinPower,
                                     ref finalCompanionHealth, ref finalCompanionBaseDamage, ref finalCompanionCoinPower);
            Console.ReadLine();
            Console.WriteLine("*You and your team enters the room*");
            Console.ReadLine();
            Console.WriteLine("???: Ah, all of you finally came.");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Who are you?");
            Console.ReadLine();
            Console.WriteLine("??? You welps can call me...");
            Console.ReadLine();
            Console.WriteLine("???: The Boss");
            Console.ReadLine();
            Console.WriteLine(companionName + ": That's it? That's your name?");
            Console.ReadLine();
            Console.WriteLine("The Boss: Ya got a problem? ");
            Console.ReadLine();
            Console.WriteLine(companionName + ": Nothing. Let's just fight.");
            Console.ReadLine();
            Console.WriteLine("FINAL BOSS!");
            Console.ReadLine();

            while (playerHealth > 0 && FinalBossCheck != 1)
            {
                Console.WriteLine("The Boss focuses at " + playerName);
                Console.WriteLine(playerName + " Health: " + playerHealth + " " + companionName + " Health:  " + firstCompanionHealth + " Health: " + finalCompanionHealth + "| The Boss's Health: " + FinalBossHealth);
                Console.WriteLine("What will " + playerName + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string playerAction = Console.ReadLine();

                switch (playerAction)
                {
                    case "1":
                        PeformAttack16( playerName, ref playerHealth, ref playerBaseDamage, playerCoin, playerCoinPower, ref FinalBossHealth, ref FinalBossBaseDamage);
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
                        PerformAttack17(ref firstCompanionHealth, companionName, "FinalBoss", ref firstCompanionBaseDamage, ref FinalBossCoinPower, firstCompanionCoin, firstCompanionCoinPower, ref FinalBossHealth, ref FinalBossBaseDamage);
                        break;
                    case "2":
                        PerformDefend(companionName, ref firstCompanionBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;
                }

                Console.WriteLine("What will " + companion2Name + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string companion2Action = Console.ReadLine();

                switch (companion2Action)
                {
                    case "1":
                        PerformAttack18( playerName, ref finalCompanionHealth, companion2Name, enemyName2, enemyName3, ref playerBaseDamage, ref finalCompanionBaseDamage, playerCoin, playerCoinPower, finalCompanionCoin, finalCompanionCoinPower, ref FinalBossHealth, ref FinalBossBaseDamage, ref FinalBossCoin, ref FinalBossCoinPower);
                        break;
                    case "2":
                        PerformDefendFFC(companion2Name, ref finalCompanionBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;


                }
                if (FinalBossHealth <= 0)
                {
                    Console.WriteLine(enemyName2 + "The Boss: Barely a scratch! ");
                    Console.ReadLine();
                    Console.WriteLine("*The Boss suddenly lunges at you*");
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

                    if (playerBaseDamage < 50)
                    {
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "The Boss's attack!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "The Boss: HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": " + playerName + "! No!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (playerBaseDamage >= 50)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "The Boss's attack!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": Now's my chance!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + "Countered The Boss's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("The Boss: Arghhh!! ");
                        Console.ReadLine();
                        FinalBossCheck = 1;
                    }

                    if (playerHealth <= 0)
                    {
                        Console.WriteLine("You have been defeated!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    else if (firstCompanionHealth <= 0)
                    {
                        Console.WriteLine(companionName + " Fainted!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    else if (finalCompanionHealth <= 0)
                    {
                        Console.WriteLine(companion2Name + " Fainted!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    else if (FinalBossCheck == 1 )
                    {
                        Console.WriteLine("The Boss: You are making me angry!");
                        Console.ReadLine();
                     
                    }
                    
                }

            }

            while (playerHealth > 0 && FinalBoss2Check != 1)
            {
                Console.WriteLine("The Boss focuses at " + companionName);
                Console.WriteLine(playerName + " Health: " + playerHealth + " " + companionName + " Health:  " + firstCompanionHealth + " Health: " + finalCompanionHealth + "| The Boss's Health: " + FinalBoss2Health);
                Console.WriteLine("What will " + playerName + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string playerAction = Console.ReadLine();

                switch (playerAction)
                {
                    case "1":
                        PeformAttack19( playerName, ref playerHealth, ref playerBaseDamage, playerCoin, playerCoinPower, ref FinalBoss2Health, ref FinalBossBaseDamage);
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
                        PerformAttack20(ref firstCompanionHealth, companionName, "FinalBoss", ref firstCompanionBaseDamage, ref FinalBossCoinPower, firstCompanionCoin, firstCompanionCoinPower, ref FinalBoss2Health, ref FinalBossBaseDamage);
                        break;
                    case "2":
                        PerformDefend(companionName, ref firstCompanionBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;
                }

                Console.WriteLine("What will " + companion2Name + " do?");
                Console.ReadLine();

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                string companion2Action = Console.ReadLine();

                switch (companion2Action)
                {
                    case "1":
                        PerformAttack21( playerName, ref finalCompanionHealth,  companion2Name, enemyName2,  enemyName3, ref playerBaseDamage, ref finalCompanionBaseDamage, playerCoin, playerCoinPower, finalCompanionCoin, finalCompanionCoinPower, ref FinalBoss2Health, ref FinalBossBaseDamage, ref FinalBossCoin, ref FinalBossCoinPower);
                        break;
                    case "2":
                        PerformDefendFFC(companion2Name, ref finalCompanionBaseDamage);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. You stumble...");
                        break;


                }
                if (FinalBoss2Health <= 0)
                {
                    Console.WriteLine(enemyName2 + "The Boss: Ghhkk! ");
                    Console.ReadLine();
                    Console.WriteLine("*The Boss suddenly lunges at " + companionName + "*");
                    Console.ReadLine();
                    Console.WriteLine("Final Phase: Dodge Check.");
                    Console.WriteLine("Press Enter to Dodge!");
                    Console.ReadLine();

                    Random coinflip = new Random(); // Random Number Generator for coinflips
                    string[] coinflipresults = new string[firstCompanionCoin];
                    string resultString = "";

                    for (int i = 0; i < firstCompanionCoin; i++)
                    {
                        int rndcf = coinflip.Next(0, 2);
                        if (rndcf == 0)
                        {
                            firstCompanionBaseDamage += firstCompanionCoinPower;
                            coinflipresults[i] = "Heads";
                            Console.WriteLine(companionName + "'s Coin Power: " + "+" + firstCompanionCoinPower);
                        }
                        else if (rndcf == 1)
                        {
                            coinflipresults[i] = "Tails";
                            Console.WriteLine(companionName + "'s Coin Power: +0");
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

                    if (firstCompanionBaseDamage < 55)
                    {
                        Console.WriteLine("You failed to dodge! " + enemyName2 + "The Boss's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": Ngh!");
                        Console.ReadLine();
                        Console.WriteLine(enemyName2 + "The Boss: HA! That's what ya get!");
                        Console.ReadLine();
                        Console.WriteLine(playerName + ": " + companionName + "! Get up!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (firstCompanionBaseDamage >= 55)
                    {
                        Console.WriteLine("You dodged " + enemyName2 + "The Boss's attack!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + ": Now's my chance!");
                        Console.ReadLine();
                        Console.WriteLine(companionName + " Countered The Boss's Attack!");
                        Console.ReadLine();
                        Console.WriteLine("The Boss: Arghhh!! ");
                        Console.ReadLine();
                        FinalBoss2Check = 1;
                    }
                }

                    if (playerHealth <= 0)
                    {
                        Console.WriteLine("You have been defeated!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    else if (firstCompanionHealth <= 0)
                    {
                        Console.WriteLine(companionName + " Fainted!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    else if (finalCompanionHealth <= 0)
                    {
                        Console.WriteLine(companion2Name + " Fainted!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    else if (FinalBoss2Check == 1)
                    {
                        Console.WriteLine("The Boss: Aaarrghhh!");
                        Console.ReadLine();

                    }

                }
            Console.WriteLine("You have finished the game! Thank you for playing!");
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

            static void PerformAttack(string playerName, ref int playerHealth, ref int playerBaseDamage, int playerCoin, int playerCoinPower, ref int enemyHealth, ref int enemyBaseDamage)
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

            static void PerformAttack2(string playerName, ref int playerHealth, string companionName, string enemyName2, string enemyName3, ref int playerBaseDamage, ref int firstCompanionBaseDamage, int playerCoin, int playerCoinPower, int firstCompanionCoin, int firstCompanionCoinPower, ref int enemy2Health, ref int enemy3Health, ref int enemy2BaseDamage, ref int enemy3BaseDamage, ref int enemyBaseDamage)

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

                // BLEEEEEDDDDDD 
                int bleedStacks = coinflip.Next(1, 11);
                enemy3Health -= bleedStacks;

                for (int j = 0; j < firstCompanionCoin; j++)
                {
                    int rng = coinflip.Next(0, 3);
                    if (rng == 0)
                    {
                        totalCompanionDamage += firstCompanionCoinPower;
                        Console.WriteLine(companionName + "'s Coin Power: " + "+ " + firstCompanionCoinPower);

                        totalEnemy3Damage += firstCompanionCoinPower;

                        // BLEEEEEEEDDDD stacks
                        enemy3Health -= bleedStacks;
                        Console.WriteLine(enemyName3 + "Lenny received " + bleedStacks + " Bleed stacks!");
                        Console.WriteLine(enemyName3 + "Lenny Bleed stacks: " + bleedStacks);
                    }
                    else if (rng == 1)
                    {
                        Console.WriteLine(companionName + "'s Coin Power: +0");
                        Console.WriteLine(enemyName3 + "Lenny's Coin Power +0");
                    }
                }


                if (bleedStacks > 0)
                {
                    Console.WriteLine(enemyName3 + "Lenny is bleeding!");
                    int bleedDamage = bleedStacks;
                    enemy3Health -= bleedDamage;
                    Console.WriteLine(enemyName3 + "Lenny takes " + bleedDamage + " damage from bleed!");
                    bleedStacks--;
                }

                Console.WriteLine("Total damage dealt by " + companionName + ": " + totalCompanionDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalEnemy3Damage);

                enemy3Health -= totalCompanionDamage;

                firstCompanionHealth -= totalEnemy3Damage;

                Console.WriteLine("Remaining enemy health: " + enemy3Health);
            }



            static void PerformAttack4(string playerName, ref int playerHealth, ref int playerBaseDamage, ref int firstCompanionBaseDamage, int playerCoin, int playerCoinPower, int firstCompanionCoin, int firstCompanionCoinPower, ref int RatBruteHealth, ref int RatBruteBaseDamage)

            {
                Console.WriteLine(playerName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalPlayerDamage = playerBaseDamage;
                int totalRatBruteDamage = RatBruteBaseDamage;

                for (int i = 0; i < playerCoin; i++)
                {
                    int rndcf = coinflip.Next(0, 2);
                    if (rndcf == 0)
                    {
                        totalPlayerDamage += playerCoinPower;
                        Console.WriteLine(playerName + "'s Coin Power: " + "+ " + playerCoinPower);

                        totalRatBruteDamage += playerCoinPower; // Update this line if you want to use a different value for enemyCoinPower
                        Console.WriteLine("Enemy's Coin Power: " + "+ " + playerCoinPower);
                    }
                    else if (rndcf == 1) //tails
                    {
                        Console.WriteLine(playerName + "'s Coin Power: +0");
                        Console.WriteLine("Enemy's Coin Power +0");
                    }
                }

                Console.WriteLine("Total damage dealt by " + playerName + ": " + totalPlayerDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatBruteDamage);

                RatBruteHealth -= totalPlayerDamage;

                playerHealth -= totalRatBruteDamage;

                Console.WriteLine("Remaining enemy health: " + RatBruteHealth);

            }

            static void PerformAttack5(ref int firstCompanionHealth, string companionName, string RatLancer2, ref int firstCompanionBaseDamage, ref int RatLancerCoinPower, int firstCompanionCoin, int firstCompanionCoinPower, ref int RatLancerHealth, ref int RatLancerBaseDamage)

            {
                Console.WriteLine(companionName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalCompanionDamage = firstCompanionBaseDamage;
                int totalRatLancerDamage = RatLancerBaseDamage;

                int bleedStacks = coinflip.Next(1, 11);
                RatLancerHealth -= bleedStacks;

                for (int j = 0; j < firstCompanionCoin; j++)
                {
                    int rng = coinflip.Next(0, 3);
                    if (rng == 0)
                    {
                        totalCompanionDamage += firstCompanionCoinPower;
                        Console.WriteLine(companionName + "'s Coin Power: " + "+ " + firstCompanionCoinPower);

                        totalRatLancerDamage += firstCompanionCoinPower;
                        Console.WriteLine("RatLancer's Coin Power: " + "+ " + RatLancerCoinPower);

                        RatLancerHealth -= bleedStacks;
                        Console.WriteLine(RatLancerHealth + "Lenny received " + bleedStacks + " Bleed stacks!");
                        Console.WriteLine(RatLancerHealth + "Lenny Bleed stacks: " + bleedStacks);
                    }
                    else if (rng == 1)
                    {
                        Console.WriteLine(companionName + "'s Coin Power: +0");
                        Console.WriteLine("RatLancer's Coin Power +0");
                    }
                }

                if (bleedStacks > 0)
                {
                    Console.WriteLine("Rat Lancer is bleeding!");
                    int bleedDamage = bleedStacks;
                    RatLancerHealth -= bleedDamage;
                    Console.WriteLine("Rat Lancer takes " + bleedDamage + " damage from bleed!");
                    bleedStacks--;
                }

                Console.WriteLine("Total damage dealt by " + companionName + ": " + totalCompanionDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatLancerDamage);

                RatLancerHealth -= totalCompanionDamage;

                firstCompanionHealth -= totalRatLancerDamage;

                Console.WriteLine("Remaining enemy health: " + RatLancerHealth);
            }

            static void PeformAttack6(string playerName, ref int playerHealth, ref int playerBaseDamage, int playerCoin, int playerCoinPower, ref int RatBrute2Health, ref int RatBrute2BaseDamage)
            {
                Console.WriteLine(playerName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalPlayerDamage = playerBaseDamage;
                int totalRatBruteDamage = RatBrute2BaseDamage;

                for (int i = 0; i < playerCoin; i++)
                {
                    int rndcf = coinflip.Next(0, 2);
                    if (rndcf == 0)
                    {
                        totalPlayerDamage += playerCoinPower;
                        Console.WriteLine(playerName + "'s Coin Power: " + "+ " + playerCoinPower);

                        totalRatBruteDamage += playerCoinPower; // Update this line if you want to use a different value for enemyCoinPower
                        Console.WriteLine("Enemy's Coin Power: " + "+ " + playerCoinPower);
                    }
                    else if (rndcf == 1) //tails
                    {
                        Console.WriteLine(playerName + "'s Coin Power: +0");
                        Console.WriteLine("Enemy's Coin Power +0");
                    }
                }

                Console.WriteLine("Total damage dealt by " + playerName + ": " + totalPlayerDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatBruteDamage);

                RatBrute2Health -= totalPlayerDamage;

                playerHealth -= totalRatBruteDamage;

                Console.WriteLine("Remaining enemy health: " + RatBrute2Health);
            }

            static void PerformAttack7(string playerName, ref int firstCompanionHealth, string companionName, string RatLancer2, string enemyName3, ref int RatLancer2BaseDamage, ref int firstCompanionBaseDamage, int playerCoin, int playerCoinPower, int firstCompanionCoin, int firstCompanionCoinPower, ref int RatLancer2Health)
            {
                Console.WriteLine(companionName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalCompanionDamage = firstCompanionBaseDamage;
                int totalEnemy3Damage = RatLancer2BaseDamage;

                // BLEEEEEDDDDDD 
                int bleedStacks = coinflip.Next(1, 11);
                RatLancer2Health -= bleedStacks;

                for (int j = 0; j < firstCompanionCoin; j++)
                {
                    int rng = coinflip.Next(0, 3);
                    if (rng == 0)
                    {
                        totalCompanionDamage += firstCompanionCoinPower;
                        Console.WriteLine(companionName + "'s Coin Power: " + "+ " + firstCompanionCoinPower);

                        totalEnemy3Damage += firstCompanionCoinPower;

                        // BLEEEEEEEDDDD stacks
                        RatLancer2Health -= bleedStacks;
                        Console.WriteLine(enemyName3 + "Rat Lancer received " + bleedStacks + " Bleed stacks!");
                        Console.WriteLine(enemyName3 + "Rat Lancer Bleed stacks: " + bleedStacks);
                    }
                    else if (rng == 1)
                    {
                        Console.WriteLine(companionName + "'s Coin Power: +0");
                        Console.WriteLine(enemyName3 + "Lenny's Coin Power +0");
                    }
                }


                if (bleedStacks > 0)
                {
                    Console.WriteLine(enemyName3 + "Lenny is bleeding!");
                    int bleedDamage = bleedStacks;
                    RatLancer2Health -= bleedDamage;
                    Console.WriteLine(enemyName3 + "Lenny takes " + bleedDamage + " damage from bleed!");
                    bleedStacks--;
                }

                Console.WriteLine("Total damage dealt by " + companionName + ": " + totalCompanionDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalEnemy3Damage);

                RatLancer2Health -= totalCompanionDamage;

                firstCompanionHealth -= totalEnemy3Damage;

                Console.WriteLine("Remaining enemy health: " + RatLancer2Health);
            }

            static void PeformAttack8(string playerName, ref int playerHealth, ref int playerBaseDamage, int playerCoin, int playerCoinPower, ref int RatBrute3Health, ref int RatBrute3BaseDamage)
            {
                Console.WriteLine(playerName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalPlayerDamage = playerBaseDamage;
                int totalRatBruteDamage = RatBrute3BaseDamage;

                for (int i = 0; i < playerCoin; i++)
                {
                    int rndcf = coinflip.Next(0, 2);
                    if (rndcf == 0)
                    {
                        totalPlayerDamage += playerCoinPower;
                        Console.WriteLine(playerName + "'s Coin Power: " + "+ " + playerCoinPower);

                        totalRatBruteDamage += playerCoinPower; // Update this line if you want to use a different value for enemyCoinPower
                        Console.WriteLine("Enemy's Coin Power: " + "+ " + playerCoinPower);


                    }
                    else if (rndcf == 1) //tails
                    {
                        Console.WriteLine(playerName + "'s Coin Power: +0");
                        Console.WriteLine("Enemy's Coin Power +0");
                    }
                }

                Console.WriteLine("Total damage dealt by " + playerName + ": " + totalPlayerDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatBruteDamage);

                RatBrute3Health -= totalPlayerDamage;

                playerHealth -= totalRatBruteDamage;

                Console.WriteLine("Remaining enemy health: " + RatBrute3Health);
            }

            static void PerformAttack9(ref int firstCompanionHealth, string companionName, string RatLancer3, ref int firstCompanionBaseDamage, ref int RatLancer3CoinPower, int firstCompanionCoin, int firstCompanionCoinPower, ref int RatLancer3Health, ref int RatLancer3BaseDamage)

            {
                Console.WriteLine(companionName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalCompanionDamage = firstCompanionBaseDamage;
                int totalRatLancerDamage = RatLancer3BaseDamage;

                int bleedStacks = coinflip.Next(1, 11);
                RatLancer3Health -= bleedStacks;

                for (int j = 0; j < firstCompanionCoin; j++)
                {
                    int rng = coinflip.Next(0, 3);
                    if (rng == 0)
                    {
                        totalCompanionDamage += firstCompanionCoinPower;
                        Console.WriteLine(companionName + "'s Coin Power: " + "+ " + firstCompanionCoinPower);

                        totalRatLancerDamage += firstCompanionCoinPower;
                        Console.WriteLine("Rat Lancer's Coin Power: " + "+ " + RatLancer3CoinPower);

                        RatLancer3Health -= bleedStacks;
                        Console.WriteLine("Rat Lancer received " + bleedStacks + " Bleed stacks!");
                        Console.WriteLine("Rat Lancer Bleed stacks: " + bleedStacks);
                    }
                    else if (rng == 1)
                    {
                        Console.WriteLine(companionName + "'s Coin Power: +0");
                        Console.WriteLine("Rat Lancer's Coin Power +0");
                    }
                }

                if (bleedStacks > 0)
                {
                    Console.WriteLine("Rat Lancer is bleeding!");
                    int bleedDamage = bleedStacks;
                    RatLancer3Health -= bleedDamage;
                    Console.WriteLine("Rat Lancer takes " + bleedDamage + " damage from bleed!");
                    bleedStacks--;
                }
                Console.WriteLine("Total damage dealt by " + companionName + ": " + totalCompanionDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatLancerDamage);

                RatLancer3Health -= totalCompanionDamage;

                firstCompanionHealth -= totalRatLancerDamage;

                Console.WriteLine("Remaining enemy health: " + RatLancer3Health);
            }

            static void PeformAttack10(string playerName, ref int playerHealth, ref int playerBaseDamage, int playerCoin, int playerCoinPower, ref int RatBrute4Health, ref int RatBrute4BaseDamage)
            {
                Console.WriteLine(playerName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalPlayerDamage = playerBaseDamage;
                int totalRatBruteDamage = RatBrute4BaseDamage;

                for (int i = 0; i < playerCoin; i++)
                {
                    int rndcf = coinflip.Next(0, 2);
                    if (rndcf == 0)
                    {
                        totalPlayerDamage += playerCoinPower;
                        Console.WriteLine(playerName + "'s Coin Power: " + "+ " + playerCoinPower);

                        totalRatBruteDamage += playerCoinPower; // Update this line if you want to use a different value for enemyCoinPower
                        Console.WriteLine("Enemy's Coin Power: " + "+ " + playerCoinPower);
                    }
                    else if (rndcf == 1) //tails
                    {
                        Console.WriteLine(playerName + "'s Coin Power: +0");
                        Console.WriteLine("Enemy's Coin Power +0");
                    }
                }

                Console.WriteLine("Total damage dealt by " + playerName + ": " + totalPlayerDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatBruteDamage);

                RatBrute4Health -= totalPlayerDamage;

                playerHealth -= totalRatBruteDamage;

                Console.WriteLine("Remaining enemy health: " + RatBrute4Health);
            }

            static void PerformAttack11(ref int firstCompanionHealth, string companionName, string RatLancer4, ref int firstCompanionBaseDamage, ref int RatLancer4CoinPower, int firstCompanionCoin, int firstCompanionCoinPower, ref int RatLancer4Health, ref int RatLancer4BaseDamage)

            {
                Console.WriteLine(companionName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalCompanionDamage = firstCompanionBaseDamage;
                int totalRatLancerDamage = RatLancer4BaseDamage;

                int bleedStacks = coinflip.Next(1, 11);
                RatLancer4Health -= bleedStacks;

                for (int j = 0; j < firstCompanionCoin; j++)
                {
                    int rng = coinflip.Next(0, 3);
                    if (rng == 0)
                    {
                        totalCompanionDamage += firstCompanionCoinPower;
                        Console.WriteLine(companionName + "'s Coin Power: " + "+ " + firstCompanionCoinPower);

                        totalRatLancerDamage += firstCompanionCoinPower;
                        Console.WriteLine("Rat Lancer's Coin Power: " + "+ " + RatLancer4CoinPower);

                        RatLancer4Health -= bleedStacks;
                        Console.WriteLine("Rat Lancer received " + bleedStacks + " Bleed stacks!");
                        Console.WriteLine("Rat Lancer Bleed stacks: " + bleedStacks);
                    }
                    else if (rng == 1)
                    {
                        Console.WriteLine(companionName + "'s Coin Power: +0");
                        Console.WriteLine("Rat Lancer's Coin Power +0");
                    }
                }

                if (bleedStacks > 0)
                {
                    Console.WriteLine("Rat Lancer is bleeding!");
                    int bleedDamage = bleedStacks;
                    RatLancer4Health -= bleedDamage;
                    Console.WriteLine("Rat Lancer takes " + bleedDamage + " damage from bleed!");
                    bleedStacks--;
                }

                Console.WriteLine("Total damage dealt by " + companionName + ": " + totalCompanionDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatLancerDamage);

                RatLancer4Health -= totalCompanionDamage;

                firstCompanionHealth -= totalRatLancerDamage;

                Console.WriteLine("Remaining enemy health: " + RatLancer4Health);
            }

            static void PerformAttack12(string playerName, ref int finalCompanionHealth, string companion2Name, string enemyName2, string enemyName3, ref int playerBaseDamage, ref int finalCompanionBaseDamage, int playerCoin, int playerCoinPower, int finalCompanionCoin, int finalCompanionCoinPower, ref int RatRogueHealth, ref int RatRogueBaseDamage, ref int RatRogueCoin, ref int RatRogueCoinPower)
            {
                Console.WriteLine(companion2Name + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalCompanionDamage = finalCompanionBaseDamage;
                int totalRatRogueDamage = RatRogueBaseDamage;

                // Paralyze effect
                bool isParalyzed = false;
                int paralyzeStacks = 0;

                // Check if the enemy is paralyzed
                if (isParalyzed)
                {
                    Console.WriteLine(enemyName3 + " is PARALYZED! Coins and Coin Power reduced!");
                    RatRogueBaseDamage -= paralyzeStacks;
                    RatRogueBaseDamage -= paralyzeStacks;
                    RatRogueCoin -= paralyzeStacks;
                    RatRogueCoinPower -= paralyzeStacks;
                }

                // Apply paralyze effect
                int paralyzeChance = coinflip.Next(0, 2);
                if (paralyzeChance == 0)
                {
                    Console.WriteLine(companion2Name + "'s attack PARALYZES " + "Rat Rogue" + "!");
                    isParalyzed = true;
                    paralyzeStacks++;
                }
                else
                {
                    Console.WriteLine(companion2Name + "'s attack does not paralyze " + "Rat Rogue" + ".");
                    isParalyzed = false;
                }

                for (int j = 0; j < finalCompanionCoin; j++)
                {
                    int rng = coinflip.Next(0, 3);
                    if (rng == 0)
                    {
                        totalCompanionDamage += finalCompanionCoinPower;
                        Console.WriteLine(companion2Name + "'s Coin Power: " + "+ " + finalCompanionCoinPower);

                        totalRatRogueDamage += finalCompanionCoinPower;
                        Console.WriteLine(enemyName3 + "'s Coin Power: " + "+ " + finalCompanionCoinPower);
                    }
                    else if (rng == 1)
                    {
                        Console.WriteLine(companion2Name + "'s Coin Power: +0");
                        Console.WriteLine(enemyName3 + "'s Coin Power +0");
                    }
                }

                Console.WriteLine("Total damage dealt by " + companion2Name + ": " + totalCompanionDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatRogueDamage);

                RatRogueHealth -= totalCompanionDamage;
                finalCompanionHealth -= totalRatRogueDamage;

                Console.WriteLine("Remaining enemy health: " + RatRogueHealth);
            }

            static void PeformAttack13(string playerName, ref int playerHealth, ref int playerBaseDamage, int playerCoin, int playerCoinPower, ref int RatBrute5Health, ref int RatBrute5BaseDamage)
            {
                Console.WriteLine(playerName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalPlayerDamage = playerBaseDamage;
                int totalRatBruteDamage = RatBrute5BaseDamage;

                for (int i = 0; i < playerCoin; i++)
                {
                    int rndcf = coinflip.Next(0, 2);
                    if (rndcf == 0)
                    {
                        totalPlayerDamage += playerCoinPower;
                        Console.WriteLine(playerName + "'s Coin Power: " + "+ " + playerCoinPower);

                        totalRatBruteDamage += playerCoinPower; // Update this line if you want to use a different value for enemyCoinPower
                        Console.WriteLine("Enemy's Coin Power: " + "+ " + playerCoinPower);
                    }
                    else if (rndcf == 1) //tails
                    {
                        Console.WriteLine(playerName + "'s Coin Power: +0");
                        Console.WriteLine("Enemy's Coin Power +0");
                    }
                }

                Console.WriteLine("Total damage dealt by " + playerName + ": " + totalPlayerDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatBruteDamage);

                RatBrute5Health -= totalPlayerDamage;

                playerHealth -= totalRatBruteDamage;

                Console.WriteLine("Remaining enemy health: " + RatBrute5Health);
            }

            static void PerformAttack14(ref int firstCompanionHealth, string companionName, string RatLancer5, ref int firstCompanionBaseDamage, ref int RatLancer5CoinPower, int firstCompanionCoin, int firstCompanionCoinPower, ref int RatLancer5Health, ref int RatLancer5BaseDamage)

            {
                Console.WriteLine(companionName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalCompanionDamage = firstCompanionBaseDamage;
                int totalRatLancerDamage = RatLancer5BaseDamage;

                int bleedStacks = coinflip.Next(1, 11);
                RatLancer5Health -= bleedStacks;

                for (int j = 0; j < firstCompanionCoin; j++)
                {
                    int rng = coinflip.Next(0, 3);
                    if (rng == 0)
                    {
                        totalCompanionDamage += firstCompanionCoinPower;
                        Console.WriteLine(companionName + "'s Coin Power: " + "+ " + firstCompanionCoinPower);

                        totalRatLancerDamage += firstCompanionCoinPower;
                        Console.WriteLine("Rat Lancer's Coin Power: " + "+ " + RatLancer5CoinPower);

                        RatLancer5Health -= bleedStacks;
                        Console.WriteLine("Rat Lancer received " + bleedStacks + " Bleed stacks!");
                        Console.WriteLine("Rat Lancer Bleed stacks: " + bleedStacks);
                    }
                    else if (rng == 1)
                    {
                        Console.WriteLine(companionName + "'s Coin Power: +0");
                        Console.WriteLine("Rat Lancer's Coin Power +0");
                    }
                }

                if (bleedStacks > 0)
                {
                    Console.WriteLine("Rat Lancer is bleeding!");
                    int bleedDamage = bleedStacks;
                    RatLancer5Health -= bleedDamage;
                    Console.WriteLine("Rat Lancer takes " + bleedDamage + " damage from bleed!");
                    bleedStacks--;
                }

                Console.WriteLine("Total damage dealt by " + companionName + ": " + totalCompanionDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatLancerDamage);

                RatLancer5Health -= totalCompanionDamage;

                firstCompanionHealth -= totalRatLancerDamage;

                Console.WriteLine("Remaining enemy health: " + RatLancer5Health);
            }

            static void PerformAttack15(string playerName, ref int finalCompanionHealth, string companion2Name, string enemyName2, string enemyName3, ref int playerBaseDamage, ref int finalCompanionBaseDamage, int playerCoin, int playerCoinPower, int finalCompanionCoin, int finalCompanionCoinPower, ref int RatRogue2Health, ref int RatRogue2BaseDamage, ref int RatRogue2Coin, ref int RatRogue2CoinPower)
            {
                Console.WriteLine(companion2Name + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalCompanionDamage = finalCompanionBaseDamage;
                int totalRatRogueDamage = RatRogue2BaseDamage;

                // Paralyze effect
                bool isParalyzed = false;
                int paralyzeStacks = 0;

                // Check if the enemy is paralyzed
                if (isParalyzed)
                {
                    Console.WriteLine(enemyName3 + " is PARALYZED! Coins and Coin Power reduced!");
                    RatRogue2BaseDamage -= paralyzeStacks;
                    RatRogue2BaseDamage -= paralyzeStacks;
                    RatRogue2Coin -= paralyzeStacks;
                    RatRogue2CoinPower -= paralyzeStacks;
                }

                // Apply paralyze effect
                int paralyzeChance = coinflip.Next(0, 2);
                if (paralyzeChance == 0)
                {
                    Console.WriteLine(companion2Name + "'s attack PARALYZES " + "Rat Rogue" + "!");
                    isParalyzed = true;
                    paralyzeStacks++;
                }
                else
                {
                    Console.WriteLine(companion2Name + "'s attack does not paralyze " + "Rat Rogue" + ".");
                    isParalyzed = false;
                }

                for (int j = 0; j < finalCompanionCoin; j++)
                {
                    int rng = coinflip.Next(0, 3);
                    if (rng == 0)
                    {
                        totalCompanionDamage += finalCompanionCoinPower;
                        Console.WriteLine(companion2Name + "'s Coin Power: " + "+ " + finalCompanionCoinPower);

                        totalRatRogueDamage += finalCompanionCoinPower;
                        Console.WriteLine(enemyName3 + "'s Coin Power: " + "+ " + finalCompanionCoinPower);
                    }
                    else if (rng == 1)
                    {
                        Console.WriteLine(companion2Name + "'s Coin Power: +0");
                        Console.WriteLine(enemyName3 + "'s Coin Power +0");
                    }
                }

                Console.WriteLine("Total damage dealt by " + companion2Name + ": " + totalCompanionDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatRogueDamage);

                RatRogue2Health -= totalCompanionDamage;
                finalCompanionHealth -= totalRatRogueDamage;

                Console.WriteLine("Remaining enemy health: " + RatRogue2Health);
            }

            static void PeformAttack16(string playerName, ref int playerHealth, ref int playerBaseDamage, int playerCoin, int playerCoinPower, ref int FinalBossHealth, ref int FinalBossBaseDamage)
            {
                Console.WriteLine(playerName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalPlayerDamage = playerBaseDamage;
                int totalFinalBossDamage = FinalBossBaseDamage;

                for (int i = 0; i < playerCoin; i++)
                {
                    int rndcf = coinflip.Next(0, 2);
                    if (rndcf == 0)
                    {
                        totalPlayerDamage += playerCoinPower;
                        Console.WriteLine(playerName + "'s Coin Power: " + "+ " + playerCoinPower);

                        totalFinalBossDamage += playerCoinPower; // Update this line if you want to use a different value for enemyCoinPower
                        Console.WriteLine("Enemy's Coin Power: " + "+ " + playerCoinPower);
                    }
                    else if (rndcf == 1) //tails
                    {
                        Console.WriteLine(playerName + "'s Coin Power: +0");
                        Console.WriteLine("Enemy's Coin Power +0");
                    }
                }

                Console.WriteLine("Total damage dealt by " + playerName + ": " + totalPlayerDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalFinalBossDamage);

                FinalBossHealth -= totalPlayerDamage;

                playerHealth -= totalFinalBossDamage;

                Console.WriteLine("Remaining enemy health: " + FinalBossHealth);
            }

            static void PerformAttack17(ref int firstCompanionHealth, string companionName, string FinalBoss, ref int firstCompanionBaseDamage, ref int FinalBossCoinPower, int firstCompanionCoin, int firstCompanionCoinPower, ref int FinalBossHealth, ref int FinalBossBaseDamage)

            {
                Console.WriteLine(companionName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalCompanionDamage = firstCompanionBaseDamage;
                int totalFinalBossDamage = FinalBossBaseDamage;

                int bleedStacks = coinflip.Next(1, 11);
                FinalBossHealth -= bleedStacks;

                for (int j = 0; j < firstCompanionCoin; j++)
                {
                    int rng = coinflip.Next(0, 3);
                    if (rng == 0)
                    {
                        totalCompanionDamage += firstCompanionCoinPower;
                        Console.WriteLine(companionName + "'s Coin Power: " + "+ " + firstCompanionCoinPower);

                        totalFinalBossDamage += FinalBossCoinPower;
                        Console.WriteLine("Rat Lancer's Coin Power: " + "+ " + FinalBossCoinPower);

                        FinalBossHealth -= bleedStacks;
                        Console.WriteLine("Rat Lancer received " + bleedStacks + " Bleed stacks!");
                        Console.WriteLine("Rat Lancer Bleed stacks: " + bleedStacks);
                    }
                    else if (rng == 1)
                    {
                        Console.WriteLine(companionName + "'s Coin Power: +0");
                        Console.WriteLine("Rat Lancer's Coin Power +0");
                    }
                }

                if (bleedStacks > 0)
                {
                    Console.WriteLine("Rat Lancer is bleeding!");
                    int bleedDamage = bleedStacks;
                    FinalBossHealth -= bleedDamage;
                    Console.WriteLine("Rat Lancer takes " + bleedDamage + " damage from bleed!");
                    bleedStacks--;
                }

                Console.WriteLine("Total damage dealt by " + companionName + ": " + totalCompanionDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalFinalBossDamage);

                FinalBossHealth -= totalCompanionDamage;

                

                Console.WriteLine("Remaining enemy health: " + FinalBossHealth);
            }

            static void PerformAttack18(string playerName, ref int finalCompanionHealth, string companion2Name, string enemyName2, string enemyName3, ref int playerBaseDamage, ref int finalCompanionBaseDamage, int playerCoin, int playerCoinPower, int finalCompanionCoin, int finalCompanionCoinPower, ref int FinalBossHealth, ref int FinalBossBaseDamage, ref int FinalBossCoin, ref int FinalBossCoinPower)
            {
                Console.WriteLine(companion2Name + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalCompanionDamage = finalCompanionBaseDamage;
                int totalRatRogueDamage = FinalBossBaseDamage;

                // Paralyze effect
                bool isParalyzed = false;
                int paralyzeStacks = 0;

                // Check if the enemy is paralyzed
                if (isParalyzed)
                {
                    Console.WriteLine(enemyName3 + " is PARALYZED! Coins and Coin Power reduced!");
                    FinalBossBaseDamage -= paralyzeStacks;
                    FinalBossBaseDamage -= paralyzeStacks;
                    FinalBossCoin -= paralyzeStacks;
                    FinalBossCoinPower -= paralyzeStacks;
                }

                // Apply paralyze effect
                int paralyzeChance = coinflip.Next(0, 2);
                if (paralyzeChance == 0)
                {
                    Console.WriteLine(companion2Name + "'s attack PARALYZES " + "Rat Rogue" + "!");
                    isParalyzed = true;
                    paralyzeStacks++;
                }
                else
                {
                    Console.WriteLine(companion2Name + "'s attack does not paralyze " + "Rat Rogue" + ".");
                    isParalyzed = false;
                }

                for (int j = 0; j < finalCompanionCoin; j++)
                {
                    int rng = coinflip.Next(0, 3);
                    if (rng == 0)
                    {
                        totalCompanionDamage += finalCompanionCoinPower;
                        Console.WriteLine(companion2Name + "'s Coin Power: " + "+ " + finalCompanionCoinPower);

                        totalRatRogueDamage += finalCompanionCoinPower;
                        Console.WriteLine(enemyName3 + "'s Coin Power: " + "+ " + finalCompanionCoinPower);
                    }
                    else if (rng == 1)
                    {
                        Console.WriteLine(companion2Name + "'s Coin Power: +0");
                        Console.WriteLine(enemyName3 + "'s Coin Power +0");
                    }
                }

                Console.WriteLine("Total damage dealt by " + companion2Name + ": " + totalCompanionDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatRogueDamage);

                FinalBossHealth -= totalCompanionDamage;
                

                Console.WriteLine("Remaining enemy health: " + FinalBossHealth);
            }

            static void PeformAttack19(string playerName, ref int playerHealth, ref int playerBaseDamage, int playerCoin, int playerCoinPower, ref int FinalBoss2Health, ref int FinalBossBaseDamage)
            {
                Console.WriteLine(playerName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalPlayerDamage = playerBaseDamage;
                int totalFinalBossDamage = FinalBossBaseDamage;

                for (int i = 0; i < playerCoin; i++)
                {
                    int rndcf = coinflip.Next(0, 2);
                    if (rndcf == 0)
                    {
                        totalPlayerDamage += playerCoinPower;
                        Console.WriteLine(playerName + "'s Coin Power: " + "+ " + playerCoinPower);

                        totalFinalBossDamage += playerCoinPower; // Update this line if you want to use a different value for enemyCoinPower
                        Console.WriteLine("Enemy's Coin Power: " + "+ " + playerCoinPower);
                    }
                    else if (rndcf == 1) //tails
                    {
                        Console.WriteLine(playerName + "'s Coin Power: +0");
                        Console.WriteLine("Enemy's Coin Power +0");
                    }
                }

                Console.WriteLine("Total damage dealt by " + playerName + ": " + totalPlayerDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalFinalBossDamage);

                FinalBoss2Health -= totalPlayerDamage;

                Console.WriteLine("Remaining enemy health: " + FinalBoss2Health);
            }

            static void PerformAttack20(ref int firstCompanionHealth, string companionName, string FinalBoss, ref int firstCompanionBaseDamage, ref int FinalBossCoinPower, int firstCompanionCoin, int firstCompanionCoinPower, ref int FinalBoss2Health, ref int FinalBossBaseDamage)

            {
                Console.WriteLine(companionName + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalCompanionDamage = firstCompanionBaseDamage;
                int totalFinalBossDamage = FinalBossBaseDamage;

                int bleedStacks = coinflip.Next(1, 11);
                FinalBoss2Health -= bleedStacks;

                for (int j = 0; j < firstCompanionCoin; j++)
                {
                    int rng = coinflip.Next(0, 3);
                    if (rng == 0)
                    {
                        totalCompanionDamage += firstCompanionCoinPower;
                        Console.WriteLine(companionName + "'s Coin Power: " + "+ " + firstCompanionCoinPower);

                        totalFinalBossDamage += FinalBossCoinPower;
                        Console.WriteLine("Rat Lancer's Coin Power: " + "+ " + FinalBossCoinPower);

                        FinalBoss2Health -= bleedStacks;
                        Console.WriteLine("Rat Lancer received " + bleedStacks + " Bleed stacks!");
                        Console.WriteLine("Rat Lancer Bleed stacks: " + bleedStacks);
                    }
                    else if (rng == 1)
                    {
                        Console.WriteLine(companionName + "'s Coin Power: +0");
                        Console.WriteLine("Rat Lancer's Coin Power +0");
                    }
                }

                if (bleedStacks > 0)
                {
                    Console.WriteLine("Rat Lancer is bleeding!");
                    int bleedDamage = bleedStacks;
                    FinalBoss2Health -= bleedDamage;
                    Console.WriteLine("Rat Lancer takes " + bleedDamage + " damage from bleed!");
                    bleedStacks--;
                }

                Console.WriteLine("Total damage dealt by " + companionName + ": " + totalCompanionDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalFinalBossDamage);

                FinalBoss2Health -= totalCompanionDamage;
                firstCompanionHealth -= totalFinalBossDamage;



                Console.WriteLine("Remaining enemy health: " + FinalBoss2Health);
            }

            static void PerformAttack21(string playerName, ref int finalCompanionHealth, string companion2Name, string enemyName2, string enemyName3, ref int playerBaseDamage, ref int finalCompanionBaseDamage, int playerCoin, int playerCoinPower, int finalCompanionCoin, int finalCompanionCoinPower, ref int FinalBoss2Health, ref int FinalBossBaseDamage, ref int FinalBossCoin, ref int FinalBossCoinPower)
            {
                Console.WriteLine(companion2Name + " chose to ATTACK!");

                Random coinflip = new Random(); // Random Number Generator for coinflips

                int totalCompanionDamage = finalCompanionBaseDamage;
                int totalRatRogueDamage = FinalBossBaseDamage;

                // Paralyze effect
                bool isParalyzed = false;
                int paralyzeStacks = 0;

                // Check if the enemy is paralyzed
                if (isParalyzed)
                {
                    Console.WriteLine(enemyName3 + " is PARALYZED! Coins and Coin Power reduced!");
                    FinalBossBaseDamage -= paralyzeStacks;
                    FinalBossBaseDamage -= paralyzeStacks;
                    FinalBossCoin -= paralyzeStacks;
                    FinalBossCoinPower -= paralyzeStacks;
                }

                // Apply paralyze effect
                int paralyzeChance = coinflip.Next(0, 2);
                if (paralyzeChance == 0)
                {
                    Console.WriteLine(companion2Name + "'s attack PARALYZES " + "Rat Rogue" + "!");
                    isParalyzed = true;
                    paralyzeStacks++;
                }
                else
                {
                    Console.WriteLine(companion2Name + "'s attack does not paralyze " + "Rat Rogue" + ".");
                    isParalyzed = false;
                }

                for (int j = 0; j < finalCompanionCoin; j++)
                {
                    int rng = coinflip.Next(0, 3);
                    if (rng == 0)
                    {
                        totalCompanionDamage += finalCompanionCoinPower;
                        Console.WriteLine(companion2Name + "'s Coin Power: " + "+ " + finalCompanionCoinPower);

                        totalRatRogueDamage += finalCompanionCoinPower;
                        Console.WriteLine(enemyName3 + "'s Coin Power: " + "+ " + finalCompanionCoinPower);
                    }
                    else if (rng == 1)
                    {
                        Console.WriteLine(companion2Name + "'s Coin Power: +0");
                        Console.WriteLine(enemyName3 + "'s Coin Power +0");
                    }
                }

                Console.WriteLine("Total damage dealt by " + companion2Name + ": " + totalCompanionDamage);
                Console.WriteLine("Total damage dealt by the enemy: " + totalRatRogueDamage);

                FinalBoss2Health -= totalCompanionDamage;


                Console.WriteLine("Remaining enemy health: " + FinalBoss2Health);
            }



            static void PerformDefend(string playerName, ref int playerBaseDamage)
            {
                Console.WriteLine(playerName + " chose to DEFEND!");
                // Implement defend logic if needed
            }

            static void PerformDefendFC(string companionName, ref int firstCompanionBaseDamage)
            {
                Console.WriteLine(companionName + " chose to DEFEND!");
            }

            static void PerformDefendFFC(string companion2Name, ref int finalCompanionBaseDamage)
            {
                Console.WriteLine(companion2Name + " chose to DEFEND!");
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
                playerHealth += 20;
                playerBaseDamage += 2;
                playerCoinPower += 1;

                firstCompanionHealth += 10;
                firstCompanionBaseDamage += 2;
                firstCompanionCoinPower += 1;
            }

            public void ApplyFinalBonusEffect(ref int playerHealth, ref int playerBaseDamage, ref int playerCoinPower,
                                         ref int firstCompanionHealth, ref int firstCompanionBaseDamage, ref int firstCompanionCoinPower,
                                         ref int finalCompanionHealth, ref int finalCompanionBaseDamage, ref int finalCompanionCoinPower)

            {
                playerHealth += 20;
                playerBaseDamage += 2;
                playerCoinPower += 1;

                firstCompanionHealth += 20;
                firstCompanionBaseDamage += 5;
                firstCompanionCoinPower += 1;

                finalCompanionHealth += 20;
                finalCompanionBaseDamage += 2;
                finalCompanionCoinPower += 1;
            }

            public void ApplyFinalNegativeBonusEffect(ref int playerHealth, ref int playerBaseDamage, ref int playerCoinPower,
                                         ref int firstCompanionHealth, ref int firstCompanionBaseDamage, ref int firstCompanionCoinPower,
                                         ref int finalCompanionHealth, ref int finalCompanionBaseDamage, ref int finalCompanionCoinPower)

            {
                playerHealth -= 10;
                playerBaseDamage -= 2;
                playerCoinPower -= 1;

                firstCompanionHealth -= 10;
                firstCompanionBaseDamage -= 5;
                firstCompanionCoinPower -= 1;

                finalCompanionHealth -= 10;
                finalCompanionBaseDamage -= 2;
                finalCompanionCoinPower -= 1;
            }

            public void ApplySemiBonusEffect(ref int playerHealth, ref int playerBaseDamage, ref int playerCoinPower,
                                         ref int firstCompanionHealth, ref int firstCompanionBaseDamage, ref int firstCompanionCoinPower)
            {
                playerHealth += 10;
                playerBaseDamage += 1;

                firstCompanionHealth += 5;
                firstCompanionBaseDamage += 1;

            }

            public void ApplyNegativeEffect(ref int playerHealth, ref int playerBaseDamage, ref int playerCoinPower,
                                            ref int firstCompanionHealth, ref int firstCompanionBaseDamage, ref int firstCompanionCoinPower)
            {
                playerHealth -= 10;
                playerBaseDamage -= 2;
                playerCoinPower -= 1;

                firstCompanionHealth -= 10;
                firstCompanionBaseDamage -= 5;
                firstCompanionCoinPower -= 1;
            }

            public void ApplySemiNegativeEffect(ref int playerHealth, ref int playerBaseDamage, ref int playerCoinPower,
                                         ref int firstCompanionHealth, ref int firstCompanionBaseDamage, ref int firstCompanionCoinPower)
            {
                playerHealth -= 5;
                playerBaseDamage -= 1;
                firstCompanionHealth -= 5;
                firstCompanionBaseDamage -= 3;
            }

            public void TakeBreak(ref int playerHealth, ref int firstCompanionHealth)
            {
                int healthRestored = 50;
                playerHealth += healthRestored;
                firstCompanionHealth += healthRestored;
            }

            public void TakeBreakWithShop(ref int playerHealth, ref int playerBaseDamage, ref int playerCoinPower, ref int playerCoin,
                          ref int firstCompanionHealth, ref int firstCompanionBaseDamage, ref int firstCompanionCoinPower, ref int firstCompanionCoin,
                          ref int finalCompanionHealth, ref int finalCompanionBaseDamage, ref int finalCompanionCoinPower, ref int finalCompanionCoin, ref int gold)
            {
                Console.WriteLine("You currently have: " + gold);
                Console.WriteLine("You decide to take a break and buy from the stranger");
                Console.WriteLine("Stranger: Welcome! What would you like to buy?");
                Console.WriteLine("1. Food (+10 Health) - 5 gold");
                Console.WriteLine("2. FoodX (allies gain + 10 Health ) - 10 gold");
                Console.WriteLine("3. Energy Drink (+1 Coin Power) - 6 gold");
                Console.WriteLine("4. Energy DrinkX (allies gain +1 Coin) - 12 gold");
                Console.WriteLine("5. Lucky Coin (+1 Coin) -  8 gold");
                Console.WriteLine("6. Lucky CoinX (allies gain +1 coin) - 16 gold");
                Console.WriteLine("7. Protein (+2 Damage) - 4 gold");
                Console.WriteLine("8. ProteinX (allies gain +2 Damage) - 8 gold");
                Console.WriteLine("9. Leave");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (gold >= 5)
                        {
                            Console.WriteLine("You bought Food. You gain health increased by 10.");
                            Console.ReadLine();
                            playerHealth += 10;
                            gold -= 5;
                        }
                        else
                        {
                            Console.WriteLine("Stranger: You don't have enough gold.");
                            Console.ReadLine();
                        }
                        break;
                    case "2":
                        if (gold >= 10)
                        {
                            Console.WriteLine("You bought FoodX. You and your gain 10 health.");
                            Console.ReadLine();
                            playerHealth += 10;
                            firstCompanionHealth += 10;
                            finalCompanionHealth += 10;
                            gold -= 10;
                        }
                        else
                        {
                            Console.WriteLine("Stranger: You don't have enough gold.");
                            Console.ReadLine();
                        }
                        break;
                    case "3":
                        if (gold >= 6)
                        {
                            Console.WriteLine("You bought an Energy Drink. You gain +1 Coin Power");
                            Console.ReadLine();
                            playerCoinPower += 1;
                            gold -= 10;
                        }
                        else
                        {
                            Console.WriteLine("Stranger: You don't have enough gold.");
                            Console.ReadLine();
                        }
                        break;
                    case "4":
                        if (gold >= 16)
                        {
                            Console.WriteLine("You bought an Energy DrinkX. You and your team gain + 1 Coin Power");
                            Console.ReadLine();
                            playerCoinPower += 1;
                            firstCompanionCoinPower += 1;
                            finalCompanionCoinPower += 1;
                        }
                        else
                        {
                            Console.WriteLine("Stranger: You don't have enough gold.");
                            Console.ReadLine();
                        }
                        break;
                    case "5":
                        if (gold >= 8)
                        {
                            Console.WriteLine("You bought a Lucky Coin. You gain +1 coin");
                            Console.ReadLine();
                            playerCoin += 1;
                            gold -= 8;
                        }
                        else
                        {
                            Console.WriteLine("Stranger: You don't have enough gold.");
                            Console.ReadLine();
                        }
                        break;
                    case "6":
                        if (gold >= 16)
                        {
                            Console.WriteLine("You bought Lucky CoinX. You and your team gain a coin.");
                            playerCoin += 1;
                            firstCompanionCoin += 1;
                            finalCompanionCoin += 1;
                            gold -= 16;
                        }
                        else
                        {
                            Console.WriteLine("Stranger: You don't have enough gold.");
                            Console.ReadLine();
                        }
                        break;
                    case "7":
                        if (gold >= 4)
                        {
                            Console.WriteLine("You bought a Protein. You gain +2 damage.");
                            Console.ReadLine();
                            playerBaseDamage += 1;
                            gold -= 4;
                        }
                        else
                        {
                            Console.WriteLine("Stranger: You don't have enough gold.");
                            Console.ReadLine();
                        }
                        break;
                    case "8":
                        if (gold >= 8)
                        {
                            Console.WriteLine("You bought ProteinX. You and your team gain +2 damage");
                            Console.ReadLine();
                            playerBaseDamage += 2;
                            firstCompanionBaseDamage += 2;
                            finalCompanionBaseDamage += 2;
                            gold -= 8;
                        }
                        else
                        {
                            Console.WriteLine("Stranger: You don't have enough gold.");
                            Console.ReadLine();
                        }
                        break;
                    case "9":
                        Console.WriteLine("You decided to leave the shop.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Nothing happened.");
                        Console.ReadLine();
                        break;
                }
            }


        }
    }

