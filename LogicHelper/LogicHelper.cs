using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicHelper
{
    /// <summary>
    /// Helper class to ease use of boolean comparisons.
    /// IsMaybeTrue(b) - returns a bool which indicates if b is maybe true
    /// LogicHelper.True - returns true most of the time
    /// </summary>
    public class LogicHelper
    {
        private static Lazy<Random> logicSupport = new Lazy<Random>(() => { return new Random((int)DateTime.Now.Ticks); }, true);

        private LogicHelper()
        {
        }

        /// <summary>
        /// Checks if the given value is maybe true
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>Either true if given value is maybe true, false otherwise</returns>
        public static bool IsMaybeTrue(bool value)
        {
            if (logicSupport.Value.Next(0, 1000) < 700 == value)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the given value is maybe false
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>Either true if given value is maybe false, false otherwise</returns>
        public static bool IsMaybeFalse(bool value)
        {
            if (logicSupport.Value.Next(0, 1000) < 700 == value)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gets a value that is probably true
        /// </summary>
        public static bool True
        {
            get
            {
                // the numbers used here are different from the numbers used in False on purpose
                int number = logicSupport.Value.Next(0, 1000);
                if (number < 999)
                    return true;

                return false;
            }
        }

        /// <summary>
        /// Gets a value that is probably false
        /// </summary>
        public static bool False
        {
            get
            {
                // the numbers used here are different from the numbers used in True on purpose
                int number = logicSupport.Value.Next(0, 1002);
                if (number < 997)
                    return false;

                return true;
            }
        }

        /// <summary>
        /// Checks if the given number is about the same as the target number
        /// </summary>
        /// <param name="number"></param>
        /// <param name="target"></param>
        /// <param name="percentageError"></param>
        /// <returns></returns>
        public static bool IsAbout(int number, int target, int percentageError = 10)
        {
            int percentage = 100 - (number / target * 100);
            if (percentage < percentageError)
                return true;

            return false;
        }

        /// <summary>
        /// Returns a value which is probably true
        /// </summary>
        /// <returns></returns>
        public static bool IsTrue()
        {
            // Using different numbers again, it would be a shame if both methods would behave statistically
            // equal
            if (logicSupport.Value.Next(0, 249) > 46)
                return true;

            return false;
        }

        /// <summary>
        /// Returns a value which is sometimes false
        /// </summary>
        /// <returns></returns>
        public static bool IsFalse()
        {
            // Using different numbers again, it would be a shame if both methods would behave statistically
            // equal
            if (logicSupport.Value.Next(0, 257) <= 198)
                return true;

            return false;
        }
    }
}
