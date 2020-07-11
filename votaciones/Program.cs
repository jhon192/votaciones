using System;

namespace votaciones
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear una aplicación para un sistema de votaciones. 
                Caracteristicas:
                - Cantidad de candidatos 4
                - Cantidad de votos 1,000, estos seran de forma aleatoria.
                - Los resultados se mostraran (Total de votos por candidatos, % de votos acumulados y Ordenados descendente).
                - El sistema es tipo consola en C#.
                - Datos candidato: Partido, Nombre completo, poscición a la que aspira (presidente).
                - Partidos: Fecha de fundacion (ficticia), Nombre completo y siglas*/

            Console.WriteLine("SISTEMA DE VOTACION");
            string cand1 = "1- Jose Feliciano,\n Partido Democrata Social (PDS) 1987,\n Aspirante a Presidente";
            string cand2 = "2- Juan Martez,\n Partido Conservador Dominicano (PCD) 1998,\n Aspirante a Presidente";
            string cand3 = "3- Miguel Baez,\n Partido Alianza del Pueblo (PAP) 1967,\n Aspirante a Presidente";
            string cand4 = "4- Tony Vasquez,\n Partido Social Dominicano (PSD) 1945,\n Aspirante a Presidente";
            Console.WriteLine("Candidatos disponible son: ");
            Console.WriteLine("\n {0} \n {1} \n {2} \n {3}", cand1, cand2, cand3, cand4);
            Console.WriteLine("\n debes votar por los numero delante de los candidatos");
            Console.Write("\n Por Cual usted desea Votar:? ");
            Random rnd = new Random();
            int tombola = 1000;
            var final = rnd.Next(tombola);
            int percentComplete = (int)Math.Round((double)(100 * final) / 1000);
            var final2 = rnd.Next(tombola);
            int percentComplete2 = (int)Math.Round((double)(100 * final2) / 1000);
            var final3 = rnd.Next(tombola);
            int percentComplete3 = (int)Math.Round((double)(100 * final3) / 1000);
            var final4 = rnd.Next(tombola);
            int percentComplete4 = (int)Math.Round((double)(100 * final4) / 1000);
            string elegir = Console.ReadLine();

            if (elegir == "1")
            {
                Console.WriteLine("Has votado por {0}", cand1);
            }
            
            else if (elegir == "2")
            {
                Console.WriteLine("Has votado por {0}", cand2);
            }
            
            else if (elegir == "3")
            {
                Console.WriteLine("Has votado por {0}", cand3);
            }
            
            else if (elegir == "4")
            {
                Console.WriteLine("Has votado por {0}", cand4);
            }

            else
            {
                Console.WriteLine("Hubo un error");
            }
            
            Console.WriteLine("El candidato 1 ha sacado un total de votos de {0}, {1}%", final, percentComplete);
            Console.WriteLine();
            Console.WriteLine("El candidato 2 ha sacado un total de votos de {0}, {1}%", final2, percentComplete2);
            Console.WriteLine();
            Console.WriteLine("El candidato 3 ha sacado un total de votos de {0}, {1}%", final3, percentComplete3);
            Console.WriteLine();
            Console.WriteLine("El candidato 4 ha sacado un total de votos de {0}, {1}%", final4, percentComplete4);

            if (final>final2 && percentComplete>percentComplete2 &&  final>final3 && percentComplete>percentComplete3
                && final>final4 && percentComplete>percentComplete4 )
            {
                Console.WriteLine();
                Console.WriteLine("Ha ganado el candidato {0} \n con un porcentaje de {1}%", cand1, percentComplete);
            }
            
            else if (final2>final && percentComplete2>percentComplete &&  final2>final3 && percentComplete2>percentComplete3
                     && final2>final4 && percentComplete2>percentComplete4)
            {
                Console.WriteLine();
                Console.WriteLine("Ha Ganado el candidato {0} \n con un porcentaje de {1}%", cand2, percentComplete2);
            }
            
            else if (final3>final && percentComplete3>percentComplete && final3>final2 && percentComplete3>percentComplete2
                     && final3>final4 && percentComplete3>percentComplete4)
            {
                Console.WriteLine();
                Console.WriteLine("Ha ganado el candidato {0} \n con un porcentaje de {1}%", cand3, percentComplete3);
            }
            
            else if (final4>final2 && percentComplete4>percentComplete2 &&  final4>final3 && percentComplete4>percentComplete3
                     && final4>final && percentComplete4>percentComplete)
            {
                Console.WriteLine();
                Console.WriteLine("Ha Ganado el candidato {0} \n con un porcentaje de {1}%", cand4, percentComplete4);
            }

            Console.ReadKey();
        }
    }
}