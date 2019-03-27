
namespace dev_4
{
    public static class GUIDSetter
    {
        public static void SetGUID(this string str, EntityInfo entity)
        {
            str = entity.TextDescription + entity.GetHashCode();
        }
    }
}