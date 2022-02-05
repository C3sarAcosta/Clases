using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class CuerpoClaseConstructor
    {
        public int x { get; set; }
        public int y { get; set; }

        /*
         Los constructores son metodos especiales que se ejecutan cuando se crea una instancia de la clase
        se pueden definir tantos constructores como se desee. Siempre que cada constructor tenga una lista
        de parametros diferentes
         */
        public CuerpoClaseConstructor()
        {
            Console.WriteLine("Solo me construyo");
        }

        public CuerpoClaseConstructor(int valorX, int valorY)
        {
            x = valorX;
            y = valorY;
            Console.WriteLine("Me construi con valores que me pasaste x = " + x + " y = " + y);
        }

        public CuerpoClaseConstructor(bool valoresDefault)
        {
            if (valoresDefault)
            {
                x = 150;
                y = 150;
            }
            else
            {
                x = 0;
                y = 0;
            }
            Console.WriteLine("Mi valor en x es: " + x);
            Console.WriteLine("Mi valor en y es: " + y);
        }

        // ~ Alt + 126 (Simbolo Virgulilla)
        /*-------------------------------------------DESTRUCTORES------------------------
         Destruyen objetos de la clase y se ejecuta cuando el recolector de objetos no utilizado
        destruye los objetos
        Los destructores no devuelven valores ni tampoco acepta parametros y no se pueden llamar
        mediante codigo
         */
        ~CuerpoClaseConstructor()
        {
        }
    }
}
