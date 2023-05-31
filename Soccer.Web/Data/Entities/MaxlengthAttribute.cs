using System;

namespace Soccer.Web.Data.Entities
{
    internal class MaxlengthAttribute : Attribute
    {
        private int v;

        public MaxlengthAttribute(int v, string ErrorMessage)
        {
            this.v = v;
            this.ErrorMessage = ErrorMessage;
        }

        public string ErrorMessage { get; set; }
    }
}