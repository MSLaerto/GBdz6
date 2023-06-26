void InOutputArray(){
    int a = 0 ;
    Console.Write("Введите ваши числа : "); 
    int[] result = Array.ConvertAll(Console.ReadLine()!.Split() , int.Parse );
    for (int i = 0 ; i < result.Length ; i++ ){
        if (result[i] > 0){
            a = a + 1;
        }
    }
    Console.Write("Ваши числа: ");
    for (int i = 0 ; i < result.Length ; i++ ){
        Console.Write(result[i]);
        if ( i != (result.Length-1)){
            Console.Write(", ");
        }
    }
    Console.Write(" -> чисел больше 0 : {0} ", a);
}
InOutputArray();