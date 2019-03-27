
namespace dev_4
{
    static class StringExtension
    {
        static void SetGUID(this string str, EntityInfo entity)
        {
            str = entity.TextDescription + entity.GetHashCode();
        }
    }
}