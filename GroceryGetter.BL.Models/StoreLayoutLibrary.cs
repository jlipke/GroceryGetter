using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryGetter.BL.Models
{
    public static class StoreLayoutLibrary
    {
        public static Dictionary<AisleLocation, int> walmartLayout = new Dictionary<AisleLocation, int>() {
                { AisleLocation.BREAD, 0 },
                { AisleLocation.CEREAL, 1 },
                { AisleLocation.PRODUCE, 2 },
                { AisleLocation.CLEANING, 3 }
            };

        public static Dictionary<AisleLocation, int> aldiLayout = new Dictionary<AisleLocation, int>() {
                { AisleLocation.BREAD, 0 },
                { AisleLocation.CEREAL, 1 },
                { AisleLocation.PRODUCE, 2 },
                { AisleLocation.CLEANING, 3 }
            };

        public static Dictionary<AisleLocation, int> kroggerLayout = new Dictionary<AisleLocation, int>() {
                { AisleLocation.BREAD, 0 },
                { AisleLocation.CEREAL, 1 },
                { AisleLocation.PRODUCE, 2 },
                { AisleLocation.CLEANING, 3 }
            };

        public static Dictionary<AisleLocation, int> festivalLayout = new Dictionary<AisleLocation, int>() {
                { AisleLocation.BREAD, 0 },
                { AisleLocation.CEREAL, 1 },
                { AisleLocation.PRODUCE, 2 },
                { AisleLocation.CLEANING, 3 }
            };

        public static Dictionary<AisleLocation, int> alphabeticalLayout = new Dictionary<AisleLocation, int>() {
                { AisleLocation.BREAD, 0 },
                { AisleLocation.CEREAL, 1 },
                { AisleLocation.PRODUCE, 2 },
                { AisleLocation.CLEANING, 3 }
            };

    }
}
