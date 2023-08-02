Console.WriteLine("Ingresa el primer texto");
string texta = Console.ReadLine();
Console.WriteLine("Ingresa el segundo texto");
string textb = Console.ReadLine();

int distancia = 0;
if(texta.Length != textb.Length)
{
    throw new Exception("Longitud distacia");
}
for(int i = 0;i< texta.Length; i++)
{
    if (texta[i] != textb[i])
    {
        distancia++;
    }
}
Console.WriteLine(distancia);
