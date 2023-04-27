using System.Text;

// частичное решение

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
    var result = true;
    var list = new List<Tuple<TimeOnly,TimeOnly>>();
    var arrStr = new string[countValues];
    for (int j = 0; j < countValues; j++)
    {
        arrStr[j] = Console.ReadLine();
    }
    for (int j = 0; j < countValues; j++)
    {
        var arr = arrStr[j].Split('-');
        var parse1 = TimeOnly.TryParse( arr[0], out var date1);
        var parse2 = TimeOnly.TryParse(arr[1], out var date2);
        if (!parse1 || !parse2)
        {
            result = false;
            break;
        }
        var correctPeriod = date1 <= date2;
        if (!correctPeriod || list.Any(l => 
            (l.Item1 <= date1 && date2<= l.Item2) 
            || (l.Item1 <= date1 && date1 <= l.Item2) 
            || (l.Item1 <= date2 && date2 <= l.Item2)
            || (date1 <= l.Item1  &&  l.Item2<=date2 )))
        {
            result = false;
            break;
        }
        list.Add(new Tuple<TimeOnly, TimeOnly>(date1, date2));
        
    }
    var strResult = result ? "YES" : "NO";
    outMessage.AppendLine(strResult);
}

Console.Write(outMessage);