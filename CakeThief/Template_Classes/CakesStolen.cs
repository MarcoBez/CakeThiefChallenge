using System;
using System.Collections.Generic;
using System.Text;
//Author - Marco Bezuidenhout 20200804
namespace CakeThief
{
    public class CakesStolen
    {
        public string message { get; set; }
        public long shillings { get; set; }
        public long Weight { get; set; }
        public List<CakesInDuffelBag> DuffelBag { get; set; }

        public CakesStolen()
        {
            //
            // TODO: Add constructor logic here
            //
            DuffelBag = new List<CakesInDuffelBag>();
        }


    }

}
