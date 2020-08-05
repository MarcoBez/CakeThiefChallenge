using System;
//Author - Marco Bezuidenhout 20200804
namespace CakeThief
{
    class Program
    {
        static void Main(string[] args)
        {

            /* declare variables
             * CakeThiefHelper - helper class that does the hard work
             * CakeType array that carries the different types of cake
             * w_duffelbag - the weight of the duffelbag
             * returns an object CakesStolen
             *      with a string message
             *      long shillings - the amount en monetary value of stolen cakes
             *      CakeType array the amount of cakes in the deffelbag
             */
            CakeThiefHelper cth = new CakeThiefHelper();
            CakesStolen cs = new CakesStolen();
            string new_cake;
            int new_cake_weight;
            int new_cake_value;
            int w_duffelbag;
            string cake_name = "";
            int num_cake = 0;
            long val_cake = 0;
            int weight_cake = 0;
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //STORY scenario
            Console.WriteLine("You are a renowned thief who has recently switched from stealing precious metals \nto stealing cakes because of the insane profit margins. \nYou end up hitting the jackpot, breaking into the world's largest privately owned stock of cakes \n — the vault of the Queen of England.\n\r");

            Console.WriteLine("In the magestic vault of the QUEEN there are the following Cakes that you know of \n - Raspberry Cheese Cake - weighs 7lbs, its value 125 shillings \n - Blueberry vanilla Cake - weighs 5lbs, its value 105 shillings \n - Dark Chocolate with chocolate chips and some more chocolate Cake - weighs 10lbs, its value 195 shillings.\n\r");

            //get a cake name
            Console.WriteLine("BUT wait, you found another very special cake: \n Please give the name of this cake:");
            new_cake = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(new_cake))
            {
                new_cake = "mystery cake";
                Console.WriteLine("I guessed it for you");
            }

            //get the weight
            Console.WriteLine("Please give the weight of this cake in and estimate of pounds(lbs):");
            try
            {
                new_cake_weight = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                new_cake_weight = 4;
                Console.WriteLine("I guessed it for you");
            }

            //get the estimate value
            Console.WriteLine("Please give the estimated value of this new cake of rounded to the nearest shilling:");
            try
            {
                new_cake_value = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                new_cake_value = 135;
                Console.WriteLine("I guessed it for you");
            }

            Console.WriteLine("Your new found cake: " + new_cake + "\nwheighs " + new_cake_weight + "lbs and is worth " + new_cake_value + " shillings!\n\r");

            //get the weight of the duffel bag
            Console.WriteLine("Please give the weight of your duffelbag:");
            try
            {
                w_duffelbag = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                w_duffelbag = 50;
                Console.WriteLine("Oops, it turns out you dont have a duffelbag. \nPlease use the one hanging behind the vault door.\nIt has a weight capacity of" + w_duffelbag + "lbs!\n\r");
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            CakeType[] ct_arr = new[]
            {
            new CakeType(7, 125, "Raspberry"), //Raspberry
            new CakeType(5, 105, "Blueberry"), //Blueberry
            new CakeType(10, 195, "Choclate"), //choclate
            new CakeType(new_cake_weight, new_cake_value, new_cake) //new cake added by user / default value
            };

            //call the CakeThiefHelper to calculate the max duffelbag value
            
            cs = cth.MaxDuffelBagValue(ct_arr, w_duffelbag);

            Console.WriteLine(cs.message);
            Console.WriteLine("You've received " + cs.shillings + " shillings!");
            Console.WriteLine("Your duffelbag carried " + cs.Weight + "lbs of cakes!\n\r");

            foreach (var cake in cs.DuffelBag)
            {
                cake_name = cake.cake_name;
                num_cake = cake.number_of_cakes;
                val_cake = cake.value_per_cake;
                weight_cake = cake.weight_of_cake;
            }

            Console.WriteLine("Youve stolen " + num_cake + " of " + cake_name + "\nto the value of " + val_cake + " per cake \nat a weight of " + weight_cake + " lbs per cake.\n\r");

        }
    }
}
