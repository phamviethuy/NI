using System;
using NationalInstruments.UI;


namespace NationalInstruments.Examples.CustomCoercionMode
{
    /// <summary>
    /// Summary description for CustomCoercion.
    /// </summary>
    public class CustomCoercion:NumericCoercionMode
    {
        private Range noCoercionRange;
        private Range toIntervalRange;
        private const double noCoercionInterval = 0.1;
        
        public CustomCoercion(Range noCoercionRange,Range toIntervalRange)
        {
            this.noCoercionRange = noCoercionRange;
            this.toIntervalRange = toIntervalRange;        
        }

        public override string Name
        {
            get
            {
                return "Custom Coercion Mode";
            }
        }

        public override double GetNextValue(INumericControl context, NumericCoercionModeArgs args)
        {            
            double currentValue = args.Value;

            if ((currentValue < toIntervalRange.Maximum) && (currentValue >= toIntervalRange.Minimum))
            {
                return NumericCoercionMode.ToInterval.GetNextValue(context, args);
            }
            else if ((currentValue < noCoercionRange.Maximum) && (currentValue >= noCoercionRange.Minimum))
            {
                return currentValue + noCoercionInterval;
            }
            else
            {
                return NumericCoercionMode.ToDivisions.GetNextValue(context, args);
            }
        }

        public override double CoerceValue(INumericControl context, NumericCoercionModeArgs args)
        {   
            double currentValue = args.Value;

            if( (currentValue < toIntervalRange.Maximum) && (currentValue >= toIntervalRange.Minimum))
            {
                return NumericCoercionMode.ToInterval.CoerceValue(context,args);
            }
            else if ((currentValue < noCoercionRange.Maximum) && (currentValue >= noCoercionRange.Minimum))
            {
                return currentValue;            
            }
            else
            {
                return NumericCoercionMode.ToDivisions.CoerceValue(context,args);
            }
        }

        public override double GetPreviousValue(INumericControl context, NumericCoercionModeArgs args)
        {
            double currentValue = args.Value;

            if ((currentValue <= toIntervalRange.Maximum) && (currentValue >= toIntervalRange.Minimum))
            {
                return NumericCoercionMode.ToInterval.GetPreviousValue(context, args);
            }
            else if ((currentValue <= noCoercionRange.Maximum) && (currentValue >= noCoercionRange.Minimum))
            {
                return (currentValue - noCoercionInterval);
            }
            else
            {
                return NumericCoercionMode.ToDivisions.GetPreviousValue(context, args);
            }
        }
    }
}
