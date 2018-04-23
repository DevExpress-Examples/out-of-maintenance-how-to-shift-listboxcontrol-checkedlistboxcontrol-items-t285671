using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using System;

namespace Example
{
    [ToolboxItem(true)]
    public class CustomCheckedListBoxControl : CheckedListBoxControl
    {
        protected override BaseStyleControlViewInfo CreateViewInfo() { return new CustomCheckedListBoxViewInfo(this); }
 
        #region CreateItemInfo
        public event EventHandler<ItemInfoEventArgs> OnCreateItemInfo;
        protected internal void RaiseOnCreateItemInfo(ItemInfoEventArgs ea)
        {
            EventHandler<ItemInfoEventArgs> handler = OnCreateItemInfo;
            if (handler != null)
                handler(this, ea);
        }
        #endregion
    }
}
