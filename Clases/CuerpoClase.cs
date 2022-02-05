using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /*------------------------------CUERPO DE LA CLASE-----------------
     Ele cuerpo de la clase puede incluir instrucciones cuya funcion se incluya en una de estas categorias
        * Cnostantes 
        * Campos
        * Metodos
        * Propiedades
        * Eventos (Tema avanzado)
        * Indizadores (Tema avanzado)
        * Operadores
        * Constructores
        * Destructores
        * Tipos
     */
    internal class CuerpoClase
    {
        /* ------------------ CONSTANTES -----------------------
        Las cosntantes de clase son variables cuyo valor no cambia
        */

        //Declaracion de constantes
        public const double Pi = 3.14159265;

        //Declaracion de constantes en una linea
        public const int One = 1, Two = 2, Three = 3;

        /* -------------------- CAMPOS ---------------------------
          Son variables que pertenecen a una clase que gestionan su estado. Se pueden acceder
        a los campos definidos en una clase mediante mediante cualquier metodo definido en
        la misma clase
         */

        //Declarar campo sin valor inicial (Null safety)
        public int Campo1;

        //Declarar campo con valor inicial
        public int Campo2 = 895;

        /*
          Campo de solo lectura (readonly) solo se puede establecer su valor en la declaracion o contructor de la clase
          La diferencia entre readonly y una constante es que el valor de las constantes debe de establecerse en tiempo
          de compilacion (Debe recibir su valor cuando se escribe el codigo) y los campos de solo lectura pueden obtener
          su valor en tiempo de ejecucion
         */
        public readonly int campo3 = 5;

        /* ------------------------PROPIEDADES -----------------------------------------
         Miembros identificados que proporcionan acceso al estado de un objeto. Las propiedades tienen un tipo y 
         un identificador y tienen uno o dos fragmentos de codigo asociados a ellos: una base de codigo get y 
         una base de codigo set. Estas bases reciben el nombre de descriptores de acceso.
         Cuando el cliente accede a una prpiedad se ejecuta GET y cuando el cliente establece un nuevo valor
         para la propiedad se ejecuta SET
        */

        private int XCoordinate;
        public int x
        {
            //GET solamente devuelve el valor del campo
            get { return XCoordinate; }

            //SET valida y establece un valor al campo
            set
            {
                if((value >= 0) && (value < 640))
                {
                    XCoordinate = value;
                }
                else
                {
                    XCoordinate = 640;
                }
            }
        }

        private int YCoordinate;
        public int y
        {
            get { return YCoordinate; }
            set { YCoordinate = value; }
        }

        public int CoordenadasX { get; set; }
        public int CoordenadasY { get; set; }
    }
}
