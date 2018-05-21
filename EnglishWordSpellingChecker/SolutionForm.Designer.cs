namespace EnglishWordSpellingChecker
{
    partial class SolutionForm
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
            this._listBox = new System.Windows.Forms.ListBox();
            this._table = new System.Windows.Forms.TableLayoutPanel();
            this._ok = new System.Windows.Forms.Button();
            this._table.SuspendLayout();
            this.SuspendLayout();
            // 
            // _listBox
            // 
            this._listBox.FormattingEnabled = true;
            this._listBox.ItemHeight = 12;
            this._listBox.Location = new System.Drawing.Point(2, 2);
            this._listBox.Margin = new System.Windows.Forms.Padding(2);
            this._listBox.Name = "_listBox";
            this._listBox.Size = new System.Drawing.Size(81, 64);
            this._listBox.TabIndex = 0;
            // 
            // _table
            // 
            this._table.AutoSize = true;
            this._table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._table.ColumnCount = 1;
            this._table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._table.Controls.Add(this._listBox, 0, 0);
            this._table.Controls.Add(this._ok, 0, 1);
            this._table.Location = new System.Drawing.Point(1, 0);
            this._table.Name = "_table";
            this._table.RowCount = 2;
            this._table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._table.Size = new System.Drawing.Size(85, 97);
            this._table.TabIndex = 1;
            // 
            // _ok
            // 
            this._ok.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._ok.Location = new System.Drawing.Point(7, 71);
            this._ok.Name = "_ok";
            this._ok.Size = new System.Drawing.Size(75, 23);
            this._ok.TabIndex = 1;
            this._ok.Text = "OK";
            this._ok.UseVisualStyleBackColor = true;
            this._ok.Click += new System.EventHandler(this.ClickOkButton);
            // 
            // SolutionForm
            // 
            this.AcceptButton = this._ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(158, 106);
            this.Controls.Add(this._table);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SolutionForm";
            this.Text = "Result & Solution";
            this._table.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _listBox;
        private System.Windows.Forms.TableLayoutPanel _table;
        private System.Windows.Forms.Button _ok;
    }
}