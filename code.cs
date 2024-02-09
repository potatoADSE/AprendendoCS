using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace myfirstprogram;

public class MyFirstProgramCS {
    static void Main(String[] args) {

        Console.WriteLine ("Qual operacao deseja efetuar?");
        Console.WriteLine ("1 - Adicao");
        Console.WriteLine ("2 - Subtracao");
        Console.WriteLine ("3 - Multiplicacao");
        Console.WriteLine ("4 - Divisao");
        
        int numberone = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite o primeiro numero:");
        int numbertwo = int.Parse(Console.ReadLine());

        Console.WriteLine ("Digite o segundo numero:");
        int numbertree = int.Parse(Console.ReadLine());

        int resutado;

        switch (numberone) {
          case 1: {
            resutado = Add(numbertwo, numbertree);
            Console.WriteLine("Resutado:");
            Console.WriteLine(resutado);
            break;
          }
          case 2: {
            resutado = Sub(numbertwo, numbertree);
            Console.WriteLine("Resutado:");
            Console.WriteLine(resutado);
            break;
          }
          case 3: {
            resutado = Mut(numbertwo, numbertree);
            Console.WriteLine("Resutado:");
            Console.WriteLine(resutado);
            break;
          }
          case 4: {
            resutado = Div(numbertwo, numbertree);
            Console.WriteLine("Resutado:");
            Console.WriteLine(resutado);
            break;
          }

        }
    }

    public static int Add(int numbertwo, int numbertree) {
      int result = numbertree + numbertwo;
      return result;
    }

    public static int Sub(int numbertwo, int numbertree) {
      int result = numbertwo - numbertree;
      return result;
    }
    public static int Mut(int numbertwo, int numbertree) {
      int result = numbertwo * numbertree;
      return result;
    }

    public static int Div(int numbertwo, int numbertree) {
      int result = numbertwo / numbertree;
      return result;
    }

    } 


