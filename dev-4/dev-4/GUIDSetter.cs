
namespace dev_4
{
    /// <summary>
    /// This class contains the string extension method.
    /// </summary>
    public static class GUIDSetter
    {
        /// <summary>
        /// This method initializes the string to a unique value GUID.
        /// </summary>
        /// <param name="str">String to be initialized</param>
        /// <param name="entity">Entity that owns the string str</param>
        public static void SetGUID(this string str, EntityInfo entity)
        {
            str = entity.TextDescription + entity.GetHashCode();
        }
    }
}