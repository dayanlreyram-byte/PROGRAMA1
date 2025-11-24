using System;
class Program
{
    static void Main (string []args)
    {
        
      Lobo lobito = new Lobo();
      lobito.Tipo ();
      lobito.Aullar();
      lobito.Icaza ();
      
      Perro perrito = new Perro();
      perrito.Tipo ();
      perrito.Ladrar();
    
    }
}