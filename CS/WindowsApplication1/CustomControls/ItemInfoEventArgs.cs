using System;
using System.Collections.Generic;
using System.Linq;

namespace Example
{
    public class ItemInfoEventArgs : EventArgs
    {
        public ItemInfoEventArgs(int _index, object _ItemValue)
        {
            ItemIndex = _index;
            ItemOffset = 0;
            ItemValue = _ItemValue;
        }

        public int ItemOffset { get; set; }
        public int ItemIndex { get; private set; }
        public object ItemValue { get; private set; }
    }
}
