
namespace btl
{
    partial class Form4
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
            this.db_member_ship = new System.Windows.Forms.DataGridView();
            this.btHTSHIP = new System.Windows.Forms.Button();
            this.btnXoaShip = new System.Windows.Forms.Button();
            this.tbtest = new System.Windows.Forms.TextBox();
            this.tb1_test = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.db_member_ship)).BeginInit();
            this.SuspendLayout();
            // 
            // db_member_ship
            // 
            this.db_member_ship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_member_ship.Location = new System.Drawing.Point(12, 161);
            this.db_member_ship.Name = "db_member_ship";
            this.db_member_ship.RowHeadersWidth = 51;
            this.db_member_ship.RowTemplate.Height = 29;
            this.db_member_ship.Size = new System.Drawing.Size(776, 188);
            this.db_member_ship.TabIndex = 0;
            this.db_member_ship.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.get_id_member_ship);
            this.db_member_ship.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getid);
            // 
            // btHTSHIP
            // 
            this.btHTSHIP.Location = new System.Drawing.Point(92, 70);
            this.btHTSHIP.Name = "btHTSHIP";
            this.btHTSHIP.Size = new System.Drawing.Size(94, 29);
            this.btHTSHIP.TabIndex = 1;
            this.btHTSHIP.Text = "Hiển thị";
            this.btHTSHIP.UseVisualStyleBackColor = true;
            this.btHTSHIP.Click += new System.EventHandler(this.btHTSHIP_Click);
            // 
            // btnXoaShip
            // 
            this.btnXoaShip.Location = new System.Drawing.Point(275, 70);
            this.btnXoaShip.Name = "btnXoaShip";
            this.btnXoaShip.Size = new System.Drawing.Size(94, 29);
            this.btnXoaShip.TabIndex = 2;
            this.btnXoaShip.Text = "Xoá";
            this.btnXoaShip.UseVisualStyleBackColor = true;
            this.btnXoaShip.Click += new System.EventHandler(this.btnXoaShip_Click);
            // 
            // tbtest
            // 
            this.tbtest.Location = new System.Drawing.Point(426, 34);
            this.tbtest.Name = "tbtest";
            this.tbtest.Size = new System.Drawing.Size(323, 27);
            this.tbtest.TabIndex = 3;
            // 
            // tb1_test
            // 
            this.tb1_test.Location = new System.Drawing.Point(426, 87);
            this.tb1_test.Name = "tb1_test";
            this.tb1_test.Size = new System.Drawing.Size(323, 27);
            this.tb1_test.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb1_test);
            this.Controls.Add(this.tbtest);
            this.Controls.Add(this.btnXoaShip);
            this.Controls.Add(this.btHTSHIP);
            this.Controls.Add(this.db_member_ship);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.db_member_ship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView db_member_ship;
        private System.Windows.Forms.Button btHTSHIP;
        private System.Windows.Forms.Button btnXoaShip;
        private System.Windows.Forms.TextBox tbtest;
        private System.Windows.Forms.TextBox tb1_test;
    }
}