using System;



// List<PlyerInfo> playerinfos=new List<PlayerInfo>();
// playerinfos.Add(new PlyerInfo());
string[] lines = File.ReadAllLines("datas.csv");
// //1. list of all player from nepal
Console.WriteLine("Player participated form nepal are");
foreach(string line in textarray)
{
    var str=line.Split(",");

    if(str[7]=="NEP")
    {
        Console.WriteLine(str[1]);
    }
}
//2. List all chinese players who have won the GOLD.

Console.WriteLine("Plears form china who have won gold are as follows");
foreach(string line in textarray)
{
    var str1=line.Split(',');
    if(str1[7]=="CHN" && str1[14]=="Gold")
    {
        Console.WriteLine(str1[1]);
    }
}

// // 3. List all players from USA and group them by sport they were in. Also order the result by sport.
// Console.WriteLine("Plears form USA with their sports");
foreach(string line in textarray)
{
    var str3=line.Split(',');
    if(str3[7]=="USA")
    {
        // Console.WriteLine($"{str3[1]} was invloved in {str3[12].Order}");
        string usa= str3[1]+"          /" + str3[12];
        Console.WriteLine(usa);
    }
}
