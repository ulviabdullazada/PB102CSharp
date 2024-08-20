using AbstractInterface;

#region Abstract, Polimorphism
//Duck duck = new Duck("Duffy");
////Cat cat = new Cat();
//Shark shark = new Shark();

////duck.Eat();
////cat.Eat();
//shark.Swim();
//duck.Swim();
//ISwim[] animals = {duck, shark};
//foreach (ISwim s in animals)
//{
//    s.Swim();
//}
//Animal[] animals = {duck, cat, shark};
//foreach (var animal in animals)
//{
//    animal.Eat();
//}
//Bird[] birds = {duck, new Sparrow("Jack"), new Owl("Shahin") };

//foreach (Bird bird in birds)
//{
//    Console.WriteLine(bird);
//}
#endregion



#region Casting
Animal a = new Shark(); //upcasting
Shark shark = new Shark();

Animal b = shark;

Animal[] animals = {a, new Duck("Duffy"), new Owl("OO"),new Cat(), new Parrot("Cumshud") };
foreach (Animal animal in animals)
{
    if (animal is Shark mutellib)
    {
        //Shark newShark = (Shark)animal;
        mutellib.SayMeyxana();
        //((Shark)animal).SayMeyxana();
    }
    else if (animal is Duck)
    {
        Duck duck = (Duck)animal;
        duck.Quack();
    }
    //Owl owl = (Owl)animal;
    Parrot parrot = animal as Parrot;
    if (parrot != null)
    {
        parrot.Talk();
    }
    //parrot.Talk();
    //Owl owl = null;
    //owl.Fly();
}

//int num = 22;
//long num1 = num;
Object o = 22; //boxing
int i = Convert.ToInt32(o); //unboxing
#endregion