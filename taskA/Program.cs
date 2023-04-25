using System.Text;

int count;
StringBuilder outMessage = new StringBuilder();


count = int.Parse(Console.ReadLine());
for (int i = 0; i < count; i++)
{
    var arr = getArrFromString(Console.ReadLine());
    outMessage.AppendLine((arr[0] + arr[1]).ToString());
}
Console.Write(outMessage);

int[] getArrFromString(string str)
{
    var arr = str.Split(' ').Select(s=>int.Parse(s)).ToArray();
    return arr;
}