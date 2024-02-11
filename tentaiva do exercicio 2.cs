using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace mediacalculator;
public class MediacalculatorCLASS {
  static void Main(string[] args) {

    Console.WriteLine("Qual a quantidade de numeros deseja calcular a media?\nPor favor escolha de 3 a 10.");

    int all = int.Parse(Console.ReadLine());
    float[] all2 = new float[all];

    foreach (float all3 in all2) {

      Console.WriteLine("\nQuais o numeros?");
      float numbers = float.Parse(Console.ReadLine());
      
    } 
  }
}
