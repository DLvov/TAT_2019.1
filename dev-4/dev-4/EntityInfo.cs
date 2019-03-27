
namespace dev_4
{
    abstract class EntityInfo
    {
        public string TextDescription { get; set; }
        public string guid { get; set; }

        override public string ToString()
        {
            return TextDescription;
        }

        public bool Equals(EntityInfo obj)
        {
            return guid == obj.guid;
        }
    }
}