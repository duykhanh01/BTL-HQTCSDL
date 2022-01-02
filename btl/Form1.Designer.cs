
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
            this.components = new System.ComponentModel.Container();
            this.qlall = new System.Windows.Forms.TabControl();
            this.tabKH = new System.Windows.Forms.TabPage();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.db = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.qlhoadon = new System.Windows.Forms.TabPage();
            this.luuTT = new System.Windows.Forms.Button();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.btXuatHD = new System.Windows.Forms.Button();
            this.btXoaHD = new System.Windows.Forms.Button();
            this.btDetail = new System.Windows.Forms.Button();
            this.btShowOrder = new System.Windows.Forms.Button();
            this.dbOrder = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.qlall.SuspendLayout();
            this.tabKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            this.qlhoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // qlall
            // 
            this.qlall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qlall.Controls.Add(this.tabKH);
            this.qlall.Controls.Add(this.tabPage2);
            this.qlall.Controls.Add(this.qlhoadon);
            this.qlall.Location = new System.Drawing.Point(54, 0);
            this.qlall.Name = "qlall";
            this.qlall.SelectedIndex = 0;
            this.qlall.Size = new System.Drawing.Size(697, 426);
            this.qlall.TabIndex = 0;
            // 
            // tabKH
            // 
            this.tabKH.Controls.Add(this.tbTenKH);
            this.tabKH.Controls.Add(this.label2);
            this.tabKH.Controls.Add(this.textBox1);
            this.tabKH.Controls.Add(this.label1);
            this.tabKH.Controls.Add(this.button1);
            this.tabKH.Controls.Add(this.db);
            this.tabKH.Location = new System.Drawing.Point(4, 29);
            this.tabKH.Name = "tabKH";
            this.tabKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabKH.Size = new System.Drawing.Size(689, 393);
            this.tabKH.TabIndex = 0;
            this.tabKH.Text = "Khách hàng";
            this.tabKH.UseVisualStyleBackColor = true;
            this.tabKH.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(377, 41);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(125, 27);
            this.tbTenKH.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khách hàng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã KH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // db
            // 
            this.db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db.Location = new System.Drawing.Point(6, 212);
            this.db.Name = "db";
            this.db.RowHeadersWidth = 51;
            this.db.RowTemplate.Height = 29;
            this.db.Size = new System.Drawing.Size(680, 165);
            this.db.TabIndex = 0;
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
            // qlhoadon
            // 
            this.qlhoadon.Controls.Add(this.luuTT);
            this.qlhoadon.Controls.Add(this.cbTrangThai);
            this.qlhoadon.Controls.Add(this.btXuatHD);
            this.qlhoadon.Controls.Add(this.btXoaHD);
            this.qlhoadon.Controls.Add(this.btDetail);
            this.qlhoadon.Controls.Add(this.btShowOrder);
            this.qlhoadon.Controls.Add(this.dbOrder);
            this.qlhoadon.Location = new System.Drawing.Point(4, 29);
            this.qlhoadon.Name = "qlhoadon";
            this.qlhoadon.Padding = new System.Windows.Forms.Padding(3);
            this.qlhoadon.Size = new System.Drawing.Size(689, 393);
            this.qlhoadon.TabIndex = 2;
            this.qlhoadon.Text = "Quản lí hoá đơn";
            this.qlhoadon.UseVisualStyleBackColor = true;
            this.qlhoadon.Click += new System.EventHandler(this.qlhoadon_Click);
            // 
            // luuTT
            // 
            this.luuTT.Location = new System.Drawing.Point(450, 113);
            this.luuTT.Name = "luuTT";
            this.luuTT.Size = new System.Drawing.Size(208, 29);
            this.luuTT.TabIndex = 6;
            this.luuTT.Text = "Cập nhật trạng thái";
            this.luuTT.UseVisualStyleBackColor = true;
            this.luuTT.Click += new System.EventHandler(this.luuTT_Click);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Chờ xác nhận",
            "Xác nhận đơn hàng",
            "Đang vận chuyển",
            "Đã giao hàng thành công"});
            this.cbTrangThai.Location = new System.Drawing.Point(450, 58);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(208, 28);
            this.cbTrangThai.TabIndex = 5;
            // 
            // btXuatHD
            // 
            this.btXuatHD.Location = new System.Drawing.Point(216, 113);
            this.btXuatHD.Name = "btXuatHD";
            this.btXuatHD.Size = new System.Drawing.Size(169, 29);
            this.btXuatHD.TabIndex = 4;
            this.btXuatHD.Text = "Xuất hoá đơn";
            this.btXuatHD.UseVisualStyleBackColor = true;
            this.btXuatHD.Click += new System.EventHandler(this.btXuatHD_Click);
            // 
            // btXoaHD
            // 
            this.btXoaHD.Location = new System.Drawing.Point(62, 113);
            this.btXoaHD.Name = "btXoaHD";
            this.btXoaHD.Size = new System.Drawing.Size(106, 29);
            this.btXoaHD.TabIndex = 3;
            this.btXoaHD.Text = "Xoá đơn hàng";
            this.btXoaHD.UseVisualStyleBackColor = true;
            this.btXoaHD.Click += new System.EventHandler(this.btXoaHD_Click);
            // 
            // btDetail
            // 
            this.btDetail.Location = new System.Drawing.Point(216, 57);
            this.btDetail.Name = "btDetail";
            this.btDetail.Size = new System.Drawing.Size(169, 29);
            this.btDetail.TabIndex = 2;
            this.btDetail.Text = "Xem chi tiết sản phẩm";
            this.btDetail.UseVisualStyleBackColor = true;
            this.btDetail.Click += new System.EventHandler(this.btDetail_Click);
            // 
            // btShowOrder
            // 
            this.btShowOrder.Location = new System.Drawing.Point(62, 57);
            this.btShowOrder.Name = "btShowOrder";
            this.btShowOrder.Size = new System.Drawing.Size(106, 29);
            this.btShowOrder.TabIndex = 1;
            this.btShowOrder.Text = "Hiển thị";
            this.btShowOrder.UseVisualStyleBackColor = true;
            this.btShowOrder.Click += new System.EventHandler(this.btShowOrder_Click);
            // 
            // dbOrder
            // 
            this.dbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dbOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbOrder.Location = new System.Drawing.Point(43, 188);
            this.dbOrder.Name = "dbOrder";
            this.dbOrder.ReadOnly = true;
            this.dbOrder.RowHeadersWidth = 51;
            this.dbOrder.RowTemplate.Height = 29;
            this.dbOrder.Size = new System.Drawing.Size(615, 188);
            this.dbOrder.TabIndex = 0;
            this.dbOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getIDOrder);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qlall);
            this.Name = "Form1";
            this.Text = "Trang quản lý";
            this.qlall.ResumeLayout(false);
            this.tabKH.ResumeLayout(false);
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.bangKH)).EndInit();
=======
            this.tabKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            this.qlhoadon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbOrder)).EndInit();
>>>>>>> 348f0777b9b2f820a46b8d375eee8faef6f62feb
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl qlall;
        private System.Windows.Forms.TabPage tabKH;
        private System.Windows.Forms.TabPage tabPage2;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnHienThiKH;
        private System.Windows.Forms.DataGridView bangKH;
        private System.Windows.Forms.Button btnXoaKH;
=======
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView db;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage qlhoadon;
        private System.Windows.Forms.Button btDetail;
        private System.Windows.Forms.Button btShowOrder;
        private System.Windows.Forms.DataGridView dbOrder;
        private System.Windows.Forms.Button btXoaHD;
        private System.Windows.Forms.Button btXuatHD;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Button luuTT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
>>>>>>> 348f0777b9b2f820a46b8d375eee8faef6f62feb
    }
}

