using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.Guitar_start
{
    public class MandolinSpec:InstrumentSpec
    {
        private Style style;

        public MandolinSpec(Builder _builder, string _model, Type _type, Wood _backWood, Wood _topWood, Style _style)
            : base(_builder, _model, _type, _backWood, _topWood)
        {
            style = _style;
        }

        public Style getStyle()
        {
            return style;
        }

        public override bool matches(InstrumentSpec otherSpec)
        {
            if (!base.matches(otherSpec))
                return false;
            MandolinSpec spec = (MandolinSpec)otherSpec;
            if (style != spec.style)
                return false;
            return true;
        }
    }
}
