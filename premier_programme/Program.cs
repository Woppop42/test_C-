// See https://aka.ms/new-console-template for more information
using System;

namespace premier_programme // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string name = "";
           while(name.Length < 3)
            {
                // Méthode afficahnt un string : 
                Console.WriteLine("Quel est ton nom ?");

                // Méthode permettant de saisir un string directement dans la console :
                name = Console.ReadLine();
                name = name.Trim();
                if(name.Length < 3)
                {
                    Console.WriteLine("Votre nom doit comporter au moins 3 caractères !");
                }
            }
            
            int age_int = 0;

            while (age_int <= 0)
            {
                Console.WriteLine("Quel âge as-tu ?");

                string age_str = Console.ReadLine();

                

                try
                {
                    // int.Parse() permet de convertir un nombre initialement en string en int :
                    age_int = int.Parse(age_str);
                    if(age_int < 0)
                    {
                        Console.WriteLine("Votre âge ne doit pas être négatif !");
                    }
                    if(age_int == 0)
                    {
                        Console.WriteLine("L'âge ne doit pas être égal à zéro !");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur !! Vous devez rentrer un âge valide !");
                }
            }
            Console.WriteLine("Bonjour et bienvenue " + name + " !" + " Vous avez " + age_int + " ans.");

            int age_prochain = age_int + 1;
            Console.WriteLine("Vous aurez bientôt " + age_prochain + " ans.");
        }
    }
 }

    
