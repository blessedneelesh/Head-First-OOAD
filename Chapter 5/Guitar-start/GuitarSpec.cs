using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.Guitar_start
{
    public class GuitarSpec:InstrumentSpec
    {
        private int numStrings;

        public GuitarSpec(Builder _builder, string _model, Type _type, Wood _backWood, Wood _topWood, int _numStrings)
            : base(_builder, _model, _type,_backWood,_topWood)
        {
            numStrings = _numStrings;
        }

        public int getNumStrings()
        {
            return numStrings;
        }

        public override bool matches(GuitarSpec otherSpec)
        {
            if (getBuilder() != otherSpec.getBuilder())
                return false;
            if ((getModel() != null) && (!getModel().Equals("")) &&
                (!model.ToLower().Equals(otherSpec.model.ToLower())))
                return false;
            if (type != otherSpec.type)
                return false;
            if (numStrings != otherSpec.numStrings)
                return false;
            if (backWood != otherSpec.backWood)
                return false;
            if (topWood != otherSpec.topWood)
                return false;
            return true;
        }
    }
}
