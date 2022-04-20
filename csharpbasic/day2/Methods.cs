using System;

namespace LearningBasic;


class MethodLearner
{
    // void DoSomething()
    // {
    //     Console.Write("Doing something...");
    // }

    // string GetName()
    // {
    //     return "Jidesh";
    // }

    string GetName()=>"Jidesh";


    //optional parameter
    int Add(int a, int b,int c=0) => a+b+c;

    //multinumber paramter
    int AddMulti(params int[] values) => values.Length;


    (string name1, string name2) GetNames() => ("Jidesh","roshan");
}