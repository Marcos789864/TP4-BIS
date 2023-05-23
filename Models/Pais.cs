public  class Pais
{
    public  string Nombre {get;set;}
    public  string ImgBandera {get;set;}
    public  int Poblacion {get;set;}
    public  DateTime FechaIndependencia {get;set;}
    public  string AtractivoTuristicos {get;set;}

    public Pais()
    {

    }

    public Pais(string N,string imgB,int P,DateTime FI,string atrT)
    {
        Nombre = N;
        ImgBandera = imgB;
        Poblacion = P;
        FechaIndependencia = FI;
        AtractivoTuristicos= atrT ;
    }


}