# CakeThiefChallenge
You are a renowned thief who has recently switched from stealing precious metals to stealing cakes because of the insane profit margins. You end up hitting the jackpot, breaking into the world's largest privately owned stock of cakes—the vault of the Queen of England.

While Queen Elizabeth has a limited number of types of cake, she has an unlimited supply of each type.

Each type of cake has a weight and a value, stored in objects of a CakeType class:

  public class CakeType
{
    public readonly int Weight;
    public readonly long Value;

    public CakeType(int weight, long value)
    {
        Weight = weight;
        Value  = value;
    }
}




For example:

  // Weighs 7 lbs and has a value of 160 shillings
var cakeType = new CakeType(7, 160);


// Weighs 3 lbs and has a value of 90 shillings
var yetAnotherCakeType = new CakeType(3, 90);


You brought a duffel bag that can hold limited weight, and you want to make off with the most valuable haul possible.

Write a method MaxDuffelBagValue() that takes an array of cake type objects and a weight capacity, and returns the maximum monetary value the duffel bag can hold.

For example:

  CakeType[] cakeTypes = new []
{
    new CakeType(7, 160),
    new CakeType(3, 90),
    new CakeType(2, 15),
};

int capacity = 20;

// Returns 555 (6 of the middle type of cake and 1 of the last type of cake)
MaxDuffelBagValue(cakeTypes, capacity);

Weights and values may be any non-negative integer. Yes, it's weird to think about cakes that weigh nothing or duffel bags that can't hold anything. But we're not just super mastermind criminals—we're also meticulous about keeping our algorithms flexible and comprehensive.
