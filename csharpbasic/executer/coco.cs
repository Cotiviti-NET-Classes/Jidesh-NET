namespace Cocobot;

class Coco
{


    //two auto implemented property
    public string name { get; set; }
    public int sex { get; set; }
    public string message {  get;set; }
    //readonly property run time constant
    public readonly double version= 3.0;

    //compile time constant
    public const string developedby="Jidesh";

    //default constructor
    public Coco()
    {
        name="Aagan";
        sex=(int)Gender.Male;
        if(sex==0){
        Console.WriteLine("Hello Handsome {0} i am coco",name);
        }
        else if(sex==1)
        {
        Console.WriteLine("Hello Beautiful {0} i am coco",name);
        }
        else
        {
        Console.WriteLine("Hello sweet {0} i am coco",name);
        }
        Console.WriteLine("Do you want my any help(Y/N)?");
        string flag=(Console.ReadLine()).ToUpper();
         if( flag == "Y" )
        {
            Console.WriteLine("Type T to raise ticket");
            string ticket=(Console.ReadLine()).ToUpper();
            if(ticket =="T")
            {
                Console.WriteLine("Type 1 for Generic Serive Request");
                Console.WriteLine("Type 2 To report an incident");
                Console.WriteLine("Type 3 to cancle operations");
                int b=Convert.ToInt32(Console.ReadLine());
                switch(b)
                {
                    case 1:
                        {
                            Console.WriteLine("Generaic service request processing.....");
                            Console.WriteLine("Generaic service request processing.....");
                            Console.WriteLine("Generaic service request processing.....");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Report an incident processing.....");
                            Console.WriteLine("Report an incident processing.....");
                            Console.WriteLine("Report an incident processing.....");                            
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("cancelling .....");
                            Console.WriteLine("cancelling .....");
                            Console.WriteLine("cancelling .....");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You were suppose to enter either 1 or 2 or 3");
                            break;
                        }
                }

            }
        }
        else
        {
            Console.WriteLine("Good learn to be independent");
        }
    }

    //parametrized constructor
    public Coco(string nam, int gender)
    {
        name=nam;
        sex=gender;
         if(sex==0){
        Console.WriteLine("Hello Handsome {0} i am coco",name);
        }
        else if(sex==1)
        {
        Console.WriteLine("Hello Beautiful {0} i am coco",name);
        }
        else
        {
        Console.WriteLine("Hello sweet {0} i am coco",name);
        }
        Console.WriteLine("Do you want my any help(Y/N)?");
        string flag=(Console.ReadLine()).ToUpper();
        if( flag == "Y" )
        {
            Console.WriteLine("Type T to raise ticket");
            string ticket=(Console.ReadLine()).ToUpper();
            if(ticket =="T")
            {
                Console.WriteLine("Type 1 for Generic Serive Request");
                Console.WriteLine("Type 2 To report an incident");
                Console.WriteLine("Type 3 to cancle operations");
                int b=Convert.ToInt32(Console.ReadLine());
                switch(b)
                {
                    case 1:
                        {
                            Console.WriteLine("Generaic service request processing.....");
                            Console.WriteLine("Generaic service request processing.....");
                            Console.WriteLine("Generaic service request processing.....");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Report an incident processing.....");
                            Console.WriteLine("Report an incident processing.....");
                            Console.WriteLine("Report an incident processing.....");                            
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("cancelling .....");
                            Console.WriteLine("cancelling .....");
                            Console.WriteLine("cancelling .....");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You were suppose to enter either 1 or 2 or 3");
                            break;
                        }
                }

            }
        }
        else
        {
            Console.WriteLine("Good learn to be independent");
        }
    }
    public enum Gender {Male,Female,Others}

}

