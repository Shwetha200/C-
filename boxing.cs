//Boxing=c# compiler will convert value type to reference/object type
class Boxing{
    public static void main(){
        int n=2021;
        
        //boxing
        object obj=n;  //creating an object called obj and assigning it to integer n.

        //value of n to be change now
        n=500;

        System.Console.WriteLine("value type of n is : {0}", n);
        System.Console.WriteLine("value type of obj is : {0}", obj);

    }

}