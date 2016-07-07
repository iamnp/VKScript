using System.Collections.Generic;

namespace VKScript.VkScript
{
    internal class Memory
    {
        private readonly Dictionary<string, Value> _memory = new Dictionary<string, Value>();

        public Value this[string key]
        {
            get
            {
                if (_memory.ContainsKey(key)) return _memory[key];
                return null;
            }
            set { _memory[key] = value; }
        }
    }
}