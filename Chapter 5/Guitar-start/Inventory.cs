using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.Guitar_start
{
    public class Inventory
    {
        private List<Instrument> inventory;
        //private List<Guitar> guitars;
        //private List<Mandolin> mandolins;
        public Inventory()
        {
            //guitars = new List<Guitar>();
            //mandolins = new List<Mandolin>();
            inventory = new List<Instrument>();
        }

        public void addInstrument(String serialNumber, double price, InstrumentSpec spec)
        {
            Instrument instrument = null;
            if (spec is GuitarSpec)
            {
                instrument = new Guitar(serialNumber, price, (GuitarSpec)spec);
            }else if(spec is MandolinSpec)
            {
                instrument = new Mandolin(serialNumber, price, (MandolinSpec) spec);
            }
               //Guitar guitar = new Guitar(serialNumber, price, spec);
            inventory.Add(instrument);
        }

        //public void addGuitar(String serialNumber, double price, GuitarSpec spec){
        //    Guitar guitar = new Guitar(serialNumber, price, spec);
        //    guitars.Add(guitar);
        //}
        public Instrument get(String serialNumber)
        {
            for (int i = 0; i<inventory.Count(); i++)
            {
                Instrument instrument = inventory[i];
                if (instrument.getSerialNumber().Equals(serialNumber))
                {
                    return instrument;
                }
            }
            return null;
        }
        public List<Guitar> search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            for (int i = 0; i< inventory.Count(); i++)
            {
                if (inventory[i] is Guitar guitar)
                {
                    if (guitar.getSpec().matches(searchSpec))
                        matchingGuitars.Add(guitar);
                }
            }
            return matchingGuitars;
        }

        public List<Mandolin> search(MandolinSpec searchSpec)
        {
            List<Mandolin> matchingMandolin = new List<Mandolin>();
            for (int i = 0; i < inventory.Count(); i++)
            {
                if (inventory[i] is Mandolin mandolin)
                {
                    if (mandolin.getSpec().matches(searchSpec))
                        matchingMandolin.Add(mandolin);
                }
            }
            return matchingMandolin;
        }
    }
}
