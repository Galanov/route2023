using System.Text;

int count;
StringBuilder outMessage = new StringBuilder();


count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    var countProd = int.Parse(Console.ReadLine());
    var arrProd = getArrFromString(Console.ReadLine());
    Dictionary<int, int> products = getDictionaryProducts(arrProd);
    var total = 0;
    foreach (var p in products)
    {
        var discont = p.Value / 3;
        total += p.Key * (p.Value - discont);
        
    }
    outMessage.AppendLine(total.ToString());
}
Console.Write(outMessage);

int[] getArrFromString(string str)
{
    var arr = str.Split(' ').Select(s => int.Parse(s)).ToArray();
    return arr;
}

Dictionary<int, int> getDictionaryProducts(int[] products)
{
    Dictionary<int, int> dictProducts = new Dictionary<int, int>();
    foreach (var p in products)
    {
        if (dictProducts.ContainsKey(p))
        {
            dictProducts[p]++;
        }
        else
        {
            dictProducts.Add(p, 1);
        }
    }
    return dictProducts;
}