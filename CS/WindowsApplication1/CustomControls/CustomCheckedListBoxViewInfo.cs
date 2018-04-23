using System;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;

namespace Example
{
    public class CustomCheckedListBoxViewInfo : CheckedListBoxViewInfo
    {
        public CustomCheckedListBoxViewInfo(CheckedListBoxControl listBox) : base(listBox) { }
        private CustomCheckedListBoxControl ListBox { get { return OwnerControl as CustomCheckedListBoxControl; } }

        protected override ItemInfo CreateItemInfo(Rectangle bounds, object item, string text, int index)
        {
            ItemInfoEventArgs e = new ItemInfoEventArgs(index, bounds, item);
            ListBox.RaiseOnCreateItemInfo(e);
            ItemInfo itemInfo = base.CreateItemInfo(e.ItemBounds, item, text, index);
            itemInfo.Bounds = bounds; 
            return itemInfo;
        }


    }
}