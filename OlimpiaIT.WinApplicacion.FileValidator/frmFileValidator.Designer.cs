
namespace OlimpiaIT.WinApplicacion.FileValidator
{
    partial class frmFileValidator
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCorrectLines = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalLines = new System.Windows.Forms.Label();
            this.lblLineErrors = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFileOut = new System.Windows.Forms.Label();
            this.lnkFileOutput = new System.Windows.Forms.LinkLabel();
            this.gb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnProcesar);
            this.gb1.Controls.Add(this.lblFilePath);
            this.gb1.Controls.Add(this.btnSelectFile);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(499, 155);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Archivo de entrada";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.Enabled = false;
            this.btnProcesar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(18, 119);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(235, 23);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar archivo";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.Location = new System.Drawing.Point(15, 51);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(478, 50);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "No ha seleccionado un archivo";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFile.Location = new System.Drawing.Point(18, 20);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(235, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Buscar archivo";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkFileOutput);
            this.groupBox1.Controls.Add(this.lblFileOut);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblLineErrors);
            this.groupBox1.Controls.Add(this.lblTotalLines);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblCorrectLines);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(78, 27);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(17, 16);
            this.lblFileName.TabIndex = 11;
            this.lblFileName.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tamaño:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(409, 27);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(17, 16);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lineas procesadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Errores:";
            // 
            // lblCorrectLines
            // 
            this.lblCorrectLines.AutoSize = true;
            this.lblCorrectLines.Location = new System.Drawing.Point(297, 56);
            this.lblCorrectLines.Name = "lblCorrectLines";
            this.lblCorrectLines.Size = new System.Drawing.Size(17, 16);
            this.lblCorrectLines.TabIndex = 14;
            this.lblCorrectLines.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lineas correctas:";
            // 
            // lblTotalLines
            // 
            this.lblTotalLines.AutoSize = true;
            this.lblTotalLines.Location = new System.Drawing.Point(135, 56);
            this.lblTotalLines.Name = "lblTotalLines";
            this.lblTotalLines.Size = new System.Drawing.Size(17, 16);
            this.lblTotalLines.TabIndex = 16;
            this.lblTotalLines.Text = "...";
            // 
            // lblLineErrors
            // 
            this.lblLineErrors.AutoSize = true;
            this.lblLineErrors.Location = new System.Drawing.Point(397, 56);
            this.lblLineErrors.Name = "lblLineErrors";
            this.lblLineErrors.Size = new System.Drawing.Size(17, 16);
            this.lblLineErrors.TabIndex = 17;
            this.lblLineErrors.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Estado:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(72, 82);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(21, 20);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "...";
            // 
            // lblFileOut
            // 
            this.lblFileOut.AutoSize = true;
            this.lblFileOut.Location = new System.Drawing.Point(18, 114);
            this.lblFileOut.Name = "lblFileOut";
            this.lblFileOut.Size = new System.Drawing.Size(105, 16);
            this.lblFileOut.TabIndex = 20;
            this.lblFileOut.Text = "Archivo resultado:";
            this.lblFileOut.Visible = false;
            // 
            // lnkFileOutput
            // 
            this.lnkFileOutput.Location = new System.Drawing.Point(19, 134);
            this.lnkFileOutput.Name = "lnkFileOutput";
            this.lnkFileOutput.Size = new System.Drawing.Size(474, 58);
            this.lnkFileOutput.TabIndex = 21;
            this.lnkFileOutput.TabStop = true;
            this.lnkFileOutput.Text = "...";
            this.lnkFileOutput.Visible = false;
            this.lnkFileOutput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFileOutput_LinkClicked);
            // 
            // frmFileValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 390);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFileValidator";
            this.Text = "OlimpiaIT - File Validator | Oscar Melgarejo";
            this.Load += new System.EventHandler(this.frmFileValidator_Load);
            this.gb1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLineErrors;
        private System.Windows.Forms.Label lblTotalLines;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCorrectLines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkFileOutput;
        private System.Windows.Forms.Label lblFileOut;
    }
}

