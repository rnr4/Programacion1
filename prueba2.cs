using System;

public class Programa
{
    public static void Main()
    {

        string datos = "";
        int edad = 0;
        double altura = 0.0;


        Console.WriteLine("Hola, por favor ingrese su edad: ");
        datos = Console.ReadLine();
        edad = Convert.ToInt32(datos);


        if (edad >= 18 || edad<= 4)
            Console.WriteLine("Disculpe, la edad apropiada para entrar al parque es entre los 5 y 17.");
        else
        {

            Console.WriteLine("Bienvenido!!!");
            Console.WriteLine("Por favor indique su altura en metros, ejemplo: '1.7'");
            datos = Console.ReadLine();
            altura = Convert.ToDouble(datos);

            if (altura < 1.6)
                Console.WriteLine("Puede entrar a la casa encantada, el gusanito y el carrusel");
            else
            {
                Console.WriteLine("Puede entrar a la casa encantada, el gusanito, el carrusel y a la montaña rusa");
            }
            
        }


        Console.ReadKey();        
    }
}
