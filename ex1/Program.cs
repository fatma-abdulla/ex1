
Console.WriteLine("enter your values");

Console.WriteLine("enter the chr (en,es,fr,tr):");
 string stat = Console.ReadLine();


if(stat=="en")
{
    Console.WriteLine("Hello Name");
}
else if (stat=="es")
{
    Console.WriteLine("Hola Name");

}
else if (stat == "fr")
{
    Console.WriteLine("bonjour Name");

}
else if (stat == "tr")
{
    Console.WriteLine("marhaba Name");

}


Console.WriteLine("----------------------");


Console.WriteLine("please enter your first number ");
 int n1=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("please enter your second number ");
int n2= Convert.ToInt32(Console.ReadLine());
 
if ( n1>n2)
{
    Console.WriteLine("n1 bigger than num 2");

}
else  
    
        {
    Console.WriteLine("n2 bigger than num 2");
}



Console.WriteLine("----------------------");

Console.WriteLine("enter your gread: ");
 int mark=Convert.ToInt32( Console.ReadLine());

if (mark>=80)
{
    Console.WriteLine("A");
}
else if (mark>=70)
{
    Console.WriteLine("B");
}

else if (mark>=60)
{
    Console.WriteLine("c");
}

else if (mark >= 50)
{
    Console.WriteLine("D");
}

else
{
    Console.WriteLine("f");
}






