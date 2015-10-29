using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.DataTransferObjects
{
    public class Alarm
    {
        #region properties
        private Guid _guid;
        public Guid Guid { get { return _guid; } }

        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private int _priority;
        public int Priority { get { return _priority; } set { _priority = value; } }
        #endregion

        /// <summary>
        /// Constructor for instantiating an Alarm object
        /// when reading from the database.
        /// </summary>
        /// <param name="guid">GUID column as read from SqlDataReader</param>
        /// <param name="name">Name column as read from SqlDataReader</param>
        /// <param name="priority">Priority column as read from SqlDataReader</param>
        public Alarm(Guid guid, String name, int priority)
        {
            this._guid = guid;
            this._name = name;
            this._priority = priority;
        }

        public override string ToString()
        {
            return string.Format("{0,40} {1,30} {2,2}", Guid, Name, Priority);
        }
    }
}
