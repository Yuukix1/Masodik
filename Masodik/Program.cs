using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodik
{
    class Program
    {
        static void Main(string[] args)
        {
                string jelszo;

                while (true)
                {
                    
                    Console.Write("Kérem, adja meg a jelszót: ");
                    jelszo = Console.ReadLine();

                    
                    if (IsValidPassword(jelszo))
                    {
                        Console.WriteLine("Jelszó elfogadva!");
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("A jelszó nem felel meg a következő kritériumoknak:");
                        Console.WriteLine("- Legalább 8 karakter hosszú");
                        Console.WriteLine("- Tartalmaz legalább egy számot");
                        Console.WriteLine("- Tartalmaz legalább egy nagybetűt");
                    }
                }
            }

            
            static bool IsValidPassword(string password)
            {
                
                if (password.Length < 8)
                {
                    return false;
                }

                
                bool containsNumber = false;
                bool containsUpperCase = false;

                foreach (char c in password)
                {
                    if (char.IsDigit(c))
                    {
                        containsNumber = true;
                    }
                    if (char.IsUpper(c))
                    {
                        containsUpperCase = true;
                    }
                }

                return containsNumber && containsUpperCase;
            }
        }

    }
