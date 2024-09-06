//UnBoxing=User should convert value type to reference/object type
class UnBoxing{
    public static void main(){
        int n=25;
        
        //boxing
        object obj=n;  //creating an object called obj and assigning it to integer n.

        //unboxing by me/user
        int i=(int)obj;

        System.Console.WriteLine("value type of i is :" + i);
        System.Console.WriteLine("value type of obj object is : ", + obj);

    }

}