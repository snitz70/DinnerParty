using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += (CalculateCostOfBeveragesPerPerson() +
                    CostOfFoodPerPerson) * NumberOfPeople;

                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal CostOfDecorations;

            if (FancyDecorations)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }

            return CostOfDecorations;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal CostOfBeveragesPerPerson;
            if (HealthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }

            return CostOfBeveragesPerPerson;
        }
    }
}
