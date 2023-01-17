namespace eseguiquerysql
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApriFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvSql = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPar1 = new System.Windows.Forms.TextBox();
            this.txtPar2 = new System.Windows.Forms.TextBox();
            this.txtPar3 = new System.Windows.Forms.TextBox();
            this.txtPar4 = new System.Windows.Forms.TextBox();
            this.txtPar5 = new System.Windows.Forms.TextBox();
            this.txtPar6 = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSql)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApriFile
            // 
            this.btnApriFile.Location = new System.Drawing.Point(678, 12);
            this.btnApriFile.Name = "btnApriFile";
            this.btnApriFile.Size = new System.Drawing.Size(56, 37);
            this.btnApriFile.TabIndex = 0;
            this.btnApriFile.Text = "...";
            this.btnApriFile.UseVisualStyleBackColor = true;
            this.btnApriFile.Click += new System.EventHandler(this.btnApriFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(76, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(580, 20);
            this.txtFile.TabIndex = 1;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(76, 108);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(580, 106);
            this.txtQuery.TabIndex = 2;
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(262, 227);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(219, 31);
            this.btnEsegui.TabIndex = 3;
            this.btnEsegui.Text = "ESEGUI";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "SQL";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(2, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 26);
            this.button4.TabIndex = 5;
            this.button4.Text = "DB";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvSql
            // 
            this.dgvSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSql.Location = new System.Drawing.Point(76, 284);
            this.dgvSql.Name = "dgvSql";
            this.dgvSql.RowHeadersWidth = 45;
            this.dgvSql.Size = new System.Drawing.Size(556, 145);
            this.dgvSql.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "QUERY";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "PARAMETRI";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtPar1
            // 
            this.txtPar1.Location = new System.Drawing.Point(678, 108);
            this.txtPar1.Name = "txtPar1";
            this.txtPar1.Size = new System.Drawing.Size(103, 20);
            this.txtPar1.TabIndex = 10;
            // 
            // txtPar2
            // 
            this.txtPar2.Location = new System.Drawing.Point(678, 134);
            this.txtPar2.Name = "txtPar2";
            this.txtPar2.Size = new System.Drawing.Size(103, 20);
            this.txtPar2.TabIndex = 11;
            // 
            // txtPar3
            // 
            this.txtPar3.Location = new System.Drawing.Point(678, 160);
            this.txtPar3.Name = "txtPar3";
            this.txtPar3.Size = new System.Drawing.Size(103, 20);
            this.txtPar3.TabIndex = 12;
            // 
            // txtPar4
            // 
            this.txtPar4.Location = new System.Drawing.Point(678, 186);
            this.txtPar4.Name = "txtPar4";
            this.txtPar4.Size = new System.Drawing.Size(103, 20);
            this.txtPar4.TabIndex = 13;
            // 
            // txtPar5
            // 
            this.txtPar5.Location = new System.Drawing.Point(678, 212);
            this.txtPar5.Name = "txtPar5";
            this.txtPar5.Size = new System.Drawing.Size(103, 20);
            this.txtPar5.TabIndex = 14;
            // 
            // txtPar6
            // 
            this.txtPar6.Location = new System.Drawing.Point(678, 238);
            this.txtPar6.Name = "txtPar6";
            this.txtPar6.Size = new System.Drawing.Size(103, 20);
            this.txtPar6.TabIndex = 15;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(76, 59);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(580, 21);
            this.comboBox.TabIndex = 16;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.txtPar6);
            this.Controls.Add(this.txtPar5);
            this.Controls.Add(this.txtPar4);
            this.Controls.Add(this.txtPar3);
            this.Controls.Add(this.txtPar2);
            this.Controls.Add(this.txtPar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSql);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnApriFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApriFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvSql;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPar1;
        private System.Windows.Forms.TextBox txtPar2;
        private System.Windows.Forms.TextBox txtPar3;
        private System.Windows.Forms.TextBox txtPar4;
        private System.Windows.Forms.TextBox txtPar5;
        private System.Windows.Forms.TextBox txtPar6;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

