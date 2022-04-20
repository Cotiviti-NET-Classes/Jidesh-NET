// using System;


// namespace LearningBasic;
// class Basic
// {
//     void LearnBasics()
//     {

//         //Data type

//         // Number : Integer and floating point number

//         byte a = 239;

//         //8 bits, 1 bit sign bit (MSB)
//         // 01111111 = +127,
//         // 10000001 =-1

//         short b = 3224;
//         ushort bb = 12;
//         int c = 214235234;
//         long d = 214124235432;
//         //ulong also exist
//         float e = 232.256456f;
//         double f = 235234534.34535;
//         decimal g = 12423534534.345235m;

//         bool h = true;
//         char i = 'j';
//         string j = "jidesh";

//         // object o = "234";

//         //to make variable nullable
//         //null able
//         // int? population = null;

//         //Array

//         // float[] points = new float[10];
//         // float[] point1 = { 2.4f, 4.5f };


//         //multidimention
//         // string[,] names = new string[2, 3];


//         // Jagged array
//         // int[][] ages = new int[3][];

//         // ages[0] = new int[4];
//         // ages[1] = new int[2];
//         // ages[2] = new int[3];

//         // var keyword

//         // string name = "jidesh";

//         //branching

//         // bool isValid = (5 == 5);
//         // bool isValid1 = (3 > 2);
//         // if (isValid)
//         // {
//         //     Console.Write("");
//         // }
//         // else if (isValid1)
//         // {
//         //     Console.Write("");
//         // }
//         // else
//         // {
//         //     Console.Write("");
//         // }


//         //switch case



//         // var s = 'r';
//         // switch (s)
//         // {
//         //     case 'A':
//         //         break;

//         //     case 'b':


//         //         break;


//         //     default:

//         //         break;

//         // }


//         //loops
//         // for(int loopVariable=5;loopVariable<15;loopVariable++)
//         // {
//         //     Console.Write(loopVariable);
//         // }

//         //while loop
//         // int apple=1;
//         // while(apple <=10)
//         // {
//         //     Console.Write(apple);
//         //     apple++;
//         // }


//         //for each
//         // foreach(var p in points)
//         // {
//         //     Console.WriteLine(p);
//         // }


//         //operators
//         //ternary operator
//         // var var1= isValid ? "print if true" : "print if false";
//         // null coalesing
//         // var val2 = name ?? "Govinda";
//         //null propagation
//         // var val3 = name?.Length;

//         // string name!; //null supressing/forgiving
//         public string Name {get;set;} = default!;
//     }
// }