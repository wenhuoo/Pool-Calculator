namespace Checkpoint1
{
    partial class PoolCalculator
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblAvgDepth = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSurfaceArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAvgTemp = new System.Windows.Forms.Label();
            this.lblDollars = new System.Windows.Forms.Label();
            this.txtTableAvgTemp = new System.Windows.Forms.TextBox();
            this.txtTableDollars = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSurfaceArea = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtAvgDepth = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblm1 = new System.Windows.Forms.Label();
            this.lblm2 = new System.Windows.Forms.Label();
            this.lblm3 = new System.Windows.Forms.Label();
            this.lblsqm = new System.Windows.Forms.Label();
            this.lbllitre = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(25, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pool Size and Cost";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(27, 91);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(41, 12);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "&Length";
            this.lblLength.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(27, 141);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 12);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "&Width";
            // 
            // lblAvgDepth
            // 
            this.lblAvgDepth.AutoSize = true;
            this.lblAvgDepth.Location = new System.Drawing.Point(27, 194);
            this.lblAvgDepth.Name = "lblAvgDepth";
            this.lblAvgDepth.Size = new System.Drawing.Size(83, 12);
            this.lblAvgDepth.TabIndex = 3;
            this.lblAvgDepth.Text = "Average &Depth";
            this.lblAvgDepth.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(135, 240);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSurfaceArea
            // 
            this.lblSurfaceArea.AutoSize = true;
            this.lblSurfaceArea.Location = new System.Drawing.Point(29, 288);
            this.lblSurfaceArea.Name = "lblSurfaceArea";
            this.lblSurfaceArea.Size = new System.Drawing.Size(77, 12);
            this.lblSurfaceArea.TabIndex = 5;
            this.lblSurfaceArea.Text = "Surface Area";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(29, 336);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(95, 12);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "Volume of Water";
            this.lblVolume.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(349, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(197, 36);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Cost to heat pool to 25 degrees \r\nCelcius based on varying \r\naverage daily temper" +
    "ature";
            // 
            // lblAvgTemp
            // 
            this.lblAvgTemp.AutoSize = true;
            this.lblAvgTemp.Location = new System.Drawing.Point(349, 66);
            this.lblAvgTemp.Name = "lblAvgTemp";
            this.lblAvgTemp.Size = new System.Drawing.Size(53, 12);
            this.lblAvgTemp.TabIndex = 8;
            this.lblAvgTemp.Text = "Avg Temp";
            // 
            // lblDollars
            // 
            this.lblDollars.AutoSize = true;
            this.lblDollars.Location = new System.Drawing.Point(503, 66);
            this.lblDollars.Name = "lblDollars";
            this.lblDollars.Size = new System.Drawing.Size(71, 12);
            this.lblDollars.TabIndex = 9;
            this.lblDollars.Text = "$ per month";
            // 
            // txtTableAvgTemp
            // 
            this.txtTableAvgTemp.Location = new System.Drawing.Point(351, 91);
            this.txtTableAvgTemp.Multiline = true;
            this.txtTableAvgTemp.Name = "txtTableAvgTemp";
            this.txtTableAvgTemp.ReadOnly = true;
            this.txtTableAvgTemp.Size = new System.Drawing.Size(117, 257);
            this.txtTableAvgTemp.TabIndex = 10;
            this.txtTableAvgTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTableDollars
            // 
            this.txtTableDollars.Location = new System.Drawing.Point(505, 91);
            this.txtTableDollars.Multiline = true;
            this.txtTableDollars.Name = "txtTableDollars";
            this.txtTableDollars.ReadOnly = true;
            this.txtTableDollars.Size = new System.Drawing.Size(117, 257);
            this.txtTableDollars.TabIndex = 11;
            this.txtTableDollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(505, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSurfaceArea
            // 
            this.txtSurfaceArea.Location = new System.Drawing.Point(135, 288);
            this.txtSurfaceArea.Name = "txtSurfaceArea";
            this.txtSurfaceArea.ReadOnly = true;
            this.txtSurfaceArea.Size = new System.Drawing.Size(107, 21);
            this.txtSurfaceArea.TabIndex = 13;
            this.txtSurfaceArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(135, 91);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(107, 21);
            this.txtLength.TabIndex = 14;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(135, 141);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(107, 21);
            this.txtWidth.TabIndex = 15;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAvgDepth
            // 
            this.txtAvgDepth.Location = new System.Drawing.Point(135, 194);
            this.txtAvgDepth.Name = "txtAvgDepth";
            this.txtAvgDepth.Size = new System.Drawing.Size(107, 21);
            this.txtAvgDepth.TabIndex = 16;
            this.txtAvgDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(135, 336);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(107, 21);
            this.txtVolume.TabIndex = 17;
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblm1
            // 
            this.lblm1.AutoSize = true;
            this.lblm1.Location = new System.Drawing.Point(248, 100);
            this.lblm1.Name = "lblm1";
            this.lblm1.Size = new System.Drawing.Size(11, 12);
            this.lblm1.TabIndex = 18;
            this.lblm1.Text = "m";
            // 
            // lblm2
            // 
            this.lblm2.AutoSize = true;
            this.lblm2.Location = new System.Drawing.Point(249, 149);
            this.lblm2.Name = "lblm2";
            this.lblm2.Size = new System.Drawing.Size(11, 12);
            this.lblm2.TabIndex = 19;
            this.lblm2.Text = "m";
            // 
            // lblm3
            // 
            this.lblm3.AutoSize = true;
            this.lblm3.Location = new System.Drawing.Point(249, 202);
            this.lblm3.Name = "lblm3";
            this.lblm3.Size = new System.Drawing.Size(11, 12);
            this.lblm3.TabIndex = 20;
            this.lblm3.Text = "m";
            // 
            // lblsqm
            // 
            this.lblsqm.AutoSize = true;
            this.lblsqm.Location = new System.Drawing.Point(249, 296);
            this.lblsqm.Name = "lblsqm";
            this.lblsqm.Size = new System.Drawing.Size(59, 12);
            this.lblsqm.TabIndex = 21;
            this.lblsqm.Text = "sq metres";
            // 
            // lbllitre
            // 
            this.lbllitre.AutoSize = true;
            this.lbllitre.Location = new System.Drawing.Point(249, 344);
            this.lbllitre.Name = "lbllitre";
            this.lbllitre.Size = new System.Drawing.Size(83, 12);
            this.lbllitre.TabIndex = 22;
            this.lbllitre.Text = "litres at 25C";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(201, 378);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCategory.Size = new System.Drawing.Size(0, 12);
            this.lblCategory.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 443);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lbllitre);
            this.Controls.Add(this.lblsqm);
            this.Controls.Add(this.lblm3);
            this.Controls.Add(this.lblm2);
            this.Controls.Add(this.lblm1);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtAvgDepth);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtSurfaceArea);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTableDollars);
            this.Controls.Add(this.txtTableAvgTemp);
            this.Controls.Add(this.lblDollars);
            this.Controls.Add(this.lblAvgTemp);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblSurfaceArea);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAvgDepth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Pool Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblAvgDepth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSurfaceArea;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblAvgTemp;
        private System.Windows.Forms.Label lblDollars;
        private System.Windows.Forms.TextBox txtTableAvgTemp;
        private System.Windows.Forms.TextBox txtTableDollars;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSurfaceArea;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtAvgDepth;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblm1;
        private System.Windows.Forms.Label lblm2;
        private System.Windows.Forms.Label lblm3;
        private System.Windows.Forms.Label lblsqm;
        private System.Windows.Forms.Label lbllitre;
        private System.Windows.Forms.Label lblCategory;
    }
}

