namespace FreshFit.Model.Models
{
    public class FoodTypeFood
    {
        public int FoodID { get; set; }
        public virtual Food Food { get; set; }
        public int FoodTypeID { get; set; }
        public virtual FoodType FoodType { get; set; }
    }
}