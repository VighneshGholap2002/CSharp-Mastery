using System;

// Delegate declaration
public delegate void NotifyEventHandler(string message);

class EventPublisher
{
    // Declaring an event based on the delegate
    public event NotifyEventHandler NotifyEvent;

    public void TriggerEvent()
    {
        if (NotifyEvent != null)  // Checking if any method is subscribed
            NotifyEvent("Event has been triggered!");
    }
}

class EventSubscriber
{
    static void HandleEvent(string message)
    {
        Console.WriteLine("Event Received: " + message);
    }

    static void Main()
    {
        EventPublisher publisher = new EventPublisher();

        // Subscribing to the event
        publisher.NotifyEvent += HandleEvent;

        // Triggering the event
        publisher.TriggerEvent();
    }
}
