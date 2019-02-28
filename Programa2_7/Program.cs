using System;
using System.Collections.Generic;

namespace Programa2_7
{
    class Dado //Clase Dado
    {
        //Atributos
        private int valor; 
        private string color;

        public Dado(int valor) //Constructor Dado
        {
            this.valor=valor;
        }

        public Dado(int valor,string color) //Constructor sobrecargado
        {
            this.color=color;
            this.valor=valor;
        }

        //Método que compare y lo regrese en booleano

        public static bool operator <(Dado a, Dado b)
        {
            return(a.valor.CompareTo(b.valor) <0);
        }

        public static bool operator >(Dado a, Dado b)
        {
            return(a.valor.CompareTo(b.valor) >0);
        }

        public static bool operator ==(Dado a, Dado b)
        {
            return(a.valor.CompareTo(b.valor) == 0);
        }

        public static bool operator !=(Dado a, Dado b)
        {
            return(a.valor.CompareTo(b.valor) != 0);
        }

         public override int GetHashCode()  
        {  
            return 0;  
        } 

        public override bool Equals(object o)  
        {  
            return true;  
        }  
        public void imprimedado() //Método para imprimir
        {
            Console.WriteLine("El dado de color {0} tiene el numero {1}",color,valor);
        }

        public void mejordado()
        {
            Console.WriteLine("------------------------------------------------"+
            "El mejor dado es de color {0} y tiene el numero {1}"+
            "-------------------------------------------------",color,valor);
        }
         public void mejordadoigual()
        {
            Console.WriteLine("------------------------------------------------"+
            "Existen dos mejores dados con el numero {0}"+
            "-------------------------------------------------",valor);
        }

          public void imprimedadosiguales()
        {
            Console.WriteLine("------------------------------------------------"
            +"Todos los dados son iguales y tienen el numero {0}"+
            "------------------------------------------------",valor);
        }


    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random(); //Numero aleatorio, mas adelante se pondra el minimo y maximo (1,6)

            Dado a = new Dado(random.Next(1, 6), ("Morado")); //Creando nuevos dados
            Dado b = new Dado(random.Next(1, 6), ("Rojo"));
            Dado c = new Dado(random.Next(1, 6), ("Negro"));

            a.imprimedado();
            b.imprimedado();
            c.imprimedado();

            if (a==b && a == c)
            {
                a.imprimedadosiguales(); 
            }
            else
            {
                if (a>b && a > c)
                {
                    a.mejordado();
                }
                else
                {
                    if (b > a && b > c)
                    {
                        b.mejordado();
                    }
                    else
                    {
                        if (c > a && c > b)
                        {
                            c.mejordado();
                        }
                        else
                        {
                            if (a == b || a == c)
                            {
                                a.mejordadoigual();
                            }
                            else
                            {
                                if (b == c)
                                {
                                    b.mejordadoigual();
                                }
                            }
                        }
                    }
                }
            }

        }
    }

}
}

