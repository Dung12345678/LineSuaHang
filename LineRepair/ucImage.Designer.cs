
namespace BMS
{
    partial class ucImage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblName = new System.Windows.Forms.Label();
			this.pcbImage = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.pcbImage, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 270);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
			this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblName.Location = new System.Drawing.Point(1, 1);
			this.lblName.Margin = new System.Windows.Forms.Padding(0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(398, 40);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblName.Click += new System.EventHandler(this.lblName_Click);
			// 
			// pcbImage
			// 
			this.pcbImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pcbImage.Location = new System.Drawing.Point(1, 42);
			this.pcbImage.Margin = new System.Windows.Forms.Padding(0);
			this.pcbImage.Name = "pcbImage";
			this.pcbImage.Size = new System.Drawing.Size(398, 227);
			this.pcbImage.TabIndex = 1;
			this.pcbImage.TabStop = false;
			this.pcbImage.Click += new System.EventHandler(this.pcbImage_Click);
			// 
			// ucImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "ucImage";
			this.Size = new System.Drawing.Size(400, 270);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pcbImage;
    }
}
