using System;

namespace dev_4
{
    public abstract class EntityInfo
    {
        public string GUID { get; set; }
        private string _textDescription;

        public string TextDescription
        {
            get
            {
                return _textDescription;
            }
            set
            {
                if(value.Length > 256)
                {
                    throw new FormatException("Text description length cannot be > 256");
                }
                _textDescription = value;
            }
        }

        override public string ToString()
        {
            return TextDescription;
        }

        public bool Equals(EntityInfo obj)
        {
            return GUID == obj.GUID;
        }
    }
}