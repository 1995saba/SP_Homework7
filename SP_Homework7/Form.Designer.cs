namespace SP_Homework7
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.valuesListView = new System.Windows.Forms.ListView();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keysTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // valuesListView
            // 
            this.valuesListView.Location = new System.Drawing.Point(355, 66);
            this.valuesListView.Name = "valuesListView";
            this.valuesListView.Size = new System.Drawing.Size(398, 291);
            this.valuesListView.TabIndex = 15;
            this.valuesListView.UseCompatibleStateImageBehavior = false;
            this.valuesListView.View = System.Windows.Forms.View.Details;
            // 
            // closeButton
            // 
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Location = new System.Drawing.Point(355, 387);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(89, 46);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Values";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(62, 34);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(30, 13);
            this.keyLabel.TabIndex = 11;
            this.keyLabel.Text = "Keys";
            // 
            // keysTreeView
            // 
            this.keysTreeView.Location = new System.Drawing.Point(62, 66);
            this.keysTreeView.Name = "keysTreeView";
            this.keysTreeView.Size = new System.Drawing.Size(270, 291);
            this.keysTreeView.TabIndex = 16;
            this.keysTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.KeysTreeView_BeforeExpand);
            this.keysTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.KeysTreeView_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 476);
            this.Controls.Add(this.keysTreeView);
            this.Controls.Add(this.valuesListView);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView valuesListView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TreeView keysTreeView;
    }
}

