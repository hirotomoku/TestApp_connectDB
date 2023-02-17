namespace TestApp_connectDB
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DataTableReadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReaderReadbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableReadButton
            // 
            this.DataTableReadButton.Location = new System.Drawing.Point(36, 29);
            this.DataTableReadButton.Name = "DataTableReadButton";
            this.DataTableReadButton.Size = new System.Drawing.Size(141, 48);
            this.DataTableReadButton.TabIndex = 0;
            this.DataTableReadButton.Text = "DataTable read";
            this.DataTableReadButton.UseVisualStyleBackColor = true;
            this.DataTableReadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(476, 409);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReaderReadbutton
            // 
            this.ReaderReadbutton.Location = new System.Drawing.Point(36, 111);
            this.ReaderReadbutton.Name = "ReaderReadbutton";
            this.ReaderReadbutton.Size = new System.Drawing.Size(141, 48);
            this.ReaderReadbutton.TabIndex = 2;
            this.ReaderReadbutton.Text = "Reader read";
            this.ReaderReadbutton.UseVisualStyleBackColor = true;
            this.ReaderReadbutton.Click += new System.EventHandler(this.ReaderReadbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReaderReadbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DataTableReadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DataTableReadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReaderReadbutton;
    }
}

