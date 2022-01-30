using App.CustomEvents;
using EventLibrary;

namespace App;

public class TestClass : IEventListener
{
    public TestClass()
    {
        EventSystem.Instance.AddEventListener(this);
    }

    public void OnEvent(Event e)
    {
        var dispatcher = new EventDispatcher(e);
        dispatcher.Dispatch(Event.Type.DivisionEvent, e2 => OnDivision((DivisionEvent) e2));
    }

    private bool OnDivision(Event e)
    {
        Console.WriteLine();
        Console.WriteLine("- Might be a division by 0 -");
        return false;
    }
}