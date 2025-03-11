using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.Guitar_start
{
    public class FindGuitarTester
    {
        public static void main(String[] args)
        {
            // Set up Rick's guitar inventory
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            MandolinSpec whatErinLikes =
              new MandolinSpec(Builder.PRS, "Dave Navarro Signature", Type.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE, Style.F);

           

            List<Mandolin> matchingGuitars = inventory.search(whatErinLikes);
            if (matchingGuitars.Any())
            {
                Console.WriteLine("Erin, you might like these guitars:");
                for (int i = 0; i<matchingGuitars.Count(); i++)
                {
                    Mandolin guitar = matchingGuitars[i];
                    InstrumentSpec spec = guitar.getSpec(); //retrieving the spec of the guitar ( returns concrete subclass). 
                    //We are not creating a new spec object, we are just getting the spec of the guitar object.
                    Console.WriteLine("  We have a " +
                      spec.getBuilder() + " " + spec.getModel() + " " +
                      spec.getType() + " guitar:\n     " +
                      spec.getBackWood() + " back and sides,\n     " +
                      spec.getTopWood() + " top.\n  You can have it for only $" +
                      guitar.getPrice() + "!\n  ----" + ((MandolinSpec)spec).getStyle()); //Downcasting the spec object to MandolinSpec to get the style.
                                                                                          //virtual and override is preffered than downcasting.
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }

        private static void initializeInventory(Inventory inventory)
        {
            inventory.addInstrument("11277", 3999.95,
              new GuitarSpec(Builder.COLLINGS, "CJ", Type.ACOUSTIC,
                             Wood.INDIAN_ROSEWOOD, Wood.SITKA, 6));
            inventory.addInstrument("V95693", 1499.95,
              new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC,
                             Wood.ALDER, Wood.ALDER, 6));
            inventory.addInstrument("V9512", 1549.95,
              new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC,
                             Wood.ALDER, Wood.ALDER, 6));
            inventory.addInstrument("122784", 5495.95,
              new GuitarSpec(Builder.MARTIN, "D-18", Type.ACOUSTIC,
                             Wood.MAHOGANY, Wood.ADIRONDACK, 6));
            inventory.addInstrument("76531", 6295.95,
              new GuitarSpec(Builder.MARTIN, "OM-28", Type.ACOUSTIC,
                             Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK, 6));
            inventory.addInstrument("70108276", 2295.95,
              new GuitarSpec(Builder.GIBSON, "Les Paul", Type.ELECTRIC,
                             Wood.MAHOGANY, Wood.MAHOGANY, 6));
            inventory.addInstrument("82765501", 1890.95,
              new GuitarSpec(Builder.GIBSON, "SG '61 Reissue", Type.ELECTRIC,
                             Wood.MAHOGANY, Wood.MAHOGANY, 6));
            inventory.addInstrument("77023", 6275.95,
              new GuitarSpec(Builder.MARTIN, "D-28", Type.ACOUSTIC,
                             Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK, 6));
            inventory.addInstrument("1092", 12995.95,
              new GuitarSpec(Builder.OLSON, "SJ", Type.ACOUSTIC,
                             Wood.INDIAN_ROSEWOOD, Wood.CEDAR,12));
            inventory.addInstrument("566-62", 8999.95,
              new GuitarSpec(Builder.RYAN, "Cathedral", Type.ACOUSTIC,
                             Wood.COCOBOLO, Wood.CEDAR,12));
            inventory.addInstrument("6 29584", 2100.95,
              new GuitarSpec(Builder.PRS, "Dave Navarro Signature", Type.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE, 6));


            inventory.addInstrument("6 29584", 2100.95,
              new MandolinSpec(Builder.PRS, "Dave Navarro Signature", Type.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE, Style.F));
            inventory.addInstrument("6 29584", 2100.95,
              new MandolinSpec(Builder.PRS, "Dave Navarro Signature", Type.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE, Style.A));

        }

    }
}
