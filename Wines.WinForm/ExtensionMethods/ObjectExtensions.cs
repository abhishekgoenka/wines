namespace Wines.WinForm.ExtensionMethods
{
    public static class ObjectExtensions
    {
        /// <summary>
        ///     Converts object to Int64
        /// </summary>
        /// <param name="value">Object</param>
        /// <returns>Int64 value</returns>
        public static long ToInt64(this object value)
        {
            if (long.TryParse(value.ToString(), out var result))
            {
                return result;
            }

            return 0;
        }
    }
}