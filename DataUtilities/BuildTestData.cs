using System;
using System.Collections.Generic;

namespace DataUtilities
{
    public static class BuildTestData
    {
        /// <summary>
        /// Static function that generates test data comprising of a list of 5 string values.
        /// </summary>
        /// <returns>List of type string containing 5 items</returns>
        public static List<String> BuildListOfString()
        {
            List<string> output = new List<string>();

            output.Add("Item One");
            output.Add("Item Two");
            output.Add("Item Three");
            output.Add("Item four");
            output.Add("Item Five");

            return output;
        }
    }
}
