using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonas
{
    class Persona
    {
        //String S mayuscula Trae varias funciones con el punto
        //string s minuscula  solo es para declarar variable
        //Campos y Propiedades
        //Campos, Privasdos para cumplir con el encapsulado
     public  string dpi;
     public string nombre;
     public  string apellido;
     public DateTime fechaNacimiento; //Calme case separa las palabras 
        int otroDato;

        //Encapsulado
        public string Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int OtroDato { get => otroDato; set => otroDato = value; }
        //ctor constructor de la clase codigo que se ejecuta al crear un objeto de esta clase
     

        public Persona()
        {
           dpi = " ";
           nombre = " ";
           apellido = " ";
           fechaNacimiento = DateTime.Now;
        }

        //Propiedades
        //get  obtiene ek valor 
        //a = DPI;

        // set cuando se le asigna un valor 

        //Metodos Acciones que se realizan

        public void PrimeraMayus()
        {
            if(nombre.Length > 0)
            {
                StringBuilder nombreMayus = new StringBuilder(nombre);
                nombreMayus[0] = char.ToUpper(nombreMayus [0]);
                nombre = nombreMayus.ToString();
               
            }

            if(apellido.Length > 0)
            {
                StringBuilder apellidoMayus = new StringBuilder(apellido);
                apellidoMayus[0] = char.ToUpper(apellidoMayus[0]);
                apellido = apellidoMayus.ToString();
            }
            
        }

        public int edad()
        {

            // Calcular la edad
            int edad = 0;
            int mesNacimento = fechaNacimiento.Month;
            int añoNacimiento = fechaNacimiento.Year;
            int diaNacimiento = fechaNacimiento.Day;

            int mesAct = DateTime.Now.Month;
            int añoAct = DateTime.Now.Year;
            int diaAct = DateTime.Now.Day;

            if((diaAct >= diaNacimiento) && (mesAct >= mesNacimento))
            {
                edad = añoAct - añoNacimiento;
            }
            else
            {
                edad = (añoAct - añoNacimiento) - 1;
            }

            return edad;
        }

        public void NormalizarNombre()
        {
            // Eliminar espacios en blanco al inicio y al final
            nombre = nombre.Trim();
            apellido = apellido.Trim();

            // Eliminar símbolos que no sean letras al inicio y al final del nombre
            nombre = new string(nombre.Where(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)).ToArray());
            apellido = new string(apellido.Where(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)).ToArray());

            // Dejar el nombre con formato propio (primera letra mayúscula en cada nombre y apellido)
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            nombre = textInfo.ToTitleCase(nombre);
            apellido = textInfo.ToTitleCase(apellido);
        }

        public void normalizaNombre()
        {

        }

    }
}
