namespace CanamlaArts.Utilities
{
    public static class ArrayExt
    {
        /// <summary>
        /// Shifts all elements of the array to the end, inserting the given item at the beginning. The last element value is extruded.
        /// </summary>
        /// <param name="array">The array source</param>
        /// <param name="item">The intruding item</param>
        /// <param name="extruded">The item extruded</param>
        /// <typeparam name="T">Any</typeparam>
        public static void IntrudeStart<T>(this T[] array, T item, out T extruded)
        {
            extruded = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i > 0)
                {
                    array[i] = array[i - 1];
                    continue;
                }
                array[i] = item;
            }
        }


        /// <summary>
        /// Shifts all elements of the array to the start, inserting the given item at the end. The first element value is extruded.
        /// </summary>
        /// <param name="array">The array source</param>
        /// <param name="item">The intruding item</param>
        /// <param name="extruded">The item extruded</param>
        /// <typeparam name="T">Any</typeparam>
        public static void IntrudeEnd<T>(this T[] array, T item, out T extruded)
        {
            extruded = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    array[i] = array[i + 1];
                    continue;
                }
                array[i] = item;
            }
        }
    }
}