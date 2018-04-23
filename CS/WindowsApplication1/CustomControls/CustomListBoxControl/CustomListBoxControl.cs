using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using System;

namespace Example
{
    [ToolboxItem(true)]
    public class CustomListBoxControl : ListBoxControl
    {
        protected override BaseStyleControlViewInfo CreateViewInfo() { return new CustomListBoxViewInfo(this); }
 
        #region ShiftItem
        public event EventHandler<ItemInfoEventArgs> ShiftItem;
        protected internal void RaiseShiftItem(ItemInfoEventArgs ea)
        {
            EventHandler<ItemInfoEventArgs> handler = ShiftItem;
            if (handler != null)
                handler(this, ea);
        }
        #endregion
    }
}
