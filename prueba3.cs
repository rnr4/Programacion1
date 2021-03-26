using System;

public class Programa
{
    public static void Main()
    {
        string dato = "";
        double peso = 0.0;
        int ActividadPerro = 0;
        int MesesCachorro = 0;
        int opcion = 0;
        int perro = 0;
            
        
        do{
                
            Console.WriteLine("Bienvenid@ al Programa de Cuanto Debe Comer su Perro.\n\n");
                
            
            Console.WriteLine("Indique si su perro es Adulto o Cachorro:");
            Console.WriteLine(" 1) Adulto");
            Console.WriteLine(" 2) Cachorro (maximo 12 meses)");
            dato = Console.ReadLine();
            perro = Convert.ToInt32(dato);


            // Perro Adulto
            if(perro == 1){

                Console.WriteLine("\n¿Cual es el peso de su perro (kg)?");
                dato = Console.ReadLine();
                peso = Convert.ToDouble(dato);
                    
                Console.WriteLine("\n¿Como considera la actividad fisica de su mascota?");
                Console.WriteLine(" 1) Actividad Alta");
                Console.WriteLine(" 2) Actividad Normal");
                Console.WriteLine(" 3) Actividad Baja");
                dato = Console.ReadLine();
                ActividadPerro = Convert.ToInt32(dato);
                    
                    
                //Tamaño Miniatura
                if(peso <= 5 && peso >= 2) 
                {                        
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 60 - 115 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 55 - 100 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 45 - 85 gramos de alimento.");
                            break;
                    }                
                }
                    
                //Tamaño Pequeno
                if(peso <= 10 && peso >= 6) 
                {                        
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 115 - 190 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 100 - 170 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 85 - 145 gramos de alimento.");
                            break;
                    }                
                }
                    
                //Tamaño Mediano 1
                if(peso <= 15 && peso >= 11) 
                {                        
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 190 - 255 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 170 - 225 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 145 - 195 gramos de alimento.");
                            break;
                    }                
                }    

                //Tamaño Mediano 2
                if(peso <= 25 && peso >= 16) 
                {                        
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 255 - 380 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 225 - 330 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 195 - 285 gramos de alimento.");
                            break;
                    }                
                }
                    
                //Tamaño Mediano 3
                if(peso <= 40 && peso >= 26) 
                {                        
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 380 - 535 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 330 - 475 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 285 - 410 gramos de alimento.");
                            break;
                    }                
                }
                    
                //Tamaño Grande 1
                if(peso <= 55 && peso >= 41) 
                {                        
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 535 - 680 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 475 - 600 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 410 - 520 gramos de alimento.");
                            break;
                    }                
                }
                    
                //Tamaño Grande 2
                if(peso <= 70 && peso >= 56) 
                {                        
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 680 - 820 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 600 - 720 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 520 - 620 gramos de alimento.");
                            break;
                    }                
                }
                    
                //Tamaño Grande 3
                if(peso <= 90 && peso >= 71) 
                {                        
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 820 - 985 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 720 - 870 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 620 - 750 gramos de alimento.");
                            break;
                    }                
                }
            }


            // Perro Cachorro
            if(perro == 2){

                Console.WriteLine("\n¿Cual es el peso de su cachorro (kg)?");
                dato = Console.ReadLine();
                peso = Convert.ToDouble(dato);
                    
                Console.WriteLine("\n¿Cuantos meses tiene el cachorro (2 - 12)?");
                dato = Console.ReadLine();
                MesesCachorro = Convert.ToInt32(dato);

                if(MesesCachorro <= 12 && MesesCachorro >= 6){
                    MesesCachorro = 6;
                }


                //Miniatura
                if(peso <= 4 && peso >= 2) 
                {                        
                    switch (MesesCachorro) {
                        case 2:
                            Console.WriteLine("Su cachorro debe comer 50 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer 60 gramos de alimento.");
                            break;
                        case 4:
                            Console.WriteLine("Su cachorro debe comer 60 gramos de alimento.");
                            break;
                        case 5:
                            Console.WriteLine("Su cachorro debe comer 60 gramos de alimento.");
                            break;
                        case 6:
                            Console.WriteLine("Su cachorro debe comer 55 gramos de alimento.");
                            break;
                    }                
                }

                //Pequeno 1
                if(peso <= 9 && peso >= 5) 
                {                        
                    switch (MesesCachorro) {
                        case 2:
                            Console.WriteLine("Su cachorro debe comer 95 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer 110 gramos de alimento.");
                            break;
                        case 4:
                            Console.WriteLine("Su cachorro debe comer 115 gramos de alimento.");
                            break;
                        case 5:
                            Console.WriteLine("Su cachorro debe comer 115 gramos de alimento.");
                            break;
                        case 6:
                            Console.WriteLine("Su cachorro debe comer 110 gramos de alimento.");
                            break;
                    }                
                }

                //Pequeno 2
                if(peso <= 16 && peso >= 10) 
                {                        
                    switch (MesesCachorro) {
                        case 2:
                            Console.WriteLine("Su cachorro debe comer 155 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer 185 gramos de alimento.");
                            break;
                        case 4:
                            Console.WriteLine("Su cachorro debe comer 195 gramos de alimento.");
                            break;
                        case 5:
                            Console.WriteLine("Su cachorro debe comer 190 gramos de alimento.");
                            break;
                        case 6:
                            Console.WriteLine("Su cachorro debe comer 185 gramos de alimento.");
                            break;
                    }                
                }

                //Mediano 1
                if(peso <= 24 && peso >= 17) 
                {                        
                    switch (MesesCachorro) {
                        case 2:
                            Console.WriteLine("Su cachorro debe comer 215 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer 265 gramos de alimento.");
                            break;
                        case 4:
                            Console.WriteLine("Su cachorro debe comer 285 gramos de alimento.");
                            break;
                        case 5:
                            Console.WriteLine("Su cachorro debe comer 285 gramos de alimento.");
                            break;
                        case 6:
                            Console.WriteLine("Su cachorro debe comer 280 gramos de alimento.");
                            break;
                    }                
                }

                //Mediano 2
                if(peso <= 31 && peso >= 25) 
                {                        
                    switch (MesesCachorro) {
                        case 2:
                            Console.WriteLine("Su cachorro debe comer 270 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer 350 gramos de alimento.");
                            break;
                        case 4:
                            Console.WriteLine("Su cachorro debe comer 375 gramos de alimento.");
                            break;
                        case 5:
                            Console.WriteLine("Su cachorro debe comer 375 gramos de alimento.");
                            break;
                        case 6:
                            Console.WriteLine("Su cachorro debe comer 370 gramos de alimento.");
                            break;
                    }                
                }

                //Mediano 3
                if(peso <= 39 && peso >= 32) 
                {                        
                    switch (MesesCachorro) {
                        case 2:
                            Console.WriteLine("Su cachorro debe comer 300 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer 400 gramos de alimento.");
                            break;
                        case 4:
                            Console.WriteLine("Su cachorro debe comer 445 gramos de alimento.");
                            break;
                        case 5:
                            Console.WriteLine("Su cachorro debe comer 450 gramos de alimento.");
                            break;
                        case 6:
                            Console.WriteLine("Su cachorro debe comer 450 gramos de alimento.");
                            break;
                    }                
                }

                //Mediano 4
                if(peso <= 49 && peso >= 40) 
                {                        
                    switch (MesesCachorro) {
                        case 2:
                            Console.WriteLine("Su cachorro debe comer 355 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer 475 gramos de alimento.");
                            break;
                        case 4:
                            Console.WriteLine("Su cachorro debe comer 525 gramos de alimento.");
                            break;
                        case 5:
                            Console.WriteLine("Su cachorro debe comer 530 gramos de alimento.");
                            break;
                        case 6:
                            Console.WriteLine("Su cachorro debe comer 530 gramos de alimento.");
                            break;
                    }                
                }

                //Grande 1
                if(peso <= 59 && peso >= 50) 
                {                        
                    switch (MesesCachorro) {
                        case 2:
                            Console.WriteLine("Su cachorro debe comer 405 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer 545 gramos de alimento.");
                            break;
                        case 4:
                            Console.WriteLine("Su cachorro debe comer 610 gramos de alimento.");
                            break;
                        case 5:
                            Console.WriteLine("Su cachorro debe comer 625 gramos de alimento.");
                            break;
                        case 6:
                            Console.WriteLine("Su cachorro debe comer como un adulto, vuelva a comenzar por favor.");
                            break;
                    }                
                }

                //Grande 2
                if(peso <= 69 && peso >= 60) 
                {                        
                    switch (MesesCachorro) {
                        case 2:
                            Console.WriteLine("Su cachorro debe comer 450 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer 605 gramos de alimento.");
                            break;
                        case 4:
                            Console.WriteLine("Su cachorro debe comer 685 gramos de alimento.");
                            break;
                        case 5:
                            Console.WriteLine("Su cachorro debe comer como un adulto, vuelva a comenzar por favor.");
                            break;
                        case 6:
                            Console.WriteLine("Su cachorro debe comer como un adulto, vuelva a comenzar por favor.");
                            break;
                    }                
                }

                //Grande 3
                if(peso <= 89 && peso >= 70) 
                {                        
                    switch (MesesCachorro) {
                        case 2:
                            Console.WriteLine("Su cachorro debe comer 485 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer 670 gramos de alimento.");
                            break;
                        case 4:
                            Console.WriteLine("Su cachorro debe comer como un adulto, vuelva a comenzar por favor.");
                            break;
                        case 5:
                            Console.WriteLine("Su cachorro debe comer como un adulto, vuelva a comenzar por favor.");
                            break;
                        case 6:
                            Console.WriteLine("Su cachorro debe comer como un adulto, vuelva a comenzar por favor.");
                            break;
                    }                
                }

                //Grande 4
                if(peso == 90) 
                {                        
                    if(MesesCachorro == 2) {
                        Console.WriteLine("Su cachorro debe comer 580 gramos de alimento.");                            
                    }else
                    {
                        Console.WriteLine("Su cachorro debe comer como un adulto, vuelva a comenzar por favor.");

                    }       
                }
                
            }
                
                
            Console.WriteLine("\n\nSi Desea Volver al Inicio, Escriba 1\n Si Desea Salir, Escriba 4");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);
                
            Console.Clear();
                
                
        }while(opcion != 4);
                           
    }
}
