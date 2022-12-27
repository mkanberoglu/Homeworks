using Animals.Names;
namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            Animal _Crocodile = new Crocodile();
            list.Add(_Crocodile);
            Animal _Eagle = new Eagle();
            list.Add(_Eagle);
            Animal _Hawk = new Hawk();
            list.Add(_Hawk);
            Animal _Snake = new Snake();
            list.Add(_Snake);

            foreach (Animal item in list)
            {
                switch(item.name) 
                {
                    case "Eagle":
                        Eagle eagleInstance = (Eagle)item;
                        Console.WriteLine($"{eagleInstance.Breathe()}\n\r{eagleInstance.Eat()}\n\r{eagleInstance.Walk()}\n\r{eagleInstance.Fly()}\n\r");
                        break;
                    case "Hawk":
                        Hawk hawkInstance = (Hawk)item;
                        Console.WriteLine($"{hawkInstance.Breathe()}\n\r{hawkInstance.Eat()}\n\r{hawkInstance.Walk()}\n\r{hawkInstance.Fly()}\n\r");
                        break;
                    case "Snake":
                        Snake snakeInstance = (Snake)item;
                        Console.WriteLine($"{snakeInstance.Breathe()} \n\r{snakeInstance.Eat()} \n\r{snakeInstance.Crowl()} \n\r");
                        break;
                    case "Crocodile":
                        Crocodile crocodileInstance = (Crocodile)item;
                        Console.WriteLine($"{crocodileInstance.Breathe()}\n\r{crocodileInstance.Eat()}\n\r{crocodileInstance.Crowl()}\n\r");
                        break;
                }
            }
        }
    }
}