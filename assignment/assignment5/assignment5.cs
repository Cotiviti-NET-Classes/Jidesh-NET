using System;
using System.Linq;


class RealTimeExample
{

    public void FileHandlingTask()
    {

        // Read the file as one string.
        string[] data = File.ReadAllLines("datas.csv");
        string[] noCountry=new string[data.Length];


        List<Player> player = new();

        for (int i = 1; i < data.Length; i++)
        {

            var a = data[i];
            var c = a.Split(',');
            // Console.WriteLine(c[0]);
            player.Add(new Player
            {
                Id = c[0],
                Name = c[1],
                Sex = c[2],
                Age = c[3],
                Height = c[4],
                Weight = c[5],
                Team = c[6],
                NOC = c[7],
                Games = c[8],
                Year = c[9],
                Season = c[10],
                City = c[11],
                Sport = c[12],
                Event = c[13],
                Medal = c[14],
            });
        }

        // 1.List all the players participated from Nepal.
        var peopleFromNepal = player.Where(x => x.NOC.ToUpper().Contains("NEP"));
        foreach (var people in peopleFromNepal)
            Console.WriteLine(people.Name);

        // 2. List all chinese players who have won the GOLD.
        var peopleFromChina = player.Where(x => x.NOC.ToUpper().Contains("CHN"));
        var chinaGold = peopleFromChina.Where(x => x.Medal.ToUpper().Contains("GOLD"));
        foreach (var people in chinaGold)
        {
            Console.WriteLine(people.Name);
        }

        // 3. List all players from USA and group them by sport they were in. Also order the result by sport.
        Console.WriteLine("Name"+ "          " + "Involved sports");
        var peopleFromUSA = player.Where(x=>x.NOC.ToUpper().Contains("USA"));
        var ordreBySportsUSA=peopleFromUSA.OrderBy(x=>x.Sport);
        Console.WriteLine(ordreBySportsUSA);
        foreach(var usp in ordreBySportsUSA)
        {
            Console.WriteLine(usp.Name +"              " +usp.Sport);
        }
        // List all countries with thier medal tally so far. Also, order the list by number of golds won.
        Console.WriteLine("Country          No. of gold");
        foreach(var line in player.GroupBy(info=>info.NOC)
                                    .Select(group=>new {
                                        NOC=group.Key,
                                        Count=group.Count()
                                        })
                                        .OrderBy(x=>x.Count))
        {
            Console.WriteLine("{0}          {1}",line.NOC,line.Count);
        }

        // var goldMedalist=player.Where(x=>x.Medal.ToUpper().Contains("GOLD")).OrderBy(x=>x.Medal).GroupBy(x=>x.NOC);
        // foreach(var x in goldMedalist)
        // {
        //     foreach(Player p in x)
        //     {
        //         noCountry.Append(p.NOC);
        //     }
        // }
        // Console.WriteLine(noCountry[10]);


    }
}

