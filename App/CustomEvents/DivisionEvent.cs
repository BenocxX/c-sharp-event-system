namespace App.CustomEvents;

public class DivisionEvent : OperationEvent
{
    public new static string EventType => "EVENT_DIVISION_OPERATION";
    
    public DivisionEvent(int num1, int num2) : base(EventType, num1, num2)
    {
        
    }

    public override int Calculate()
    {
        return FirstNumber / SecondNumber;
    }
}