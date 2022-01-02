
namespace btl
{
    partial class orderDetail
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
            this.dbOrderDetail = new System.Windows.Forms.DataGridView();
            this.btBackHome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dbOrderDetail
            // 
            this.dbOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbOrderDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dbOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbOrderDetail.Location = new System.Drawing.Point(40, 125);
            this.dbOrderDetail.Name = "dbOrderDetail";
            this.dbOrderDetail.RowHeadersWidth = 51;
            this.dbOrderDetail.RowTemplate.Height = 29;
            this.dbOrderDetail.Size = new System.Drawing.Size(514, 140);
            this.dbOrderDetail.TabIndex = 0;
            this.dbOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbOrderDetail_CellContentClick);
            // 
            // btBackHome
            // 
            this.btBackHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBackHome.Location = new System.Drawing.Point(234, 55);
            this.btBackHome.Name = "btBackHome";
            this.btBackHome.Size = new System.Drawing.Size(94, 29);
            this.btBackHome.TabIndex = 1;
            this.btBackHome.Text = "Quay lại";
            this.btBackHome.UseVisualStyleBackColor = true;
            this.btBackHome.Click += new System.EventHandler(this.btBackHome_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // orderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btBackHome);
            this.Controls.Add(this.dbOrderDetail);
            this.Name = "orderDetail";
            this.Text = "Order Detail";
            this.Load += new System.EventHandler(this.orderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbOrderDetail;
        private System.Windows.Forms.Button btBackHome;
        private System.Windows.Forms.Button button1;
    }
}