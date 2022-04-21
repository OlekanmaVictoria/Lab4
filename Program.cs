// See https://aka.ms/new-console-template for more information
bool lessthan100(int a,int b){
    if(a + b < 100)
        return true;
    else 
        return false;

}

Console.WriteLine(lessthan100(22 , 15));
Console.WriteLine(lessthan100(83 , 34));
Console.WriteLine(lessthan100(3 , 77));
