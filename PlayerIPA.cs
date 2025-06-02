/*
test case
1
Virat
4500
Batsman
ODI
2
Bumrah
200
Bowler
Test
3
Rohit
4300
Batsman
ODI
4
Ashwin
700
Bowler
Test
Batsman
Test

find player with lowest run of playertype given as input given and 
find player id in descending order of player matchtype as input given
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Player
{
    public int id {get; set;}
    public string name {get; set;}
    public int runs {get; set;}
    public string playerType {get; set;}
    public string matchType {get; set;}
    
    public Player(int id, string name, int runs, string playerType, string matchType)
    {
        this.id = id;
        this.name = name;
        this.runs = runs;
        this.playerType = playerType;
        this.matchType = matchType;
    }
}

public class Test
{
	public static void Main()
	{
		List<Player> players = new List<Player>();
		for (int i = 0; i < 4; i++)
        {
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int runs = int.Parse(Console.ReadLine());
            string pType = Console.ReadLine();
            string mType = Console.ReadLine();

            players.Add(new Player(id, name, runs, pType, mType));
        }
        
        // Input for search
        string searchPlayerType = Console.ReadLine();
        string searchMatchType = Console.ReadLine();
        
        List<int> arr = new List<int>();
        for(int i=0; i<4; i++)
        {
            if((players[i].playerType).ToLower() == searchPlayerType.ToLower())
            arr.Add(players[i].runs);
        }
        arr.Sort();
        if (arr.Count > 0)
        Console.WriteLine(arr[0]);
        else
        Console.WriteLine("No such player"); 
        // lowest run of player type Batsman
        
        
        //id of the match type player in descending order
        List<int> arr2 = new List<int>();
        for(int i=0; i<4; i++)
        {
            if(players[i].matchType == searchMatchType)
            arr2.Add(players[i].id);
        }
        arr2.Sort();
        arr2.Reverse();
        for(int i=0; i<arr2.Count; i++)
        {
            Console.WriteLine(arr2[i]);
        }
        
	}
}
