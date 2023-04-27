using System.Text;
//часичное решение

int[] getArrFromString(string str)
{
    var arr = str.Split(' ').Select(s => int.Parse(s)).ToArray();
    return arr;
}

int count;
StringBuilder outMessage = new StringBuilder();



var input = getArrFromString(Console.ReadLine());
int n = input[0];
Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
for (int i = 0; i < n; i++)
{
    dict.Add(i + 1, new List<int>());
}
count = input[1];
for (int i = 0; i < count; i++)
{
    var line = getArrFromString(Console.ReadLine());
    if (dict.ContainsKey(line[0]))
    {
        if (!dict[line[0]].Exists(v=>v ==line[1]))
        {
            dict[line[0]].Add(line[1]);
        }
    }
    else
    {
        dict[line[0]].Add(line[1]);
    }
}



Console.Write(outMessage);