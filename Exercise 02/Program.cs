using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] str = new String[20];
            str[0] = "EnglishMarket01#";
            str[1] = "SaintFinBarRes2#";
            str[2] = "BrockCastle03$";
            str[3] = "ShandonBeLls04$";
            str[4] = "CorkGhostTour05?";
            str[5] = "TriskelArts06?";
            str[6] = "ModelRailway%07";
            str[7] = "CrosShaven%08";
            str[8] = "GarnishIsland-09";
            str[9] = "LoughHyne-10";
            str[10] = "TheLough1+1";
            str[11] = "BaLlymaloe+12";
            str[12] = "Inchydoney@13";
            str[13] = "LiscarRolL@14";
            str[14] = "Baltimore^15";
            str[15] = "CobhQueEnstown^6";
            str[16] = "FotaWildlife&17";
            str[17] = "CapeClear&18";
            str[18] = "CamdenFort:19";
            str[19] = "GouganeBaRra:20";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("Password: " + str[i] + " is valid: " + Password.isPassword(str[i]) + "\n");
            }

            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("\nInvalid Passwords");
            Console.WriteLine("\n--------------------------------------------------\n");
            String[] notPasswords = new String[9];
            notPasswords[0] = ""; // min of 8 characters
            notPasswords[1] = "Abcdefg"; // min of 8 characters            
            notPasswords[2] = "Abcdefghijklmnopr"; // max of 16 characters
            notPasswords[3] = "abcdefgh"; // at least one upper case
            notPasswords[4] = "ABCDEFGH"; // at least one lower case
            notPasswords[5] = "Abcdefghijklmnop"; // at least one number
            notPasswords[6] = "Abcdefghijklmno2"; // at least one symbol or special character
            notPasswords[7] = "AAcdefgh jklmn#2"; // no whitespace
            notPasswords[8] = "AAcdefghijklmn#2"; // no consecutive identical characters
            for (int i = 0; i < notPasswords.Length; i++)
            {
                bool validPassword = Password.isPassword(notPasswords[i]);
                Console.WriteLine("Password: " + notPasswords[i] + " is valid: " + validPassword + "\n");
                if (!validPassword)
                {
                    Console.WriteLine(Password.getLastErrorMessage() + "\n");
                }
            }


            Console.ReadLine();
        }
    }
}
