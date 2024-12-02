namespace _045_Ramos_Pinera_F1db
{
    partial class frmSearch
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
            this.grdResult = new System.Windows.Forms.DataGridView();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.SuspendLayout();
            // 
            // grdResult
            // 
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Location = new System.Drawing.Point(12, 59);
            this.grdResult.Name = "grdResult";
            this.grdResult.Size = new System.Drawing.Size(250, 222);
            this.grdResult.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(12, 33);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(122, 20);
            this.txtModel.TabIndex = 1;
            // 
            // cboBrand
            // 
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(138, 32);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(121, 21);
            this.cboBrand.TabIndex = 2;
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(267, 200);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(122, 20);
            this.txtPrice1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(268, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(268, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model";
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(267, 247);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(122, 20);
            this.txtPrice2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "1st Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "2nd price";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 324);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.grdResult);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdResult;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}