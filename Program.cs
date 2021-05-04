using System;

namespace ExemploRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
           

               Console.WriteLine("Bem vindo, qual a sua idade para saber sua categoria");
               int idade = int.Parse(Console.ReadLine());
               
                switch (idade)
                {
                    case 5: 
                    case 6:
                    case 7:
                    Console.WriteLine("Categoria : Infantil A");
                     break;
                    
                    case 8: 
                    case 9:
                    case 10:
                    Console.WriteLine("Categoria : Infantil B");
                     break;
                    
                    case 11: 
                    case 12:
                    case 13:
                    Console.WriteLine("Categoria : Juvenil A");
                     break;
                    
                    case 14: 
                    case 15:
                    case 16:
                    case 17:
                    Console.WriteLine("Categoria : Juvenil B");
                     break;


                    
                    default: Console.WriteLine("A sua idade é invalida para se inscrever");
                        break;
                }
                

                
                



                

                
                    

                    

                





                

            


        }
    }
}
