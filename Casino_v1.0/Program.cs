using System;

namespace bet
{
	class Program
	{
		static void Main(string[] args)
		{
			// general vars
			Random rd = new Random();
			string game;
			int coins = 100;
			string version = "v1.0";
			string devs = "Paul, Make";
			string release_date = "2020.12.1";
			
			// SPLASH ==================================================================================================================================================================
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Willkommen in Paul's & Make's Casino ({0})", version);
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.White;
			Console.ReadKey();
			do
			{
				// HOME ================================================================================================================================================================
				Console.WriteLine("Welches Spiel möchtest du spielen?");
				Console.WriteLine("");
				Console.WriteLine("Zur Auswahl stehen momentan Coinflip und Roulette.");
				Console.WriteLine("");
				Console.Write("Du hast ");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write(coins);
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine(" Coins");
				Console.Write("Solltest du keine Coins mehr haben, kannst du mit dem ");
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write("Fish");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("-Command dein Glück versuchen.");
				Console.WriteLine("");
				Console.Write("Mit dem ");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("help");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("-Command kannst du dir andere Commands anzeigen lassen.");
				Console.WriteLine("");
				Console.Write("Mit ");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("exit ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("kannst du das Spiel verlassen.");
				Console.WriteLine("");
				game = Console.ReadLine();
				Console.Clear();
				if (game == "Coinflip")
				{
					// COINFLIP ======================================================================================================================================================

					// Coinflip vars

					int rand_num_coinflip = rd.Next(0, 2);
					int result_coinflip;
					int coins_set_coinflip;
					string headortails = "";
					// Coinflip game


					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("           CCCC   OOO   IIIII  N    N  FFFFF  L      IIIII  PPPP           ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("          C      O   O    I    NN   N  F      L        I    P   P          ");
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("========  C      O   O    I    N  N N  FFFFF  L        I    PPPP   ========");
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
					Console.WriteLine("          C      O   O    I    N   NN  F      L        I    P              ");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("           CCCC   OOO   IIIII  N    N  F      LLLLL  IIIII  P              ");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("");
					Console.WriteLine("Wie viele Coins möchtest du einsetzen? Du hast {0} Coins", coins);
					coins_set_coinflip = Convert.ToInt32(Console.ReadLine());
					if (coins <= 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Sorry, Du hast keine Coins mehr. Du kannst jetzt 350 Coins für 2,99€ kaufen. ^^");
						Console.ReadKey();
						Console.ForegroundColor = ConsoleColor.White;
					}
					else if (coins_set_coinflip > coins)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Sorry, Du hast nicht mehr genug Coins übrig. Du kannst jetzt 350 Coins für 2,99€ kaufen. ^^");
						Console.ForegroundColor = ConsoleColor.White;
					}
					else
					{
						coins = coins - coins_set_coinflip;
						Console.WriteLine("Setze auf Kopf oder Zahl an");
						headortails = Console.ReadLine();
						if (headortails == "Kopf")
						{
							result_coinflip = 1;
						}
						else if (headortails == "Zahl")
						{
							result_coinflip = 0;
						}
						else
						{
							result_coinflip = 2;
						}
						if (result_coinflip == 0)
						{
							if (rand_num_coinflip == 0)
							{
								Console.ForegroundColor = ConsoleColor.Green;
								Console.WriteLine("DU HAST GEWONNEN");
								Console.WriteLine("Du erhälst {0} Coins", coins_set_coinflip * 2);
								coins = coins + (coins_set_coinflip * 2);
								Console.ForegroundColor = ConsoleColor.White;
							}
							else if (rand_num_coinflip == 1)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Du hast verloren");
								Console.WriteLine("Du verlierst {0} Coins", coins_set_coinflip);
								Console.ForegroundColor = ConsoleColor.White;
							}
						}
						else if (result_coinflip == 1)
						{
							if (rand_num_coinflip == 1)
							{
								Console.ForegroundColor = ConsoleColor.Green;
								Console.WriteLine("DU HAST GEWONNEN");
								Console.WriteLine("Du erhälst {0} Coins", coins_set_coinflip * 2);
								coins = coins + (coins_set_coinflip * 2);
								Console.ForegroundColor = ConsoleColor.White;
							}
							else if (rand_num_coinflip == 0)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Du hast verloren");
								Console.WriteLine("Du verlierst {0} Coins", coins_set_coinflip);
								Console.ForegroundColor = ConsoleColor.White;
							}
						}
						else
						{
							coins = coins + coins_set_coinflip;
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("Error");
							Console.ForegroundColor = ConsoleColor.White;
						}
					}
				}
				else if (game == "Roulette")
				{
					// ROULETTE ====================================================================================================================================================

					// Roulette vars
					int rand_num_roulette = rd.Next(0, 37);
					string result_roulette;
					int coins_set_roulette;
					string color = "";

					//Roulette game
					
					
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("          RRRR    OOO   U   U  L      EEEEE  TTTTT  TTTTT  EEEEE          ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("          R   R  O   O  U   U  L      E        T      T    E              ");
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.WriteLine("========  RRRR   O   O  U   U  L      EEEEE    T      T    EEEEE  ========");
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
					Console.WriteLine("          R R    O   O  U   U  L      E        T      T    E              ");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("          R  R    OOO    UUU   LLLLL  EEEEE    T      T    EEEEE          ");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("");
					Console.WriteLine("Wie viele Coins möchtest du einsetzen? Du hast {0} Coins", coins);
					coins_set_roulette = Convert.ToInt32(Console.ReadLine());
					if (coins <= 0)
					{
						Console.WriteLine("Sorry, Du hast keine Coins mehr. Du kannst jetzt 350 Coins für 2,99 Euro kaufen. ^^");
						Console.ReadKey();
					}
					else if (coins_set_roulette > coins)
					{
						Console.WriteLine("Sorry, Du hast nicht mehr genug Coins übrig. Du kannst jetzt 350 Coins für 2,99 Euro kaufen. ^^");
					}
					else
					{
						coins = coins - coins_set_roulette;
						Console.WriteLine("Gib Rot, Schwarz oder Grün an.");
						result_roulette = Console.ReadLine();
						switch (rand_num_roulette)
						{
							case 0:
								color = "green";
								break;

							case 1:
								color = "red";
								break;

							case 2:
								color = "black";
								break;

							case 3:
								color = "red";
								break;

							case 4:
								color = "black";
								break;

							case 5:
								color = "red";
								break;

							case 6:
								color = "black";
								break;

							case 7:
								color = "red";
								break;

							case 8:
								color = "black";
								break;

							case 9:
								color = "red";
								break;

							case 10:
								color = "black";
								break;

							case 11:
								color = "black";
								break;

							case 12:
								color = "red";
								break;

							case 13:
								color = "black";
								break;

							case 14:
								color = "red";
								break;

							case 15:
								color = "black";
								break;

							case 16:
								color = "red";
								break;

							case 17:
								color = "black";
								break;

							case 18:
								color = "red";
								break;

							case 19:
								color = "red";
								break;

							case 20:
								color = "black";
								break;

							case 21:
								color = "red";
								break;

							case 22:
								color = "black";
								break;

							case 23:
								color = "red";
								break;

							case 24:
								color = "black";
								break;

							case 25:
								color = "red";
								break;

							case 26:
								color = "black";
								break;

							case 27:
								color = "red";
								break;

							case 28:
								color = "black";
								break;

							case 29:
								color = "black";
								break;

							case 30:
								color = "red";
								break;

							case 31:
								color = "black";
								break;

							case 32:
								color = "red";
								break;

							case 33:
								color = "black";
								break;

							case 34:
								color = "red";
								break;

							case 35:
								color = "black";
								break;

							case 36:
								color = "red";
								break;
						}
						if (color == "green")
						{
							if (result_roulette == "Grün")
							{
								Console.ForegroundColor = ConsoleColor.Green;
								Console.WriteLine("DU HAST GEWONNEN");
								Console.WriteLine("Du gewinnst {0} Coins", coins_set_roulette * 14);
								Console.ForegroundColor = ConsoleColor.White;
								coins = coins + coins_set_roulette * 14;
							}
							else if (result_roulette == "Schwarz")
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Du hast verloren.");
								Console.WriteLine("Du verlierst {0} Coins", coins_set_roulette);
								Console.ForegroundColor = ConsoleColor.White;
								Console.WriteLine("Die zufällige Farbe war Grün.");
							}
							else if (result_roulette == "Rot")
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Du hast verloren.");
								Console.WriteLine("Du verlierst {0} Coins", coins_set_roulette);
								Console.ForegroundColor = ConsoleColor.White;
								Console.WriteLine("Die zufällige Farbe war Grün.");
							}
							else
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Error");
								coins = coins + coins_set_roulette;
								Console.ForegroundColor = ConsoleColor.White;
							}
						}
						if (color == "red")
						{
							if (result_roulette == "Rot")
							{
								Console.ForegroundColor = ConsoleColor.Green;
								Console.WriteLine("DU HAST GEWONNEN");
								Console.WriteLine("Du gewinnst {0} Coins", coins_set_roulette * 2);
								Console.ForegroundColor = ConsoleColor.White;
								coins = coins + coins_set_roulette * 2;
							}
							else if (result_roulette == "Schwarz")
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Du hast verloren");
								Console.WriteLine("Du verlierst {0} Coins", coins_set_roulette);
								Console.ForegroundColor = ConsoleColor.White;
								Console.WriteLine("Die zufällige Farbe war Rot.");
							}
							else if (result_roulette == "Grün")
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Du hast verloren");
								Console.WriteLine("Du verlierst {0} Coins", coins_set_roulette);
								Console.ForegroundColor = ConsoleColor.White;
								Console.WriteLine("Die zufällige Farbe war Rot.");
							}
							else
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Error");
								coins = coins + coins_set_roulette;
								Console.ForegroundColor = ConsoleColor.White;
							}
						}
						if (color == "black")
						{
							if (result_roulette == "Schwarz")
							{
								Console.ForegroundColor = ConsoleColor.Green;
								Console.WriteLine("DU HAST GEWONNEN");
								Console.WriteLine("Du gewinnst {0} Coins", coins_set_roulette * 2);
								Console.ForegroundColor = ConsoleColor.White;
							}
							else if (result_roulette == "Rot")
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Du hast verloren");
								Console.WriteLine("Du verlierst {0} Coins", coins_set_roulette);
								Console.ForegroundColor = ConsoleColor.White;
								Console.WriteLine("Die zufällige Farbe war Schwarz.");
							}
							else if (result_roulette == "Grün")
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Du hast verloren");
								Console.WriteLine("Du verlierst {0} Coins", coins_set_roulette);
								Console.ForegroundColor = ConsoleColor.White;
								Console.WriteLine("Die zufällige Farbe war Schwarz.");
							}
							else
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Error");
								coins = coins + coins_set_roulette;
								Console.ForegroundColor = ConsoleColor.White;
							}
						}
					}
				}
				else if (game == "Fish")
				{
					// FISHING =====================================================================================================================================================

					// Fishing vars
					int rand_num_fish = rd.Next(1, 11);
					int rand_coins_fish = rd.Next(1, 6);
					int coins_fish;

					// Fishing game
					if (rand_num_fish <= 2)
					{
						coins_fish = 12; // -12
						coins = coins - coins_fish;
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Schade. Du verlierst {0} Coins.", coins_fish);
						Console.ForegroundColor = ConsoleColor.White;
					}
					else if (rand_num_fish > 2)
					{
						coins_fish = rand_coins_fish;
						coins = coins + coins_fish;
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Du gewinnst {0} Coins.", coins_fish);
						Console.ForegroundColor = ConsoleColor.White;
					}
				}
				// EXIT ==============================================================================================================================================================

				else if (game == "exit")
				{
					string leave;
					Console.Clear();
					Console.WriteLine("Möchtest du das Spiel wirklich verlassen?");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("");
					Console.WriteLine("Ja");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Nein");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("");
					Console.WriteLine("");
					leave = Console.ReadLine();
					if (leave == "Ja")
					{
						break;
					}
					else if (leave == "Nein")
					{
						Console.WriteLine("");
					}
					else
					{
						Console.WriteLine("");
					}
				}
				else if (game == "help")
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine("Commands:");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("");
					Console.WriteLine("");
					Console.WriteLine("");
					Console.WriteLine("Coinflip        Initiiert das Coinflip-Game");
					Console.WriteLine("");
					Console.WriteLine("Roulette        Initiiert das Roulette-Game");
					Console.WriteLine("");
					Console.WriteLine("Fish            Initiiert den Fishing-Prozess");
					Console.WriteLine("");
					Console.WriteLine("help            Zeigt dieses Hilfe-Fenster");
					Console.WriteLine(""); 
					Console.WriteLine("exit            Beendet das Spiel (fortschritt wird NICHT gespeichert! WIP!");
					Console.WriteLine("");
					Console.WriteLine("");
					Console.WriteLine("");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine("Info:");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("");
					Console.WriteLine("");
					Console.WriteLine("");
					Console.WriteLine("devs:           {0}", devs);
					Console.WriteLine("version:        {0}", version);
					Console.WriteLine("release-date:   {0}", release_date);
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Error 404. You're looking for the wrong game. ^^");
					Console.ForegroundColor = ConsoleColor.White;
				}
				Console.ReadKey();
				Console.Clear();
			}
			while (true);
		}
	}
}