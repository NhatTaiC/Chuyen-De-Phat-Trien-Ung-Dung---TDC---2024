namespace CDUD1
{
    partial class frmLog
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
            this.tableLabel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableFields = new System.Windows.Forms.TableLayoutPanel();
            this.txtDataNew = new System.Windows.Forms.TextBox();
            this.txtDataOld = new System.Windows.Forms.TextBox();
            this.txtModelId = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableData = new System.Windows.Forms.TableLayoutPanel();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.tableLabel.SuspendLayout();
            this.tableFields.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.tableData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLabel
            // 
            this.tableLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLabel.ColumnCount = 1;
            this.tableLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLabel.Controls.Add(this.label1, 0, 0);
            this.tableLabel.Location = new System.Drawing.Point(116, 26);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.RowCount = 1;
            this.tableLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLabel.Size = new System.Drawing.Size(505, 59);
            this.tableLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Log";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableFields
            // 
            this.tableFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableFields.ColumnCount = 2;
            this.tableFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.15842F));
            this.tableFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.84158F));
            this.tableFields.Controls.Add(this.txtDataNew, 1, 4);
            this.tableFields.Controls.Add(this.txtDataOld, 1, 3);
            this.tableFields.Controls.Add(this.txtModelId, 1, 2);
            this.tableFields.Controls.Add(this.txtModel, 1, 1);
            this.tableFields.Controls.Add(this.label2, 0, 0);
            this.tableFields.Controls.Add(this.label3, 0, 1);
            this.tableFields.Controls.Add(this.label4, 0, 2);
            this.tableFields.Controls.Add(this.label5, 0, 3);
            this.tableFields.Controls.Add(this.label6, 0, 4);
            this.tableFields.Controls.Add(this.txtLogName, 1, 0);
            this.tableFields.Location = new System.Drawing.Point(116, 144);
            this.tableFields.Name = "tableFields";
            this.tableFields.RowCount = 5;
            this.tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableFields.Size = new System.Drawing.Size(505, 160);
            this.tableFields.TabIndex = 2;
            // 
            // txtDataNew
            // 
            this.txtDataNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDataNew.Location = new System.Drawing.Point(125, 131);
            this.txtDataNew.Name = "txtDataNew";
            this.txtDataNew.Size = new System.Drawing.Size(377, 29);
            this.txtDataNew.TabIndex = 4;
            // 
            // txtDataOld
            // 
            this.txtDataOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDataOld.Location = new System.Drawing.Point(125, 99);
            this.txtDataOld.Name = "txtDataOld";
            this.txtDataOld.Size = new System.Drawing.Size(377, 29);
            this.txtDataOld.TabIndex = 3;
            // 
            // txtModelId
            // 
            this.txtModelId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModelId.Location = new System.Drawing.Point(125, 67);
            this.txtModelId.Name = "txtModelId";
            this.txtModelId.Size = new System.Drawing.Size(377, 29);
            this.txtModelId.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModel.Location = new System.Drawing.Point(125, 35);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(377, 29);
            this.txtModel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Log Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Model:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Model Id:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data Old:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data New:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLogName
            // 
            this.txtLogName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogName.Location = new System.Drawing.Point(125, 3);
            this.txtLogName.Name = "txtLogName";
            this.txtLogName.Size = new System.Drawing.Size(377, 29);
            this.txtLogName.TabIndex = 0;
            // 
            // tableButtons
            // 
            this.tableButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableButtons.ColumnCount = 5;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButtons.Controls.Add(this.btnExit, 4, 0);
            this.tableButtons.Controls.Add(this.btnReset, 3, 0);
            this.tableButtons.Controls.Add(this.btnDel, 2, 0);
            this.tableButtons.Controls.Add(this.btnEdit, 1, 0);
            this.tableButtons.Controls.Add(this.btnAdd, 0, 0);
            this.tableButtons.Location = new System.Drawing.Point(116, 344);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableButtons.Size = new System.Drawing.Size(505, 79);
            this.tableButtons.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(407, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 73);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát Form";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(306, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 73);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Location = new System.Drawing.Point(205, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(95, 73);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa Dữ Liệu";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(104, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 73);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa Dữ Liệu";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 73);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm Dữ Liệu";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tableData
            // 
            this.tableData.ColumnCount = 1;
            this.tableData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.Controls.Add(this.dgvLog, 0, 0);
            this.tableData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableData.Location = new System.Drawing.Point(0, 450);
            this.tableData.Name = "tableData";
            this.tableData.RowCount = 1;
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.Size = new System.Drawing.Size(744, 348);
            this.tableData.TabIndex = 4;
            // 
            // dgvLog
            // 
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLog.Location = new System.Drawing.Point(3, 3);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowHeadersWidth = 51;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Size = new System.Drawing.Size(738, 342);
            this.dgvLog.TabIndex = 0;
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 798);
            this.Controls.Add(this.tableData);
            this.Controls.Add(this.tableButtons);
            this.Controls.Add(this.tableFields);
            this.Controls.Add(this.tableLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmLog";
            this.Text = "frmLog";
            this.tableLabel.ResumeLayout(false);
            this.tableLabel.PerformLayout();
            this.tableFields.ResumeLayout(false);
            this.tableFields.PerformLayout();
            this.tableButtons.ResumeLayout(false);
            this.tableData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableFields;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtDataNew;
        private System.Windows.Forms.TextBox txtDataOld;
        private System.Windows.Forms.TextBox txtModelId;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogName;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableData;
        private System.Windows.Forms.DataGridView dgvLog;
    }
}