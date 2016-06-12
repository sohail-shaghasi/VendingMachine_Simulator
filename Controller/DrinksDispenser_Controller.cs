using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine_SD.Model;
namespace VendingMachine_SD.Controller
{
    class DrinksDispenser_Controller
    {
        private int NumberOfDrinksCansBrand1_to_update = 0;
        private int NumberOfDrinksCansBrand2_to_update = 0;
        private int NumberOfDrinksCansBrand3_to_update = 0;
        private int NumberOfDrinksCansBrand4_to_update = 0;
        private int NumberOfDrinksCansBrand5_to_update = 0;

        public int DrinksBrand { get; set; }

        public void dispenseDrink()
        {
            var drinksModel = new DrinksModel();
            drinksModel.GetNumberOfEachBrandDrinksCansFromdb();
            NumberOfDrinksCansBrand1_to_update = Convert.ToInt32(drinksModel.NumberOfDrinksCansBrand1);
            NumberOfDrinksCansBrand2_to_update = Convert.ToInt32(drinksModel.NumberOfDrinksCansBrand2);
            NumberOfDrinksCansBrand3_to_update = Convert.ToInt32(drinksModel.NumberOfDrinksCansBrand3);
            NumberOfDrinksCansBrand4_to_update = Convert.ToInt32(drinksModel.NumberOfDrinksCansBrand4);
            NumberOfDrinksCansBrand5_to_update = Convert.ToInt32(drinksModel.NumberOfDrinksCansBrand5);
            if (DrinksBrand == 1)
            {
                NumberOfDrinksCansBrand1_to_update =Convert.ToInt32(drinksModel.NumberOfDrinksCansBrand1) - 1;
            }
            else if (DrinksBrand == 2)
            {
                NumberOfDrinksCansBrand2_to_update =Convert.ToInt32(drinksModel.NumberOfDrinksCansBrand2) - 1;

            }
            else if (DrinksBrand == 3)
            {
                NumberOfDrinksCansBrand3_to_update = Convert.ToInt32(drinksModel.NumberOfDrinksCansBrand3) - 1;

            }
            else if (DrinksBrand == 4)
            {
                NumberOfDrinksCansBrand4_to_update = Convert.ToInt32(drinksModel.NumberOfDrinksCansBrand4) - 1;

            }
            else if (DrinksBrand == 5)
            {
                NumberOfDrinksCansBrand5_to_update = Convert.ToInt32(drinksModel.NumberOfDrinksCansBrand5) - 1;

            }
            drinksModel.NumberOfDrinksCansBrand1 = NumberOfDrinksCansBrand1_to_update;
            drinksModel.NumberOfDrinksCansBrand2 = NumberOfDrinksCansBrand2_to_update;
            drinksModel.NumberOfDrinksCansBrand3 = NumberOfDrinksCansBrand3_to_update;
            drinksModel.NumberOfDrinksCansBrand4 = NumberOfDrinksCansBrand4_to_update;
            drinksModel.NumberOfDrinksCansBrand5 = NumberOfDrinksCansBrand5_to_update;
            drinksModel.UpdateNumberOfEachBrandDrinksCans();


        }
        

    }
}
