using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.Controls.Primitives;
using NationalInstruments.DataInfrastructure.Descriptors;

namespace NationalInstruments.Examples.Formatting
{
    /// <summary>
    /// This class is a ValueFormatter which converts numeric values to a binary string.
    /// </summary>
    public class BinaryValueFormatter : ValueFormatter
    {
        private int padding;

        public BinaryValueFormatter(int pad)
        {
            padding = pad;
        }

        protected override string FormatCore<TData>(TData value, ValuePresenterArgs args)
        {
            if (value == null)
            {
                return string.Empty;
            }
            long integerValue = Convert.ToInt64(value);

            // Convert the integer value to a binary string and then apply padding if necessary
            StringBuilder result = new StringBuilder(Convert.ToString(integerValue, 2));
            while (result.Length < padding)
            {
                result.Insert(0, "0");
            }
            return result.ToString();
        }

        public override TData Parse<TData>(string value, ValuePresenterArgs args)
        {
            long integerValue = Convert.ToInt64(value, 2);

            // In order to convert the integer into the specific TData type we get a formatter for TData
            // and then use that formatter to convert a string of the integer into type TData
            IOpFormat<TData> formatter = DataTypeDescriptors.GetDescriptorInstance<TData>() as IOpFormat<TData>;
            if (formatter == null)
            {
                throw new System.ArgumentException("Cannot parse into type {" + typeof(TData).Name + "}", "TData");
            }
            TData parsedValue = formatter.Parse(integerValue.ToString(args.Culture), null, args.Culture);
            
            return parsedValue;
        }

        public override bool TryParse<TData>(string value, ValuePresenterArgs args, out TData parsedValue)
        {
            long integerValue = Convert.ToInt64(value, 2);

            // In order to convert the integer into the specific TData type we get a formatter for TData
            // and then use that formatter to convert a string of the integer into type TData
            IOpFormat<TData> formatter = DataTypeDescriptors.GetDescriptorInstance<TData>() as IOpFormat<TData>;
            bool succeeded;
            if (formatter == null)
            {
                succeeded = false;
                parsedValue = default(TData);
            }
            else
            {
                succeeded = formatter.TryParse(integerValue.ToString(args.Culture), null, args.Culture, out parsedValue);
            }

            return succeeded;
        }

        protected override System.Windows.Freezable CreateInstanceCore()
        {
            return new BinaryValueFormatter(0);
        }
    }
}
