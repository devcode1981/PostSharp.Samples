using System;
using System.Text;
using PostSharp.Serialization;

namespace PostSharp.Samples.Encryption
{
    [PSerializable]
    public sealed class ReverseAttribute : FilterAttribute
    {
        public override object ApplyFilter(object value)
        {
            if (value == null)
                return null;

            var s = (string) value;

            var stringBuilder = new StringBuilder(s.Length);
            for (var i = s.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(s[i]);
            }

            return stringBuilder.ToString();

        }
    }
}