using System;
using DevExpress.XtraEditors;

namespace Example
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            InitListBoxes();
        }

        private void InitListBoxes()
        {
            for (int i = 0; i < 10; i++)
            {
                customCheckedListBoxControl1.Items.Add(String.Format("Item {0}", i));
                customListBoxControl1.Items.Add(String.Format("Item {0}", i));
            }

            customCheckedListBoxControl1.ShiftItem += OnShiftItem;
            customListBoxControl1.ShiftItem += OnShiftItem;
        }

        private const int Offset = 20;
        private void OnShiftItem(object sender, ItemInfoEventArgs customEventArgs)
        {
            if (customEventArgs.ItemIndex % 2 == 1)
                customEventArgs.ItemOffset = Offset;
        }
    }
}