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
            ItemInfoEventArgs e = new ItemInfoEventArgs(index, item);
            ListBox.RaiseShiftItem(e);
            Rectangle itemBounds = new Rectangle(bounds.X + e.ItemOffset, bounds.Y, bounds.Width, bounds.Height);
            ItemInfo itemInfo = base.CreateItemInfo(itemBounds, item, text, index);
            itemInfo.Bounds = bounds;
            return itemInfo;
        }


    }
}