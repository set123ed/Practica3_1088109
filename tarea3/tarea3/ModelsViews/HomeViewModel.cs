using System;
using tarea3.Models;
using tarea3.Views;
namespace tarea3.ModelsViews
{
    public class HomeViewModel
    {
        public MenuOptionPage BarAndHotelsMenuOption { get; set; } = new MenuOptionPage();

        public MenuOptionPage FineDinning { get; set; } = new MenuOptionPage();
        public MenuOptionPage Cafes { get; set; } = new MenuOptionPage();
        public MenuOptionPage Nearby { get; set; } = new MenuOptionPage();
        public MenuOptionPage FastFood { get; set; } = new MenuOptionPage();
        public MenuOptionPage FeaturedFoods { get; set; } = new MenuOptionPage();
        public HomeViewModel()
        {
            FineDinning.Image = "dinner";
            BarAndHotelsMenuOption.Image = "beer";
            Cafes.Image = "store";
            Nearby.Image = "location";
            FastFood.Image = "burger";
            FeaturedFoods.Image = "pizza";

            BarAndHotelsMenuOption.Title = "Bar & Hotels";
            FineDinning.Title = "Fine & Dinning";
            Cafes.Title = "Cafes";
            Nearby.Title = "Nearby";
            FastFood.Title = "Fast Food";
            FeaturedFoods.Title = "Featured Foods";
        }
    }
}

