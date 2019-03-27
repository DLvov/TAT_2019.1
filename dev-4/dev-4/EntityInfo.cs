using System;

namespace dev_4
{
    /// <summary>
    /// This class contains the fields and methods that all entities have.
    /// </summary>
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

        /// <summary>
        /// This method returns a text description of the entity.
        /// </summary>
        /// <returns>Text description of entity</returns>
        override public string ToString()
        {
            return TextDescription;
        }

        /// <summary>
        /// This method compares the current object with the passed object.
        /// </summary>
        /// <param name="obj">The object to be compared with</param>
        /// <returns>Comparison result</returns>
        public bool Equals(EntityInfo obj)
        {
            return GUID == obj.GUID;
        }
    }
}