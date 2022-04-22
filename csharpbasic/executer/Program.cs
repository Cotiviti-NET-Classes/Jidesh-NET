

var csvlines = File.ReadAllLines("call.csv");
var csvLinesData = csvlines.Skip(1).Select(l => l.Split(',').ToArray());

// i am assuming that line[7] is the Party1Name Column
// now you have a (sorted) group with n "members" (ACC, Sales, ..., n )
var groupOfUser = from line in csvLinesData 
                  group line by line[7] into newGroup 
                  orderby newGroup.Key 
                  select newGroup;

// The Key of your userOfGrp is the Name e.g. "ACC"
// i am assuming that x[4] is the direction Column
// I count all I or O and put them into the new User
var user = (from userOfGrp in groupOfUser
            select
                new User()
                    {
                        CSRName = userOfGrp.Key,
                        Incomming = userOfGrp.Count(x => x[4] == "I"),
                        outgoing = userOfGrp.Count(x => x[4] == "O")
                    }).ToList();

// assignment 5

// IDictionary<string,string> usasports = new Dictionary<string,string>();
// string[] textarray = File.ReadAllLines("datas.csv");
//1. list of all player from nepal
// Console.WriteLine("Player participated form nepal are");
// foreach(string line in textarray)
// {
//     var str=line.Split(",");

//     if(str[7]=="NEP")
//     {
//         Console.WriteLine(str[1]);
//     }
// }
// // //2. List all chinese players who have won the GOLD.

// Console.WriteLine("Plears form china who have won gold are as follows");
// foreach(string line in textarray)
// {
//     var str1=line.Split(',');
//     if(str1[7]=="CHN" && str1[14]=="Gold")
//     {
//         Console.WriteLine(str1[1]);
//     }
// }

// 3. List all players from USA and group them by sport they were in. Also order the result by sport.
// Console.WriteLine("Plears form USA with their sports");
// foreach(string line in textarray)
// {
//     var str3=line.Split(',');
//     if(str3[7]=="USA")
//     {
//         // Console.WriteLine($"{str3[1]} was invloved in {str3[12].Order}");
//         // string usa= str3[12]+' '+str3[1];
        
//     }
    
// }
// Console.Write(usasports);


/*
Delegate


Delegate are of refrenced type
Structure are value type
Classes and interface are refrence type

Delegate are also refrence

Delegate are easy
they provide greate flexibility

Delegate is a type safe function pointer


//we can make instance of delegate so delegate is also similar to class
public delegate void HelloFunctionDelegate(string Message);

public static void Hello(string strMessage)
{
   
    Console.WriteLine(strMessage)
}
 HelloFunctionDelegate del= new HelloFunctionDelegate(Hello);
del("Hello from Delegate");

signature of delegate should match the signature of function
to which it points to other wise you get a compiler error
this is the reason delgates are called type safe function pointers

syntax is similar to method with delegate keyword





*/


   


//assignment 5


// string[] textarray = File.ReadAllLines("datas.csv");
// //1. list of all player from nepal
// // Console.WriteLine("Player participated form nepal are");
// // foreach(string line in textarray)
// // {
// //     var str=line.Split(",");

// //     if(str[7]=="NEP")
// //     {
// //         Console.WriteLine(str[1]);
// //     }
// // }
// // //2. List all chinese players who have won the GOLD.

// // Console.WriteLine("Plears form china who have won gold are as follows");
// // foreach(string line in textarray)
// // {
// //     var str1=line.Split(',');
// //     if(str1[7]=="CHN" && str1[14]=="Gold")
// //     {
// //         Console.WriteLine(str1[1]);
// //     }
// // }

// // 3. List all players from USA and group them by sport they were in. Also order the result by sport.
// Console.WriteLine("Plears form USA with their sports");
// foreach(string line in textarray)
// {
//     var str3=line.Split(',');
//     if(str3[7]=="USA")
//     {
//         // Console.WriteLine($"{str3[1]} was invloved in {str3[12].Order}");
//         string usa= str3[1]+"          /" + str3[12];
//         Console.WriteLine(usa);
//     }
// }
//day 5
// LINQ LI = new();

// LI.Learnlinq();

//Assignment 4
//variable decleration for no of character ==> noOfChar
//variable decleration for no of words ==> noOfWord
//variable decleration for no of Sentence ==> noOfSentence
//variable decleration for no of vowel ==> noOfVowel
//variable decleration for no of special character ==> noOfSpChar
// int noOfChar = 0, noOfWord = 0, noOfSentence = 0, noOfVowel = 0, noOfSpChar = 0;

// //put every line as and element of array
// string[] textarray = File.ReadAllLines("test.txt");
// //  Console.WriteLine(textarray[0].Count());
// foreach (string text in textarray)
// {
//     noOfChar += System.Text.RegularExpressions.Regex.Matches(text, "[\x00-\x7F]").Count;
//     noOfWord += text.Split(' ').Length;
//     noOfSentence += text.Split("[]!?.:+").Length;
// }

// //textContent contains everything even space, line breaks and all special characters
//    string textContent=File.ReadAllText("test.txt");
//    noOfVowel=System.Text.RegularExpressions.Regex.Matches(textContent.ToLower(),"[aeiou]").Count;
//    noOfSpChar=System.Text.RegularExpressions.Regex.Matches(textContent, "[~!@#$%^&*()_+{}:\"<>?';,]").Count;
//     // Console.WriteLine(textContent.Length);
// Console.WriteLine("1. Number of character is = {0}", noOfChar);
// Console.WriteLine("2. Number of word is={0}", noOfWord);
// Console.WriteLine("3. Number of sentence is = {0}", noOfSentence);
// Console.WriteLine("4. Number of Vowels is ={0}", noOfVowel);
// Console.WriteLine("5. Number of secial character is = {0}",noOfSpChar);

// string text= File.ReadAllText("test2.txt");
// int count =0;
// foreach(char item in text)
// {
//     Console.WriteLine(item);

// }
// using Cocobot;


// Coco bot0=new Coco();
// Coco bot=new Coco("bishal",0);




// string text =File.ReadAllText("test.txt");

// Console.WriteLine(text);


// string fileName="test2.txt";
// string line;
// int characterCount=0;
// int SentenceCount=0;
// int noofvowel=0;
// int noofspecialC=0;
// int wordsCount=0;

// using (StreamReader file = File.OpenText(fileName))
// {
//     do{
//         line=file.ReadLine();
//         Console.WriteLine(line.Split('\n',' '));
//         if(line!=null)
//         {
//             wordsCount+=line.Split(' ').Length;
//         }
//     }
//         while(line!=null);

//     Console.WriteLine(wordsCount);
// }