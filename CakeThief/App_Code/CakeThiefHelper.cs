using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//Author - Marco Bezuidenhout 20200804
namespace CakeThief
{
    public class CakeThiefHelper
    {
        public CakesStolen MaxDuffelBagValue(CakeType[] cakeTypes, int duffelbag_capacity)
        {

            /*
             * takes an array of type CakeType
             * a weight capacity of type int
             * returns an object of CakesStolen
             *      with a string message
             *      shillings monetary value of type long
             *      CakeType array that fits in the duffelbag
             */
             //variables
            CakesStolen cs = new CakesStolen();
            CakesInDuffelBag csid = new CakesInDuffelBag();
            List<decimal> l_ratio = new List<decimal>();
            List<int> l_bag_cakes = new List<int>();
            List<long> l_value = new List<long>();
            List<int> l_weight = new List<int>();
            decimal ratio, max_ratio;
            int bag_cakes, bag_cakes_of_max;
            int max_ratio_index; 
            int duffelbag_capacity_remain = duffelbag_capacity;

            //loop through the cake types and create lists
            foreach (var cake in cakeTypes)
            {
                //add items of caketypes to lists
                l_value.Add(cake.Value);
                l_weight.Add(cake.Weight);
            }

            do
            {
                //loop through the cake types
                for (int i = 0; i < l_value.Count; i++)
                {
                    //get the value ratio's of each cake
                    ratio = l_value[i] / l_weight[i];
                    ratio = Math.Round(ratio, 2);
                    l_ratio.Add(ratio);

                    //how many times can each cake go into the duffelbag
                    bag_cakes = duffelbag_capacity / l_weight[i];
                    l_bag_cakes.Add(bag_cakes);
                }

                //get max ratio value
                max_ratio = l_ratio.Max();
                //get the index
                max_ratio_index = l_ratio.IndexOf(max_ratio);
                //get the amount of cakes that fits in the bag
                bag_cakes_of_max = l_bag_cakes[max_ratio_index];
                //get the remaining weight in duffelbag
                CakeType ct_max = cakeTypes[max_ratio_index];
                duffelbag_capacity_remain = duffelbag_capacity_remain - (ct_max.Weight * bag_cakes_of_max);

                //assign to CakesStolen
                cs.message = "max value cakes assigned";
                cs.shillings = cs.shillings + ct_max.Value * bag_cakes_of_max;
                cs.Weight = cs.Weight + ct_max.Weight * bag_cakes_of_max;


                //add the cakes with the max ratio
                for (int i = 0; i < bag_cakes_of_max; i++)
                {
                    csid.number_of_cakes = bag_cakes_of_max;
                    csid.weight_of_cake = ct_max.Weight;
                    csid.value_per_cake = ct_max.Value;
                    csid.cake_name = ct_max.Name;
                    cs.DuffelBag.Add(csid);                    
                }

                //get rid of max cake value and weight as you cant take anymore of it
                int index_v = l_value.IndexOf(ct_max.Value);
                int index_w = l_weight.IndexOf(ct_max.Weight);
                l_value.RemoveAt(index_v);
                l_weight.RemoveAt(index_w);

                //check if smallest cake's weight is more than the remaining weight in the duffelbag end
            } while (l_weight.Min() < duffelbag_capacity_remain); 

            return cs;
        }
    }
}
