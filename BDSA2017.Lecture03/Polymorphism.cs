﻿using System;

namespace BDSA2017.Lecture03
{
    public abstract class Dog
    {
        public void Bark()
        {
            Console.WriteLine(nameof(Dog) + " " + GetType().Name);
        }
    }

    public class Bulldog : Dog
    {
        public new void Bark()
        {
            Console.WriteLine(nameof(Bulldog) + " " + GetType().Name);
        }
    }

    public abstract class Foxhound
    {
        public virtual void Bark()
        {
            Console.WriteLine(nameof(Foxhound) + " " + GetType().Name);
        }
    }

    public class GoodDog : Foxhound
    {
        public override void Bark()
        {
            Console.WriteLine(nameof(GoodDog) + " " + GetType().Name);
        }
    }

    public class AnotherBadDog : Foxhound
    {
        public new void Bark()
        {
            Console.WriteLine(nameof(AnotherBadDog) + " " + GetType().Name);
        }
    }

    public sealed class AnotherDog : Foxhound
    {
        public override sealed void Bark()
        {
            Console.WriteLine(nameof(AnotherDog) + " " + GetType().Name);
        }
    }

    public class ReallyNotThatDog : Foxhound
    {
        public override sealed void Bark()
        {
            Console.WriteLine(nameof(ReallyNotThatDog) + " " + GetType().Name);
        }
    }

    public class ReallyNotThisDog : ReallyNotThatDog
    {
        public new void Bark()
        {
            Console.WriteLine(nameof(ReallyNotThisDog) + " " + GetType().Name);
        }
    }

    public class Polymorphism
    {
        public static void Run()
        {
            Bulldog dog1 = new Bulldog();
            dog1.Bark();

            Dog dog2 = dog1;
            dog2.Bark();

            GoodDog dog3 = new GoodDog();
            dog3.Bark();

            Foxhound dog4 = dog3;
            dog4.Bark();

            AnotherBadDog dog5 = new AnotherBadDog();
            dog5.Bark();

            Foxhound dog6 = dog5;
            dog6.Bark();

            AnotherDog dog7 = new AnotherDog();
            dog7.Bark();

            Foxhound dog8 = dog7;
            dog8.Bark();

            ReallyNotThatDog dog9 = new ReallyNotThatDog();
            dog9.Bark();

            Foxhound dog10 = dog9;
            dog10.Bark();

            ReallyNotThisDog dog11 = new ReallyNotThisDog();
            dog11.Bark();

            ReallyNotThatDog dog12 = dog11;
            dog12.Bark();

            Foxhound dog13 = dog12;
            dog13.Bark();
        }
    }
}
