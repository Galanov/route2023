using System.Text;


int[] getArrFromString(string str)
{
    var arr = str.Split(' ').Select(s => int.Parse(s)).ToArray();
    return arr;
}

int count;
StringBuilder outMessage = new StringBuilder();


count = int.Parse(Console.ReadLine());
for (int i = 0; i < count; i++)
{ 
    var countValues = int.Parse(Console.ReadLine());
    var arr = getArrFromString(Console.ReadLine());
    List<int> map = new List<int>();
    var prev = 0;
    var result = true; 
    for (int j = 0; j < countValues; j++)
    {
        if (!map.Any(m=>m == arr[j]))
        {
            map.Add(arr[j]);
            prev = arr[j];
        }
        else
        {
            if (prev != arr[j])
            {
                result = false;
                break;
            }
        }
    }
    var strResult = result ? "YES" : "NO";
    outMessage.AppendLine(strResult);
}

Console.Write(outMessage);