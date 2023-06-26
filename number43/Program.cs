double ReadNumber(string cord){
    Console.Write("Введите {0}: " , cord);
    return (Convert.ToDouble(Console.ReadLine())); 
}
void distance(){
    double k1 = ReadNumber("k1");
    double b1 = ReadNumber("b1");
    double k2 = ReadNumber("k2");
    double b2 = ReadNumber("b2");
    double x = ((b1-b2)/(k2-k1));
    double y = k1*x + b1 ;
    Console.WriteLine("Координаты пересечения : ({0};{1}) ", Math.Round(x,3) , Math.Round(y,3) ); 
}
distance();
//y = k1 * x + b1, y = k2 * x + b2; 