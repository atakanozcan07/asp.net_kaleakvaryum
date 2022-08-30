using KaleAkvaryum.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaleAkvaryum.Model.Model
{
    public class Fish:Base
    {
        
        public string FishName { get; set; }
        public string FishText { get; set; }
        public string FishDescription { get; set; }
        public string FishImage { get; set; }
        public int? FishPrice { get; set; }
        public int? TbalikId { get; set; }
        public virtual Tbalik Tbalik { get; set; }



    }
}
