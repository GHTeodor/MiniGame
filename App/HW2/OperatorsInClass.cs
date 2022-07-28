namespace MiniGame.App.HW2;

public class OperatorsInClass
{
    public double randomX { get; set; } = new Random().Next(1, 100);
    public double randomY { get; set; } = new Random().Next(1, 100);
    
    public override string ToString()
    {
        return $"Operator: randomX={randomX} randomY={randomY}";
    } 
    
    public static OperatorsInClass operator +(OperatorsInClass o1, OperatorsInClass o2)
    {
        OperatorsInClass operat = new OperatorsInClass();
        operat.randomX = o1.randomX + o2.randomX;
        operat.randomY = o1.randomY + o2.randomY;
        return operat;
    }
    
    public static OperatorsInClass operator -(OperatorsInClass o1, OperatorsInClass o2)
    {
        OperatorsInClass operat = new OperatorsInClass();
        operat.randomX = o1.randomX - o2.randomX;
        operat.randomY = o1.randomY - o2.randomY;
        return operat;
    }
    
    public static OperatorsInClass operator *(OperatorsInClass o1, OperatorsInClass o2)
    {
        OperatorsInClass operat = new OperatorsInClass();
        operat.randomX = o1.randomX * o2.randomX;
        operat.randomY = o1.randomY * o2.randomY;
        return operat;
    }
    
    public static OperatorsInClass operator /(OperatorsInClass o1, OperatorsInClass o2)
    {
        OperatorsInClass operat = new OperatorsInClass();
        operat.randomX = o1.randomX / o2.randomX;
        operat.randomY = o1.randomY / o2.randomY;
        return operat;
    }
}