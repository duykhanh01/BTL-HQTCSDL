
namespace btl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKH = new System.Windows.Forms.TabPage();
            this.btnHienThiKH = new System.Windows.Forms.Button();
            this.bangKH = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangKH)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabKH);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(54, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKH
            // 
            this.tabKH.Controls.Add(this.btnXoaKH);
            this.tabKH.Controls.Add(this.btnHienThiKH);
            this.tabKH.Controls.Add(this.bangKH);
            this.tabKH.Location = new System.Drawing.Point(4, 29);
            this.tabKH.Name = "tabKH";
            this.tabKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabKH.Size = new System.Drawing.Size(689, 393);
            this.tabKH.TabIndex = 0;
            this.tabKH.Text = "Khách hàng";
            this.tabKH.UseVisualStyleBackColor = true;
            this.tabKH.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnHienThiKH
            // 
            this.btnHienThiKH.Location = new System.Drawing.Point(86, 65);
            this.btnHienThiKH.Name = "btnHienThiKH";
            this.btnHienThiKH.Size = new System.Drawing.Size(94, 29);
            this.btnHienThiKH.TabIndex = 1;
            this.btnHienThiKH.Text = "Hiển thị";
            this.btnHienThiKH.UseVisualStyleBackColor = true;
            this.btnHienThiKH.Click += new System.EventHandler(this.btnHienThiKH_Click);
            // 
            // bangKH
            // 
            this.bangKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangKH.Location = new System.Drawing.Point(6, 124);
            this.bangKH.Name = "bangKH";
            this.bangKH.RowHeadersWidth = 51;
            this.bangKH.RowTemplate.Height = 29;
            this.bangKH.Size = new System.Drawing.Size(680, 165);
            this.bangKH.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(255, 65);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(94, 29);
            this.btnXoaKH.TabIndex = 2;
            this.btnXoaKH.Text = "Xoá";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bangKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKH;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnHienThiKH;
        private System.Windows.Forms.DataGridView bangKH;
        private System.Windows.Forms.Button btnXoaKH;
    }
}

