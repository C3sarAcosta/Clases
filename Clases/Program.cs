using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /*-----------------------DECLARACION DE UNA CLASE-------------------------
     class NombreDeLaClase
    {
        ..........
    }
     */
    internal class Program
    {
        /*
         Cada aplicacion en C# debe contener un método llamado main
        Esto es el punto de entrada para que la aplicacion se ejecute. 
        Lo podemos colocar en cualquier parte de la clase
         */ 

        /*
         Para aceptar parametros de linea de comando
         */
        static void Main(string[] args)
        {
            //Instanciamos la clase CuerpoClase
            CuerpoClase MyPoint = new CuerpoClase();
            //Establecemos los valores de las propiedades (SET)
            MyPoint.x = 100;
            MyPoint.y = 150;
            //Obtenemos el valor de las propiedades (GET)
            Console.WriteLine(MyPoint.x);
            Console.WriteLine(MyPoint.y);
            int valorX = MyPoint.x;

            Console.WriteLine("Cambiamos los valores de las propiedades");
            MyPoint.x = 750;
            MyPoint.y = 750;
            Console.WriteLine(MyPoint.x);
            Console.WriteLine(MyPoint.y);

            

            //Instanciar clase y constructores
            CuerpoClaseConstructor MiPrimerPunto = new CuerpoClaseConstructor();
            CuerpoClaseConstructor MiSegundoPunto = new CuerpoClaseConstructor(true);
            CuerpoClaseConstructor MiTercerPunto = new CuerpoClaseConstructor(false);
            CuerpoClaseConstructor MiCuartoPunto = new CuerpoClaseConstructor(756, 123);



            Console.ReadKey();
        }
    }
}
