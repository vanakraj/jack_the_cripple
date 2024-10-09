/*When I wrote that thing, only God and I knew what was going on here. 
Now only God knows the answer.

FUCKED_UPS = 8
COFFEE_EXED = 13
LINES_SNORTED = 21
JOINTS_DETONATED = 34
*/

using System;
using System.Security.Cryptography;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;


namespace BrainNotBraining
{
    class Game
    {
        public string OUT = "";
        public void Start()
        {

            Title = "j4ck_th3_cripp13.vbs";
            RunMainMenu();
            WriteLine("\nPress any key to escape the Matrix...");
            ReadKey(true);
        }

        public void RunMainMenu()
        {
            string prompt = @"
*****************************************************************************************
   _  _  _          _         _    _      _____                 _                _  _____ 
  (_)| || |    ___ | | __    | |_ | |__  |___ /      ___  _ __ (_) _ __   _ __  / ||___ / 
  | || || |_  / __|| |/ /    | __|| '_ \   |_ \     / __|| '__|| || '_ \ | '_ \ | |  |_ \ 
  | ||__   _|| (__ |   <     | |_ | | | | ___) |   | (__ | |   | || |_) || |_) || | ___) |
 _/ |   |_|   \___||_|\_\_____\__||_| |_||____/_____\___||_|   |_|| .__/ | .__/ |_||____/ 
|__/                    |_____|               |_____|             |_|    |_|              

                        © David Imenov 2024 ByteBerserk
*****************************************************************************************

Drzis v rukou velmi nemocny nastroj, velmi trivialniho sifrovani pomoci Caesarovy, Vinegerovy, Atbashovy sifry.
HashCreator z knihovny a passwordGuesser, jsou take soucasti rodinneho baleni.
// Scrollujes sipkama nahoru/dolu, vybiras stisknutim [Enter]. 
Vyber si jednu z nabizenych moznosti:

            ";

            string[] options = { "Start", "ReadMe", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    DisplayReadMe();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }

        private void ExitGame()
        {
            //Zase je slysim, rikaj mi co mam psat za zverstva.
            WriteLine("\nPress any key to escape the Matrix...");
            ReadKey(true);
            //Odejdi z aplikace s kodem 0, vsecko pohoda.
            Environment.Exit(0);
        }

        public void DisplayReadMe()
        {
            Clear();
            string readMe = @"Another one got caught today, it's all over the papers.

'Teenager Arrested in Computer Crime Scandal', 'Hacker Arrested after Bank Tampering'... 

Damn kids. They're all alike.

But did you, in your three-piece psychology and 1950's technobrain, ever take a look behind the eyes of the hacker? Did you ever wonder what made him tick, what forces shaped him, what may have molded him? 

I am a hacker, enter my world...

Mine is a world that begins with school... I'm smarter than most of the other kids, this crap they teach us bores me... 

Damn underachiever. They're all alike.

I'm in junior high or high school. I've listened to teachers explain for the fifteenth time how to reduce a fraction. I understand it. 'No, Ms. Smith, I didn't show my work. I did it in my head...' 

Damn kid. Probably copied it. They're all alike.

I made a discovery today. I found a computer. Wait a second, this is cool. It does what I want it to. If it makes a mistake, it's because I screwed it up. Not because it doesn't like me... 

Or feels threatened by me... 
Or thinks I'm a smart ass... 
Or doesn't like teaching and shouldn't be here...

Damn kid. All he does is play games. They're all alike.

And then it happened... a door opened to a world... rushing through the phone line like heroin through an addict's veins, an electronic pulse is sent out, a refuge from the day-to-day incompetencies is sought... a board is found. 

'This is it... this is where I belong...'

I know everyone here... even if I've never met them, never talked to them, may never hear from them again... I know you all...

Damn kid. Tying up the phone line again. They're all alike...

You bet your ass we're all alike... we've been spoon-fed baby food at school when we hungered for steak... the bits of meat that you did let slip through were pre-chewed and tasteless. We've been dominated by sadists, or ignored by the apathetic. The few that had something to teach found us willing pupils, but those few are like drops of water in the desert.

This is our world now... the world of the electron and the switch, the beauty of the baud. We make use of a service already existing without paying for what could be dirt-cheap if it wasn't run by profiteering gluttons, and you call us criminals. We explore... and you call us criminals. We seek after knowledge... and you call us criminals. We exist without skin color, without nationality, without religious bias... and you call us criminals. You build atomic bombs, you wage wars, you murder, cheat, and lie to us and try to make us believe it's for our own good, yet we're the criminals.

Yes, I am a criminal. My crime is that of curiosity. My crime is that of judging people by what they say and think, not what they look like. My crime is that of outsmarting you, something that you will never forgive me for.

I am a hacker, and this is my manifesto. You may stop this individual, but you can't stop us all... after all, we're all alike.

vanakraj";

            WriteLine(readMe);
            ReadKey(true);
            RunMainMenu();
        }

        private void RunFirstChoice()
        {
            string prompt = @"
*****************************************************************************************
   _  _  _          _         _    _      _____                 _                _  _____ 
  (_)| || |    ___ | | __    | |_ | |__  |___ /      ___  _ __ (_) _ __   _ __  / ||___ / 
  | || || |_  / __|| |/ /    | __|| '_ \   |_ \     / __|| '__|| || '_ \ | '_ \ | |  |_ \ 
  | ||__   _|| (__ |   <     | |_ | | | | ___) |   | (__ | |   | || |_) || |_) || | ___) |
 _/ |   |_|   \___||_|\_\_____\__||_| |_||____/_____\___||_|   |_|| .__/ | .__/ |_||____/ 
|__/                    |_____|               |_____|             |_|    |_|              

                        © David Imenov 2024 ByteBerserk
*****************************************************************************************
Vyber si svoji zbran, a hlavne se bav. ILOVEYOU!
// Scrollujes sipkama nahoru/dolu, vybiras stisknutim [Enter]. 
Vyber si jednu z nabizenych moznosti: 

            "; //tady uz jsem to fakt prehnal, ale smysl je jasnej proste menicko na sifry jako v mekaci.
            //sekundarni menu na vyber sifry
            string[] options = { "CaesarCipher", "VigenereCipher", "AtbashCipher", "HashCreator", "PinGuesser", "ResolveMainProblem", "GoBackTooMuch" };
            Menu cipherMenu = new Menu(prompt, options);
            //terciarni menu na vyber vstupu, nechci se moc passtit na souborech protoze nejsou zajimave.
            string[] simpleChoice = { "KeyboardInput", "DefaultFileInput", "CustomFileInput", "GoBackTooTooMuch" };
            Menu fileMenu = new Menu(prompt, simpleChoice);


            int selectedIndex = cipherMenu.Run();
            switch (selectedIndex) //KOSTRA PROGRAMU, VYBER Z 7 MOZNOSTI 7 SMRTELNYCH HRICHU, MEL BYCH MIN HULIT.
            {
                case 0:
                    WriteLine("\n\nCaesarCipher is going BRRRRR");
                    Thread.Sleep(1000); //Da se to udelat pres funkci a volat ji ale tech moznosti tu neni tolik, takze ruco
                    int INPUT = fileMenu.Run();
                    OUT = CaesarCipher(INPUT);
                    Write(OUT);
                    ReadKey(true);
                    break;
                case 1:
                    WriteLine("\n\nVigenereCipher is going BRRRRR");
                    Thread.Sleep(1000);
                    INPUT = fileMenu.Run();
                    OUT = VigenereCipher(INPUT);
                    Write(OUT);
                    ReadKey(true);
                    break;
                case 2:
                    WriteLine("\n\nAtbashCipher is going BRRRRR");
                    Thread.Sleep(1000);
                    INPUT = fileMenu.Run();
                    OUT = AtbashCipher(INPUT);
                    Write(OUT);
                    ReadKey(true);
                    break;
                case 3:
                    WriteLine("\n\nHashCreator is going BRRRRR");
                    Thread.Sleep(1000);
                    HashCreator();
                    ReadKey(true);
                    break;
                case 4:
                    WriteLine("\n\nPinGuesser is going BRRRRR");
                    Thread.Sleep(1000);
                    PinGuesser();
                    ReadKey(true);
                    break;
                case 5:
                    WriteLine("\n\nResolveMainProblem is going BRRRRR");
                    Thread.Sleep(1000);
                    ResolveMainProblem();
                    ReadKey(true);
                    break;
                case 6:
                    break;
            }
            Clear();
            RunMainMenu();


        }
        //Jednoducha funkce posunu nebo spise rotace abecedy a cisel. Podobne jako Julius s tim rotacnim valcem o 2 pulkach.
        private string CaesarCipher(int from)
        {
            //Exit se nam tady moc nepovedl, ale to nevadi jsem rad ze to bezi vubec XD.
            if (from == 3)
            {
                Write("\nPotvrd EXIT stisknutim [Enter]");
                return "";
            }
            //Zeptam se na posun 
            Write("\n\nZadej cislo v rozsahu (1-25): ");
            int shift;
            //Musi to bejt cislo jinak ssos 1
            while (!int.TryParse(ReadLine(), out shift))
                WriteLine("Neplatné číslo, zkus to znova a poradne!");

            //shift musi bejt z intervalu, osetreni vstupu
            if (shift < 1 || shift > 25)
            {
                Write("\nNeplatny vstup.\n");//Druhej pokus nezajem, zivot nedava druhy pokusy. Staci se dostat okolo pres menu.
                return "";
            }
            string input = "";

            //Vyberu odkud jde input
            if (from == 0)
            {
                WriteLine("Zadej text ktery se zasifruje: ");
                input = ReadLine();
            }
            else if (from == 1)
            {
                using (StreamWriter sw = File.CreateText("default.txt")) //using samo zavira soubory, netreba sw.Close()
                {
                    //Celkem bizar nechci to komentovat, neumim zachazet s @stringama
                    sw.Write(@"
abcdefghijklmnopqrstuvwxyz

ABCDEFGHIJKLMNOPQRSTUVWXYZ 

0123456789

.,!?@#$%^&*()_+:\/<>{} 

vanakraj");
                }
                input = File.ReadAllText("default.txt");
            }
            else if (from == 2)
            {
                WriteLine("Zadej cestu k souboru: ");
                string filePath = ReadLine();
                if (File.Exists(filePath))
                {
                    input = File.ReadAllText(filePath);
                }
                else
                {
                    WriteLine("Soubor nebyl nalezen.");
                    return "";
                }
            }


            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        sb.Append((char)(((c + shift - 'A') % 26) + 'A'));
                    }
                    else
                    {
                        sb.Append((char)(((c + shift - 'a') % 26) + 'a'));
                    }
                }
                else if (char.IsDigit(c))
                {
                    sb.Append((char)(((c + shift - '0') % 10) + '0'));
                }
                else
                {
                    sb.Append(c);
                }
            }

            string result = sb.ToString();
            result = $">>>INPUT<<<{input}\n\n<<<OUTPUT>>>{result}";
            return result;
        }
        //Ach ich ouvej, caesar na steroidech nic vic, nic min. Misto posunu ma proste klic.
        private string VigenereCipher(int from)
        {
            //Exit se nam tady moc nepovedl, ale to nevadi jsem rad ze to bezi vubec XD.
            if (from == 3)
            {
                Write("\nPotvrd EXIT stisknutim [Enter]");
                return "";
            }
            Write("Zadej klic ktery se ma pouzit, default je vanakraj: ");
            string key = ReadLine();
            //osetri klic, abys mohl zamknout zamek
            key = new string(key.Where(char.IsLetter).ToArray());
            //V pripade ze uzivatel nezada nic. Tak to bejva

            if (string.IsNullOrEmpty(key))
            {
                key = "vanakraj";
            }

            string input = "";
            if (from == 0)
            {
                //Velmi tajemne velmi mysteriozni, musim na to min kaslat a vic psat nelidsky veci.
                Write($"Zadej text ktery se danym klicem {key} zasifruje: ");
                input = ReadLine();
            }
            else if (from == 1)
            {
                using (StreamWriter sw = File.CreateText("default.txt")) //using samo zavira soubory, netreba sw.Close()
                {
                    sw.Write(@"
abcdefghijklmnopqrstuvwxyz

ABCDEFGHIJKLMNOPQRSTUVWXYZ 

0123456789

.,!?@#$%^&*()_+:\/<>{} 

vanakraj");
                }
                input = File.ReadAllText("default.txt");
            }
            else if (from == 2)
            {
                Write("Zadej cestu k souboru: ");
                string filePath = ReadLine();
                if (File.Exists(filePath))
                {
                    input = File.ReadAllText(filePath);
                }
                else
                {
                    Write("Soubor nebyl nalezen.");
                    return "";
                }
            }

            StringBuilder sb = new StringBuilder();

            int keyIndex = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    int shift = key[keyIndex % key.Length] - 'a';
                    if (char.IsUpper(c))
                    {
                        sb.Append((char)(((c + shift - 'A') % 26) + 'A'));
                    }
                    else
                    {
                        sb.Append((char)(((c + shift - 'a') % 26) + 'a'));
                    }
                    keyIndex++;
                }
                else if (char.IsDigit(c))
                {
                    //Jakoby ceasar s klicem, nic vic nic min. Agenti uz jsou tady.
                    int shift = key[keyIndex % key.Length] - '0';
                    sb.Append((char)(((c + shift - '0') % 10) + '0'));
                    keyIndex++;
                }
                else
                {
                    sb.Append(c);
                }
            }

            string result = sb.ToString();
            result = $">>>INPUT<<<{input}\n\n<<<OUTPUT>>>{result}";
            return result;
        }
        private string AtbashCipher(int from)
        {
            //Exit se nam tady moc nepovedl, ale to nevadi jsem rad ze to bezi vubec XD.
            if (from == 3)
            {
                Write("\nPotvrd EXIT stisknutim [Enter]");
                return "";
            }

            string input = "";
            if (from == 0)
            {
                Write("Zadej text ktery se zasifruje: ");
                input = ReadLine();
            }
            else if (from == 1)
            {
                using (StreamWriter sw = File.CreateText("default.txt")) //using samo zavira soubory, netreba sw.Close()
                {
                    sw.Write(@"
abcdefghijklmnopqrstuvwxyz

ABCDEFGHIJKLMNOPQRSTUVWXYZ 

0123456789

.,!?@#$%^&*()_+:\/<>{} 

vanakraj");
                }
                input = File.ReadAllText("default.txt");
                
            }
            else if (from == 2)
            {
                Write("Zadej cestu k souboru: ");
                string filePath = ReadLine();
                if (File.Exists(filePath))
                {
                    input = File.ReadAllText(filePath);
                }
                else
                {
                    Write("Soubor nebyl nalezen.");
                    return "";
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    int shift = 'z' - c;
                    if (char.IsUpper(c))
                    {
                        sb.Append((char)(shift + 'A'));
                    }
                    else
                    {
                        sb.Append((char)(shift + 'a'));
                    }
                }
                else if (char.IsDigit(c))
                {
                    int flippedDigit = 9 - (c - '0');
                    sb.Append((char)(flippedDigit + '0'));
                }
                else
                {
                    sb.Append(c);
                }
            }

            string result = sb.ToString();
            result = $">>>INPUT<<<{input}\n\n<<<OUTPUT>>>{result}";
            return result;
        }

        private void HashCreator()
        {
            Write("Zadej text ktery se zahashuje(SHA-256): ");
            string input = ReadLine();
            byte[] data = Encoding.UTF8.GetBytes(input);
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(data);
                string hex = BitConverter.ToString(hash);
                WriteLine("Vysledny hash je: " + hex.Replace("-", ""));
            }
        }

        private void PinGuesser()
        {
            Write("Zadej delku pinu (1-6 cisel): ");
            int length;
            //Musi to bejt cislo jinak ssos 2
            while (!int.TryParse(ReadLine(), out length));
                WriteLine("Neplatné číslo, zkus to znova a poradne!");

            if (length < 1 || length > 6)
            {
                WriteLine("Neplatny vstup."); //Druhej pokus nezajem, zivot nedava druhy pokusy. Staci se dostat okolo pres menu.
                return;
            }

            Write("Zadej prodlevu mezi pokusy bruteforce v milisekundach (default je 0): ");
            string delayInput = ReadLine();
            //default prodlevy je 0 at nezeru
            int delay = string.IsNullOrEmpty(delayInput) ? 0 : int.Parse(delayInput);

            Write("Zadej svuj velmi bezpecny PIN: ");
            string userPinInput = ReadLine();
            string userPin = OsetriPin(userPinInput, length);

            if (userPin == null)
            {
                WriteLine("Spatne zadany PIN.");
                return;
            }

            WriteLine($"BruteForcing PINU delky {length}...\n\n");

            DateTime startTime = DateTime.Now; //Kolik to bude trvat? C# je asi rychlejsi nez for v pythonu. Tip laika uvidime.
            bool pinNotGuessed = true;

            for (int i = 0; i < Math.Pow(10, length); i++) //Brute force velmi trivialne, zadny slovniky zadna sranda.
            {
                string currentPin = i.ToString().PadLeft(length, '0');

                if (currentPin == userPin)
                {
                    pinNotGuessed = false;
                    WriteLine($"TRYING PIN {currentPin}");
                    break;
                }

                WriteLine($"TRYING PIN {currentPin}");
                //Prepocet zadanych vterin na milivteriny, to ani neni slovo ne xd.
                System.Threading.Thread.Sleep(delay); // Uzivatel jiz zada milisekundy, v sekundach jsme tu do zitra.
            }

            if (pinNotGuessed)
            {
                WriteLine("PIN nebyl nalezen, nastala chyba."); //Velmi imaginarni situace vzhledem k poctu kombinaci.
            }
            else
            {
                Thread.Sleep(1000);
                TimeSpan timeSpent = DateTime.Now - startTime; //Vypocet casu
                //Ani dekorator neumime ach ich ouvej, ja bych furt neco vybarvoval,
                //zvlast kdyz ten brute ma slozitost vic nez exponencialni. Ale tak aspon ze to je vybarveny.
                WriteLine("*****************************************************************************************");
                WriteLine($"Tvuj PIN {userPin}, byl nalezenen za {timeSpent.TotalSeconds} sekund.");
                WriteLine("*****************************************************************************************");
            }
        }
        //Aspon 3 osetreni vstupu, abych nezral. Ne sorry je to skolni projekt, ne NASA raketa.
        private string OsetriPin(string pin, int length)
        {
            if (pin.Length != length)
            {
                return null; //Spatne delka, nebo spis slibena a dodana si neodpovidaji. Abstrakce je vsechno
            }

            for (int i = 0; i < pin.Length; i++)
            {
                if (!char.IsDigit(pin[i]))
                {
                    return null; //Vyskoc s chybou, mezi cisly bylo nalezeno necislo.
                }
            }

            return pin;
        }
        //02:47 zase je slysim, musim napachat jeste hodne skody.
        //Myslim ze venku stoji auto.

        private static void ResolveMainProblem()
        {
            WriteLine("*****************************************************************************************");
            WriteLine(@"
                    ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠉⠉⠉⠀⠀⠉⠙⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠛⠉⠉⠉⠉⠙⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠉⠀⠰⣏⣤⣤⣆⣠⣀⣀⣀⣀⡉⠛⣿⣿⣿⣿⣿⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⠋⠀⢲⢢⢤⣀⡀⠀⠀⠀⠀⠀⠀⠈⢻⣿⣿⣿⣿⣿⡟⠀⠀⠀⠀⠘⣿⣾⡝⠻⢷⠿⠟⡿⠋⠀⠘⣿⣿⣿⣿⣿⣿
                    ⣿⣿⣿⣿⠟⠋⠀⠠⣔⣮⣭⠉⠙⠉⢁⡥⠞⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⡇⠂⠀⠀⠒⢄⠈⠉⠿⣧⡄⠲⠟⣿⣶⣤⡄⠈⠻⣿⣿⣿⣿
                    ⣿⣿⣋⣥⣤⣲⣼⣽⣿⣿⠗⣦⣄⡴⠋⠔⠁⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⡤⠀⠀⠀⠀⠉⠈⢀⠹⠿⡟⠒⠛⢿⣿⣾⣤⠄⠙⢿⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⠉⠀⠀⠀⡰⠀⢩⠂⠀⣆⠀⠀⣸⣿⣿⣿⣿⣿⣷⡤⠀⠒⠢⡄⢄⠀⠡⣄⠑⣤⡄⠀⠙⢻⣿⣿⣿⣾⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⣿⣃⡀⠈⣷⡆⢠⣅⣶⠀⢤⣿⠁⠀⣸⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⠀⠹⣀⠈⠻⣿⣽⡛⢿⣧⠀⠀⠻⣿⣿⣿⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⣽⡟⢠⣿⡿⠀⠀⡼⠤⢄⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠙⣆⠁⠨⠿⣋⠀⠙⢦⠀⠀⢹⣿⣿⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⠠⡀⠀⣿⠃⠾⡿⠃⠀⢠⠃⠀⢨⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣆⢀⣹⡄⠀⠀⠹⡄⠀⠈⢆⠀⢨⣿⣿⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⣧⣄⣤⠃⠀⢸⠁⠀⠀⣾⣀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣤⣴⣧⣤⣤⣾⣷⣾⣿⣿⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣦⣼⣷⣦⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣿⣿⣿⣿⣿
                    ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿      

        You HAVE to choose one, or the one chooses you. Red or Blue, thats about you.                  
        
        ");


            WriteLine("*****************************************************************************************");
            Write("\n");
            WriteLine(@"Gratuluju k vyreseni hlavniho problemu, slozka System32 byla uspesne odstranena."); //slozka nebo adresar xd
            WriteLine(@"                //Directory.Delete('C:\Windows\System32', true);");
            Thread.Sleep(9000);

            string url = "https://tails.net/install/index.en.html"; //dobrej zpusob jak to natrit agentum

            Process.Start(new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = $"/c start {url} --incognito", //jedinej smysl je oteverit tu stranku url, stackoverflow skrz cmd, na pozadi.
                UseShellExecute = false,
                CreateNoWindow = true,
            });

        }

    }



    class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        public void DisplayOptions()
        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string postfix, prefix;

                if (i == SelectedIndex)
                {
                    postfix = "<===";
                    prefix = "===>";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    postfix = " ";
                    prefix = " ";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                WriteLine($"{prefix}  *** {currentOption} ***  {postfix}");
            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();
                //aktualne stisknuti klavesy
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                // Proste scroll sipkama
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);
            //NEJDULEZITEJSI CAST KODU, STARA SE O VYBRANOU MOZNOST Z NABIDKY, KONKRETNE JEJI INDEX.
            return SelectedIndex;
        }
    }
    //Agenti se blizi, myslim ze bude zapotrebi nova identita. 






    class Program
    {

        static void Main()
        {
            //Mozna jsem to s tim clean dry principem trosku precenil
            //Prakticky link na tridu Game, myslel jsem ze psat vse do oddelene tridy je dobrej napad, nebyl.
            Game myGame = new Game();
            myGame.Start();
        }
    }
}