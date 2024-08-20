namespace AbstractInterface;
abstract class Animal
{
    public abstract void Eat();
}

abstract class Fish : Animal, ISwim
{
    public void Swim()
    {
        Console.WriteLine("Swim as fish");
    }
}

class Shark : Fish
{
    public override void Eat()
    {
        Console.WriteLine("Shark eating little fish");
    }

    public void SayMeyxana()
    {
        Console.WriteLine("blah blah blah");
    }
}

abstract class Pet : Animal
{
    public void Feed()
    {
        Console.WriteLine("Feed as pet");
    }
}

class Cat : Pet
{
    public override void Eat()
    {
        Console.WriteLine("Cat eating whiskas");
    }

    public void TakeCare()
    {
        Console.WriteLine("Take care of cat");
    }
}

abstract class Bird : Animal
{
    public string  Name { get; set; }
    protected Bird(string name)
    {
        Name = name;
    }
    public virtual void Fly()
    {
        Console.WriteLine("Fly as Bird");
    }
    public override string ToString()
    {
        return Name;
    }
}

class Duck : Bird, ISwim
{
    public Duck(string name) : base(name)
    {
    }

    public override void Eat()
    {
        Console.WriteLine("Duck eating everthing");
    }

    public override void Fly()
    {
        Console.WriteLine("Duck cannot fly");
    }

    public void Quack()
    {
        Console.WriteLine("Quack quack!");
    }

    public void Swim()
    {
        Console.WriteLine("Swim as duck");
    }
}

class Parrot : Bird
{
    public Parrot(string name) : base(name)
    {
    }

    public override void Eat()
    {
        Console.WriteLine("Sparrow eating wheat");
    }
    public void Talk()
    {
        Console.WriteLine("Saaalaaam");
    }
}

class Owl : Bird
{
    public Owl(string name) : base(name)
    {
    }

    public override void Eat()
    {
        Console.WriteLine("Owl eating bread");
    }
}