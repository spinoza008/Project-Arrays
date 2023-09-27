namespace Project_Arrays
{
    partial class frmArray
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
            this.btnArrays = new System.Windows.Forms.Button();
            this.btnArrayInitialized = new System.Windows.Forms.Button();
            this.btnAccessingUpdating = new System.Windows.Forms.Button();
            this.btnSearchArray = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnArrayMath = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnInconveniant = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.cboZodiac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArrays
            // 
            this.btnArrays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrays.Location = new System.Drawing.Point(2, 12);
            this.btnArrays.Name = "btnArrays";
            this.btnArrays.Size = new System.Drawing.Size(103, 34);
            this.btnArrays.TabIndex = 0;
            this.btnArrays.Text = "Arrays ";
            this.btnArrays.UseVisualStyleBackColor = true;
            this.btnArrays.Click += new System.EventHandler(this.btnArrays_Click);
            // 
            // btnArrayInitialized
            // 
            this.btnArrayInitialized.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrayInitialized.Location = new System.Drawing.Point(111, 12);
            this.btnArrayInitialized.Name = "btnArrayInitialized";
            this.btnArrayInitialized.Size = new System.Drawing.Size(194, 45);
            this.btnArrayInitialized.TabIndex = 1;
            this.btnArrayInitialized.Text = "Array initialized in declaration";
            this.btnArrayInitialized.UseVisualStyleBackColor = true;
            this.btnArrayInitialized.Click += new System.EventHandler(this.btnArrayInitialized_Click);
            // 
            // btnAccessingUpdating
            // 
            this.btnAccessingUpdating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessingUpdating.Location = new System.Drawing.Point(2, 106);
            this.btnAccessingUpdating.Name = "btnAccessingUpdating";
            this.btnAccessingUpdating.Size = new System.Drawing.Size(202, 33);
            this.btnAccessingUpdating.TabIndex = 2;
            this.btnAccessingUpdating.Text = "Accessing and Updating ";
            this.btnAccessingUpdating.UseVisualStyleBackColor = true;
            this.btnAccessingUpdating.Click += new System.EventHandler(this.btnAccessingUpdating_Click);
            // 
            // btnSearchArray
            // 
            this.btnSearchArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchArray.Location = new System.Drawing.Point(232, 106);
            this.btnSearchArray.Name = "btnSearchArray";
            this.btnSearchArray.Size = new System.Drawing.Size(145, 33);
            this.btnSearchArray.TabIndex = 3;
            this.btnSearchArray.Text = "Search an Array ";
            this.btnSearchArray.UseVisualStyleBackColor = true;
            this.btnSearchArray.Click += new System.EventHandler(this.btnSearchArray_Click);
            // 
            // btnResize
            // 
            this.btnResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResize.Location = new System.Drawing.Point(2, 156);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(131, 32);
            this.btnResize.TabIndex = 4;
            this.btnResize.Text = "Resizing Array ";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnArrayMath
            // 
            this.btnArrayMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrayMath.Location = new System.Drawing.Point(232, 156);
            this.btnArrayMath.Name = "btnArrayMath";
            this.btnArrayMath.Size = new System.Drawing.Size(145, 32);
            this.btnArrayMath.TabIndex = 5;
            this.btnArrayMath.Text = "Array Math ";
            this.btnArrayMath.UseVisualStyleBackColor = true;
            this.btnArrayMath.Click += new System.EventHandler(this.btnArrayMath_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(395, 106);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(171, 33);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sorting Array";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnInconveniant
            // 
            this.btnInconveniant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInconveniant.Location = new System.Drawing.Point(395, 156);
            this.btnInconveniant.Name = "btnInconveniant";
            this.btnInconveniant.Size = new System.Drawing.Size(171, 47);
            this.btnInconveniant.TabIndex = 6;
            this.btnInconveniant.Text = "Array could be inconvenient";
            this.btnInconveniant.UseVisualStyleBackColor = true;
            this.btnInconveniant.Click += new System.EventHandler(this.btnInconveniant_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(2, 209);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(564, 96);
            this.rtbDisplay.TabIndex = 8;
            this.rtbDisplay.Text = "";
            // 
            // cboZodiac
            // 
            this.cboZodiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboZodiac.FormattingEnabled = true;
            this.cboZodiac.Location = new System.Drawing.Point(362, 36);
            this.cboZodiac.Name = "cboZodiac";
            this.cboZodiac.Size = new System.Drawing.Size(204, 26);
            this.cboZodiac.TabIndex = 9;
            this.cboZodiac.SelectedIndexChanged += new System.EventHandler(this.cboZodiac_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Zodiac signs:";
            // 
            // frmArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboZodiac);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnInconveniant);
            this.Controls.Add(this.btnArrayMath);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnSearchArray);
            this.Controls.Add(this.btnAccessingUpdating);
            this.Controls.Add(this.btnArrayInitialized);
            this.Controls.Add(this.btnArrays);
            this.Name = "frmArray";
            this.Text = "Project Array";
            this.Load += new System.EventHandler(this.frmArray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArrays;
        private System.Windows.Forms.Button btnArrayInitialized;
        private System.Windows.Forms.Button btnAccessingUpdating;
        private System.Windows.Forms.Button btnSearchArray;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnArrayMath;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnInconveniant;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.ComboBox cboZodiac;
        private System.Windows.Forms.Label label1;
    }
}

