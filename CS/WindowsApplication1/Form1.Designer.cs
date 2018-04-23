namespace Example
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.customCheckedListBoxControl1 = new Example.CustomCheckedListBoxControl();
            this.customListBoxControl1 = new Example.CustomListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customCheckedListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customListBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.customListBoxControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.customCheckedListBoxControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(433, 249);
            this.splitContainerControl1.SplitterPosition = 200;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // customCheckedListBoxControl1
            // 
            this.customCheckedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customCheckedListBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.customCheckedListBoxControl1.Name = "customCheckedListBoxControl1";
            this.customCheckedListBoxControl1.Size = new System.Drawing.Size(221, 249);
            this.customCheckedListBoxControl1.TabIndex = 0;
            // 
            // customListBoxControl1
            // 
            this.customListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customListBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.customListBoxControl1.Name = "customListBoxControl1";
            this.customListBoxControl1.Size = new System.Drawing.Size(200, 249);
            this.customListBoxControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 249);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "ListBoxControl";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customCheckedListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customListBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private CustomListBoxControl customListBoxControl1;
        private CustomCheckedListBoxControl customCheckedListBoxControl1;


    }
}

