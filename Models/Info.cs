public static class info
{
   
     private static List<Pais> ListaPaises =  new List<Pais>();


   private static void InicializarLista()
   {
    Pais Argentina = new Pais("Argentina","arg.jpg",46000000,new DateTime(1816,7,9),"Cerro de los 7 colores");
    Pais Bolivia = new Pais("Bolivia","bolivia.jpg",12080000,new DateTime(1825,1,29),"Cementerio de Trenes");
    Pais Chile = new Pais("Chile","chile.jpg",19490000,new DateTime(1818,2,12),"Valle de la Luna");
    Pais Paraguay = new Pais("Paraguay","paraguay.jpg",6704000,new DateTime(1842,11,25),"Cerro Kandú");
    Pais Surinam = new Pais("Surinam","surinam.jpg",612985,new DateTime(1975,11,25),"Volcanes,Playas,Parques naturales");

    ListaPaises.Add(Argentina);
    ListaPaises.Add(Bolivia);
    ListaPaises.Add(Chile);
    ListaPaises.Add(Paraguay);
    ListaPaises.Add(Surinam);

   }

   public static List<Pais> ListarPaises()
   {
        if( ListaPaises.Count == 0)
        {
           InicializarLista();
           return ListaPaises;
        }
        else
        return ListaPaises;

   }

   public static Pais BuscarPais(string Paises)
   {
     Pais p = new Pais();
        for(int i = 0; i < ListaPaises.Count;i++)
        {
            if(ListaPaises[i].Nombre == Paises)
            {
               
                p = ListaPaises[i];
                return p;
            }
        }
           return p;
   }
}
