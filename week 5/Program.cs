using System;

namespace week_5
{ 
    class Program
{
    static void Main(string[] args)
    {
        var a = new TestQuestion2();
        //a.PlayingWithForLoops();

        var b = new BirthdayParty();
        b.setupPartyList();
        Console.WriteLine(b.printPartyList());
        Console.WriteLine(b.printPartyListReverse());
    }
}

class TestQuestion2
{
    public int myFavouriteVariable = 0;
    public void PlayingWithForLoops()
    {
        // write a for loop to add 10 numbers
        //Need to know the four types of variables in OO programming:
        //Scoping: Visibility: What we can see??
        // 

        for (; MyMethod();)
        {
            if (myFavouriteVariable > 10)
            {
                Console.WriteLine("I am so out of here!");
                break;
            }
            Console.WriteLine("Oh no I have to go through this stupid loop again...");
        }

    }
    public bool MyMethod()
    {
        myFavouriteVariable++;
        return true;
    }
}

class Dog
{
    public Dog(string name, string breed)
    {
        dogName = name;
        dogBreed = breed;
    }
    public string dogName;
    public string dogBreed;
    public Dog nextDog;
    public Dog previousDog;
}
class BirthdayParty
{
    public Dog peanut;
    public Dog fifi;
    public Dog clarence;
    public Dog giselle;
    public Dog lulu;
    public Dog roy;

    public Dog head;
    public Dog tail;
    public Dog temporary;

    public void setupPartyList()
    {
        peanut = new Dog("Peanut", "Bichon");
        fifi = new Dog("Fifi", "Poodle");
        clarence = new Dog("Clarence", "German Sheppard");
        giselle = new Dog("Giselle", "Border Collie");
        lulu = new Dog("Lulu", "Shitzu");
        roy = new Dog("Roy", "Beagle");

        peanut.previousDog = null;
        peanut.nextDog = fifi;
        fifi.previousDog = peanut;
        fifi.nextDog = clarence;
        clarence.previousDog = fifi;
        clarence.nextDog = giselle;
        giselle.previousDog = clarence;
        giselle.nextDog = lulu;
        lulu.previousDog = giselle;
        lulu.nextDog = roy;
        roy.previousDog = lulu;
        roy.nextDog = null;
        head = peanut;
        tail = roy;


    }

    public string printPartyList()
    {
        string inviteList = "*--";
        temporary = head;
        while (temporary.nextDog != null)
        {

            inviteList += temporary.dogName + "*---*";
            temporary = temporary.nextDog;

        }
        inviteList += temporary.dogName + "*---*";
        return inviteList;
    }
    public string printPartyListReverse()
    {
        string inviteList = "*--";
        temporary = tail;
        while (temporary.previousDog != null)
        {

            inviteList += temporary.dogName + "*---*";
            temporary = temporary.previousDog;

        }
        inviteList += temporary.dogName + "*---*";
        return inviteList;
    }
}
}