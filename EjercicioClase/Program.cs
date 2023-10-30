
Console.WriteLine("La Banda de Superheroes");
Console.WriteLine("");
/**SuperPoder*/
SuperPoder poder = new SuperPoder();
SuperPoder poder1 = new SuperPoder();
SuperPoder poder2 = new SuperPoder();
/**Heroes*/
SuperHeroe heroe = new SuperHeroe();
SuperHeroe heroe1 = new SuperHeroe();
SuperHeroe heroe2 = new SuperHeroe();

Console.WriteLine("Heroe 1");
heroe.Nombre = "MUSICMAN";
heroe.Identidadsecreta = "Jimmy Hendrix";
heroe.Ciudad = "Metrociudad";
heroe.puedevolar = true;
poder.nombre = "Supermusica";
poder.descripcion = "Toca cualquier guitarra";
poder.nivel = 10;

Console.WriteLine("Nombre :" + heroe.Nombre);
Console.WriteLine("Identidadsecret :" + heroe.Identidadsecreta);
Console.WriteLine("Ciudad :" + heroe.Ciudad);
Console.WriteLine("Puedevolar :" + heroe.puedevolar);
Console.WriteLine("Nombre Poder :" + poder.nombre);
Console.WriteLine("Descripcion :" + poder.descripcion);
Console.WriteLine("Nivel :" + poder.nivel);
Console.WriteLine("");
Console.WriteLine("");
/* Heroe 2*/
Console.WriteLine("Heroe 2");
heroe1.Nombre = "BASSMAN";
heroe1.Identidadsecreta = "Cliff Burton";
heroe1.Ciudad = "Manhattan";
heroe1.puedevolar = false;
poder1.nombre = "Bajos salvajes";
poder1.descripcion = "Los bajos mas poderosos";
poder1.nivel = 12;

Console.WriteLine("Nombre :" + heroe1.Nombre);
Console.WriteLine("Identidadsecret :" + heroe1.Identidadsecreta);
Console.WriteLine("Ciudad :" + heroe1.Ciudad);
Console.WriteLine("Puedevolar :" + heroe1.puedevolar);
Console.WriteLine("Nombre Poder :" + poder1.nombre);
Console.WriteLine("Descripcion :" + poder1.descripcion);
Console.WriteLine("Nivel :" + poder1.nivel);
Console.WriteLine("");
Console.WriteLine("");
/* Heroe 3*/
Console.WriteLine("Heroe 3");
heroe2.Nombre = "DRUMMERMAN";
heroe2.Identidadsecreta = "John Bonham";
heroe2.Ciudad = "Nueva York";
heroe2.puedevolar = true;
poder2.nombre = "Melodia de destruccion";
poder2.descripcion = "Con sus brutales tecnicas sorprende a todos  ";
poder2.nivel = 15;

Console.WriteLine("Nombre :" + heroe2.Nombre);
Console.WriteLine("Identidadsecret :" + heroe2.Identidadsecreta);
Console.WriteLine("Ciudad :" + heroe2.Ciudad);
Console.WriteLine("Puedevolar :" + heroe2.puedevolar);
Console.WriteLine("Nombre Poder :" + poder2.nombre);
Console.WriteLine("Descripcion :" + poder2.descripcion);
Console.WriteLine("Nivel :" + poder2.nivel);

public class SuperHeroe
{
    public string Nombre { get; set; }

    public string Identidadsecreta { get; set;}

    public string Ciudad {  get; set;}

    public bool puedevolar { get; set;}

    



    public SuperHeroe()
    {
        puedevolar = true;

    }


}

public class SuperPoder
{
    public string nombre { get; set; }

    public string descripcion { get; set; }

    public int nivel { get; set; }
}





