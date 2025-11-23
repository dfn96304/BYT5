// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        // Your code goes here... make sure to add this features:
        //1. Allow to hold the observer's name (e.g. when user Adam wants to observe the subject)
        //2. Creating the Observer
        //3. Registering the Observer with the Subject
        //4. Removing the Observer from the Subject
        //5. Observer will get a notification from the Subject using the following Method
        
        public string UserName { get; set; } = userName; // 1, 2 (primary constructor)
        
        public void AddSubscriber(ISubject subject) // 3
        {
            subject.RegisterObserver(this);
        }

        public void RemoveSubscriber(ISubject subject) // 4
        {
            subject.RemoveObserver(this);
        }

        public void Update(string availability) // 5
        {
            Console.WriteLine($"[Notification to {UserName}] A subject is {availability}");
        }
    }
}
    