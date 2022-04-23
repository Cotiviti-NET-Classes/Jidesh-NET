




RealTimeExample value = new();
value.FileHandlingTask();
 
// using System;


// // List<PlyerInfo> playerinfos=new List<PlayerInfo>();
// string[] lines = File.ReadAllLines("datas.csv");
// foreach(string line in lines){
//     var str=line.Split(',');
//     Console.WriteLine(str[1]);
// }




// class PlyerInfo
// {
//     public int id { get; set; }
//     public string Name { get; set; }
//     public char sex { get; set; }
//     public int height { get; set; }
//     public int weight { get; set; }
//     public string team { get; set; }
//     public string NOC { get; set; }
//     public string games { get; set; }
//     public int year { get; set; }
//     public string? season { get; set; }
//     public string? city { get; set; }
//     public string? sprots { get; set; }
//     public string? eventname { get; set; }
//     public string? medal { get; set; }

    // public string NepaliPlayers()
    // {

    // }

//}

// //1. list of all player from nepal
// Console.WriteLine("Player participated form nepal are");
// foreach(string line in lines)
// {
//     var str=line.Split(",");

//     if(str[7]=="NEP")
//     {
//         Console.WriteLine(str[1]);
//     }
// }
// //2. List all chinese players who have won the GOLD.

// Console.WriteLine("Plears form china who have won gold are as follows");
// foreach(string line in lines)
// {
//     var str1=line.Split(',');
//     if(str1[7]=="CHN" && str1[14]=="Gold")
//     {
//         Console.WriteLine(str1[1]);
//     }
// }

// // // 3. List all players from USA and group them by sport they were in. Also order the result by sport.
// // Console.WriteLine("Plears form USA with their sports");
// foreach(string line in lines)
// {
//     var str3=line.Split(',');
//     if(str3[7]=="USA")
//     {
//         // Console.WriteLine($"{str3[1]} was invloved in {str3[12].Order}");
//         string usa= str3[1]+"          /" + str3[12];
//         Console.WriteLine(usa);
//     }
// }
