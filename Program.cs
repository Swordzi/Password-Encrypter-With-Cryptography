
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Timers;
using System.Text.RegularExpressions;


namespace Convo
{

  






   
    public class Convo
    {


      

        public static void Main(string[] args)
        {
          
            //Asks for password and reads the line
            Console.WriteLine("Please insert a password pls paavo sano salasana :D");
            string password = Console.ReadLine();
            
            //Converts the password into text
            var text = password;

           

            //Encrypted and decrypted text
            var encryptedText = Encrypter.Encrypter.EncryptPlainTextToCipherText(text);
            var decryptedText = Decrypter.Decrypter.DecryptCipherTextToPlainText(encryptedText);
            
            //Writes to the console the entered password and it encrypted and after decrypting to see if the decryption worked
            Console.WriteLine("Passed Text = " + text);
            Console.WriteLine("EncryptedText = " + encryptedText);
            Console.WriteLine("DecryptedText = " + decryptedText);
            Console.ReadLine();
            
        }

        
        //The security key from the cryptography randomizer (Randomizer.cs)
        public static string SecurityKey = Randomizer.Key.randomizer();

       
      
        }

    }

   






