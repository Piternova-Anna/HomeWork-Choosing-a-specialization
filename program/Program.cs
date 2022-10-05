string[]Massiv = new string[5] { "one", "two", "three", "four", "five"};
Console.Write("Дан массив из 5 элеменов:");
Console.WriteLine("["+Massiv[0]+", "+Massiv[1]+", "+ Massiv[2]+", "+ Massiv[3]+", "+ Massiv[4]+"]");
int quantity = 0;
for (int i = 0; i < Massiv.Length; i++)
{
    if (Massiv[i].Length <= 3)
    {
        quantity++;
    }
}
Console.WriteLine("в данном массиве элементов с количеством символов меньше или равное 3: "+quantity);

string[] ResultMassiv = new string[quantity];
int j = 0;
Console.Write("новый массив: [");
for (int i = 0; i < Massiv.Length; i++)
{
    if (Massiv[i].Length <= 3)
    {
        ResultMassiv[j] = Massiv[i];
        
        Console.Write(ResultMassiv[j]+",");
        j++;
    }
}
Console.WriteLine("]");