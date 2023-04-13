namespace 调用WebServices
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
            this.btnHQ = new DevExpress.XtraEditors.SimpleButton();
            this.txt = new DevExpress.XtraEditors.MemoEdit();
            this.tlMain = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnServer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHQ
            // 
            this.btnHQ.Location = new System.Drawing.Point(491, 12);
            this.btnHQ.Name = "btnHQ";
            this.btnHQ.Size = new System.Drawing.Size(106, 32);
            this.btnHQ.TabIndex = 0;
            this.btnHQ.Text = "获取本地";
            this.btnHQ.Click += new System.EventHandler(this.btnHQ_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 62);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(713, 64);
            this.txt.TabIndex = 1;
            // 
            // tlMain
            // 
            this.tlMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4});
            this.tlMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlMain.Location = new System.Drawing.Point(13, 133);
            this.tlMain.Name = "tlMain";
            this.tlMain.Size = new System.Drawing.Size(712, 200);
            this.tlMain.TabIndex = 2;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "ID";
            this.treeListColumn1.FieldName = "ID";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 123;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "姓名";
            this.treeListColumn2.FieldName = "Name";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 232;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "性别";
            this.treeListColumn3.FieldName = "Sex";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 177;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "年龄";
            this.treeListColumn4.FieldName = "Age";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            this.treeListColumn4.Width = 162;
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(619, 12);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(106, 32);
            this.btnServer.TabIndex = 0;
            this.btnServer.Text = "获取服务器";
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 346);
            this.Controls.Add(this.tlMain);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnHQ);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHQ;
        private DevExpress.XtraEditors.MemoEdit txt;
        private DevExpress.XtraTreeList.TreeList tlMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraEditors.SimpleButton btnServer;
    }
}

