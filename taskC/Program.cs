using System.Text;


int count;
StringBuilder outMessage = new StringBuilder();


count = int.Parse(Console.ReadLine());
for (int i = 0; i < count; i++)
{
    var n = int.Parse(Console.ReadLine());
    var arr = getArrFromString(Console.ReadLine());
    
    var dictionary = new Dictionary<int, int>();
    var pos = 1;
    var levels = arr.Select(a => new Level
    {
        Skil = arr[pos - 1],
        Position = pos++,

    }).ToArray();
    
    for (int j = 0; j < n/2; j++)
    {
        var check = levels[0];
        var minAbs = 100;
        var keyMin = 0;
        for (int l = 1; l < levels.Length; l++)
        {
            
            var abs = Math.Abs(check.Skil - levels[l].Skil);
            if (abs < minAbs)
            {
                minAbs = abs;
                keyMin = l;
            }
        }
        outMessage.AppendLine($"{check.Position} {levels[keyMin].Position}");
        var notSelectedPosition =  new int[] { check.Position, levels[keyMin].Position};
        levels = levels.Where(l => !notSelectedPosition.Contains( l.Position)).ToArray();

    }
    outMessage.AppendLine();



}
Console.Write(outMessage);



int[] getArrFromString(string str)
{
    var arr = str.Split(' ').Select(s => int.Parse(s)).ToArray();
    return arr;
}

struct Level
{
    public int Position { get; set; }
    public int Skil { get; set; }
}