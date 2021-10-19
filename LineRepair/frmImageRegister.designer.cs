
namespace BMS
{
    partial class frmImageRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageRegister));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPart = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.pcb = new System.Windows.Forms.PictureBox();
            this.Camera = new AxDNVideoXLib.AxDNVideoX();
            this.btnSnap = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camera)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblPart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblContent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pcb, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Camera, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSnap, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 409F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1294, 589);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblPart, 2);
            this.lblPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPart.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPart.Location = new System.Drawing.Point(2, 2);
            this.lblPart.Margin = new System.Windows.Forms.Padding(1);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(643, 49);
            this.lblPart.TabIndex = 0;
            this.lblPart.Text = "Tên bộ phận";
            this.lblPart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(648, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(320, 48);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(971, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(321, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel1.SetColumnSpan(this.lblContent, 2);
            this.lblContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblContent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContent.Location = new System.Drawing.Point(2, 54);
            this.lblContent.Margin = new System.Windows.Forms.Padding(1);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(643, 47);
            this.lblContent.TabIndex = 4;
            this.lblContent.Text = "Ảnh Mẫu";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcb
            // 
            this.pcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.tableLayoutPanel1.SetColumnSpan(this.pcb, 2);
            this.pcb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcb.Location = new System.Drawing.Point(2, 104);
            this.pcb.Margin = new System.Windows.Forms.Padding(1);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(643, 483);
            this.pcb.TabIndex = 6;
            this.pcb.TabStop = false;
            // 
            // Camera
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Camera, 2);
            this.Camera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Camera.Enabled = true;
            this.Camera.Location = new System.Drawing.Point(649, 105);
            this.Camera.Margin = new System.Windows.Forms.Padding(2);
            this.Camera.Name = "Camera";
            this.Camera.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Camera.OcxState")));
            this.Camera.Size = new System.Drawing.Size(642, 481);
            this.Camera.TabIndex = 7;
            this.Camera.MicroTouchPressed += new System.EventHandler(this.Camera_MicroTouchPressed);
            // 
            // btnSnap
            // 
            this.btnSnap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.tableLayoutPanel1.SetColumnSpan(this.btnSnap, 2);
            this.btnSnap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSnap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnap.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSnap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSnap.Location = new System.Drawing.Point(648, 54);
            this.btnSnap.Margin = new System.Windows.Forms.Padding(1);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(644, 47);
            this.btnSnap.TabIndex = 8;
            this.btnSnap.Text = "Chụp Ảnh";
            this.btnSnap.UseVisualStyleBackColor = false;
            this.btnSnap.Click += new System.EventHandler(this.btnSnap_Click);
            // 
            // frmImageRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1294, 589);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImageRegister";
            this.Text = "Image Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.PictureBox pcb;
        private AxDNVideoXLib.AxDNVideoX Camera;
        private System.Windows.Forms.Button btnSnap;
    }
}

