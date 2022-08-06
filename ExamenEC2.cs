using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEsC.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try // Implementar excepciones
            {
                while (true) // Estructura repetitiva clico while infinito
                {
                    // Declaracion de variables
                    string nom,ape, mensaje, game, gameName = null, fechaEst = null;
                    int numAle, gameCant;
                    double price = 0, costTot, valEur, costPesos, valNet = 0, valIva, valDto, valAct;
                    // Declaracion de constantes
                    const double iva = 0.19;
                    const double dsto = 0.3535;
                    const int saldIni = 1000000;
                    do
                    {
                        Console.Write("\n Digite su nombre: ");
                        nom = Console.ReadLine().ToUpper();
                        Console.Write("\n Digite su apellido: ");
                        ape = Console.ReadLine().ToUpper();
                    } while (!(nom.Length > 3 && ape.Length > 3));

                    if (nom.Equals("N/A")) break;
                    Console.Clear();
                    Random r = new Random();
                    numAle = r.Next(0, 3);
                    mensaje = (numAle == 0 ? "\n BUENOS DIAS" : numAle == 1 ? "\n BUENAS TARDES" : "\n BUENAS NOCHES");
                    Console.WriteLine("\n" + mensaje + " " + nom + " " + ape);
                    Console.WriteLine("\n BIENVENID@ A LA TIENDA VÍDEO JUEGOS CSHARP !!!! ");
                    saldAct = (nom == "LISMAR" && ape == "OLIVEROS" ? saldIni+1000000 : saldIni);
                    Console.WriteLine($"\n Su saldo actual es: {saldAct:C2} ");
                    Console.WriteLine($"\t ");
                    do
                    {
                       Console.Write($"Digite el código del juego que desea adquirir: ");
                        game = Console.ReadLine().ToUpper();
                    } while (!(game.Equals("VJ-1001") || game.Equals("VJ-1002") || game.Equals("VJ-1005") || game.Equals("VJ-1009") || game.Equals("VJ-1010")));      
                    Console.Write($"Digite la cantidad que desea adquirir: ");
                    gameCant = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Ingrese el valor del EURO: ");
                    valEur = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    switch (game){
                            case "VJ-1001":
                                gameName = "Assassin's Creed: Origins";
                                price = 80.00;
                                fechaEst = "27/10/2022";  break;
                            case "VJ-1002":
                                gameName = "Call Of Duty WW II";
                                price = 30.50;
                                fechaEst = "03/11/2022"; break;
                            case "VJ-1005":
                                gameName = "Crash Bandicoot N-Sane Trilogy";
                                price = 23.33;
                                fechaEst = "30/06/2022"; break;
                            case "VJ-1009":
                                gameName = "Mario Odyssey";
                                price = 85.00;
                                fechaEst = "27/10/2022"; break;
                            case "VJ-1010":
                                gameName = "Super Bomberman R";
                                price = 66.67;
                                fechaEst = "03/03/2022"; break;
                        }
                    DateTime DateObject = Convert.ToDateTime(fechaEst);
                    costTot = price * gameCant;
                    costPesos = costTot * valEur;
                    Console.WriteLine($"\n ******* INFORMACION SOLICITADA ****************\n");
                    Console.WriteLine($"Nombre del vídeo Juego:          {gameName}");
                    Console.WriteLine($"Fecha de estreno:                {DateObject:D}");
                    Console.WriteLine($"Precio unitario en euros:        {price:C2}");
                    Console.WriteLine($"Costo total en euros:            {costTot:C2}");
                    Console.WriteLine($"Costo total en pesos:            {costPesos:C2}");
                    valIva = costPesos * iva;
                    valDto = costPesos * dsto;
                    valNet = costPesos + valIva - valDto;
                    valAct = saldAct - valNet;
                    if (valNet < saldAct)
                    {
                        Console.WriteLine($"Valor del IVA:                   {valIva:C2}");
                        Console.WriteLine($"Valor del descuento:             {valDto:C2}");
                        Console.WriteLine($"Valor neto:                      {valNet:C2}");
                        Console.WriteLine($"Valor despues de la compra:      {valAct:C2}");
                    }
                    else
                        Console.WriteLine($"\n DINERO NO ALCANZA");
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Error capturado: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
 }
