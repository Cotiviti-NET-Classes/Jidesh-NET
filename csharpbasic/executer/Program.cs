


//Assignment 4
//variable decleration for no of character ==> noOfChar
//variable decleration for no of words ==> noOfWord
//variable decleration for no of Sentence ==> noOfSentence
//variable decleration for no of vowel ==> noOfVowel
//variable decleration for no of special character ==> noOfSpChar
int noOfChar = 0, noOfWord = 0, noOfSentence = 0, noOfVowel = 0, noOfSpChar = 0;

//put every line as and element of array
string[] textarray = File.ReadAllLines("test.txt");
//  Console.WriteLine(textarray[0].Count());
foreach (string text in textarray)
{
    noOfChar += System.Text.RegularExpressions.Regex.Matches(text, "[\x00-\x7F]").Count;
    noOfWord += text.Split(' ').Length;
    noOfSentence += text.Split("[]!?.:+").Length;
}

//textContent contains everything even space, line breaks and all special characters
   string textContent=File.ReadAllText("test.txt");
   noOfVowel=System.Text.RegularExpressions.Regex.Matches(textContent.ToLower(),"[aeiou]").Count;
   noOfSpChar=System.Text.RegularExpressions.Regex.Matches(textContent, "[~!@#$%^&*()_+{}:\"<>?';,]").Count;
    // Console.WriteLine(textContent.Length);
Console.WriteLine("1. Number of character is = {0}", noOfChar);
Console.WriteLine("2. Number of word is={0}", noOfWord);
Console.WriteLine("3. Number of sentence is = {0}", noOfSentence);
Console.WriteLine("4. Number of Vowels is ={0}", noOfVowel);
Console.WriteLine("5. Number of secial character is = {0}",noOfSpChar);

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