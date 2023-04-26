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
    Console.ReadLine();
    var arrCountInput = getArrFromString(Console.ReadLine());
    var n = arrCountInput[0];
    var m = arrCountInput[1];
    var arr = new int[n, m];
    for (int j = 0; j < n; j++)
    {
        var line = getArrFromString(Console.ReadLine());
        for (int k = 0; k < m; k++)
        {
            arr[j, k] = line[k];
        }
    }
    var clickCount = int.Parse(Console.ReadLine());
    var arrClick = getArrFromString(Console.ReadLine());
    for (int j = 0; j < clickCount; j++)
    {
        var column = arrClick[j]-1;
        var result = getCheckedArr(arr, column, n);
        arr = getNewArr(result,arr,n,m);
        //Console.WriteLine($"keys: {result.Keys.ToString()} values: {result.Values.ToString()}");

    }
    for (int j = 0; j < n; j++)
    {
       List<int> line= new List<int>();
        for (int k = 0; k < m; k++)
        {
            line.Add(arr[j,k]);
        }
        outMessage.AppendLine(string.Join(" ", line));
    }
    outMessage.AppendLine();
}

Console.WriteLine(outMessage);

int[,] getNewArr(Dictionary<int, int> dict, int[,] arr, int n, int m)
{
    var i = 0;
    var resultArr = new int[n, m];
    foreach (var d in dict)
    {
        var line = d.Key;
        for (int j = 0; j < m; j++)
        {
            resultArr[i, j] = arr[line, j];
        }
        i++;
    }
    return resultArr;
}

Dictionary<int, int> getCheckedArr(int[,] input,int column, int len)
{
    var arr = new int[len];
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < len; i++)
    {

        dict.Add(i, input[i, column]);
    }
    var sortdict = dict.OrderBy(d => d.Value).ToDictionary(t => t.Key, t => t.Value);
    return sortdict;
}
