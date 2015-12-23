namespace Assignment
{
    partial class frmAddFraction
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
           this.txta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btncalculate = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.lblresultUp = new DevComponents.DotNetBar.LabelX();
            this.lblresultDown = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // txta
            // 
            // 
            // 
            // 
            this.txta.Border.Class = "TextBoxBorder";
            this.txta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txta.Location = new System.Drawing.Point(80, 143);
            this.txta.MaxLength = 8;
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(99, 29);
            this.txta.TabIndex = 0;
            this.txta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            // 
            // txtb
            // 
            // 
            // 
            // 
            this.txtb.Border.Class = "TextBoxBorder";
            this.txtb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtb.Location = new System.Drawing.Point(80, 194);
            this.txtb.MaxLength = 8;
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(99, 29);
            this.txtb.TabIndex = 1;
            this.txtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "=";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(257, 55);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(131, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Add Fraction";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Blue;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(80, 178);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(111, 10);
            this.labelX2.TabIndex = 3;
            // 
            // txtc
            // 
            // 
            // 
            // 
            this.txtc.Border.Class = "TextBoxBorder";
            this.txtc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtc.Location = new System.Drawing.Point(234, 143);
            this.txtc.MaxLength = 8;
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(99, 29);
            this.txtc.TabIndex = 2;
            this.txtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            // 
            // txtd
            // 
            // 
            // 
            // 
            this.txtd.Border.Class = "TextBoxBorder";
            this.txtd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtd.Location = new System.Drawing.Point(234, 194);
            this.txtd.MaxLength = 8;
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(99, 29);
            this.txtd.TabIndex = 3;
            this.txtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Blue;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(234, 178);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(111, 10);
            this.labelX3.TabIndex = 3;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Blue;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(384, 178);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(111, 10);
            this.labelX4.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(270, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 33);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "សំរួលប្រភាគ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncalculate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncalculate.Location = new System.Drawing.Point(284, 291);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(100, 33);
            this.btncalculate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncalculate.TabIndex = 5;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Location = new System.Drawing.Point(390, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 32);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblresultUp
            // 
            this.lblresultUp.AutoSize = true;
            // 
            // 
            // 
            this.lblresultUp.BackgroundStyle.Class = "";
            this.lblresultUp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblresultUp.Location = new System.Drawing.Point(383, 136);
            this.lblresultUp.Name = "lblresultUp";
            this.lblresultUp.Size = new System.Drawing.Size(18, 26);
            this.lblresultUp.TabIndex = 2;
            this.lblresultUp.Text = "...";
            // 
            // lblresultDown
            // 
            this.lblresultDown.AutoSize = true;
            // 
            // 
            // 
            this.lblresultDown.BackgroundStyle.Class = "";
            this.lblresultDown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblresultDown.Location = new System.Drawing.Point(383, 191);
            this.lblresultDown.Name = "lblresultDown";
            this.lblresultDown.Size = new System.Drawing.Size(18, 26);
            this.lblresultDown.TabIndex = 2;
            this.lblresultDown.Text = "...";
            // 
            // frmAddFraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(620, 419);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblresultDown);
            this.Controls.Add(this.lblresultUp);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAddFraction";
            this.Text = "Add Fraction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txta;
        private DevComponents.DotNetBar.Controls.TextBoxX txtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtd;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevComponents.DotNetBar.ButtonX btncalculate;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.LabelX lblresultUp;
        private DevComponents.DotNetBar.LabelX lblresultDown;
    }
}