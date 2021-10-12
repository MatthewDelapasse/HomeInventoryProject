﻿
namespace HomeInventoryProject
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.txtPurchaseCost = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.chkEngraved = new System.Windows.Forms.CheckBox();
            this.lblPhoteFile = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            this.dtpDatePurchased = new System.Windows.Forms.DateTimePicker();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dlgPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Store:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Purchased:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Purchase Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Serial Number:";
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.White;
            this.txtItem.Location = new System.Drawing.Point(141, 29);
            this.txtItem.MaxLength = 50;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(437, 23);
            this.txtItem.TabIndex = 6;
            this.txtItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_KeyPress);
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(141, 57);
            this.txtLocation.MaxLength = 50;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(437, 23);
            this.txtLocation.TabIndex = 7;
            this.txtLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocation_KeyPress);
            // 
            // txtStore
            // 
            this.txtStore.BackColor = System.Drawing.Color.White;
            this.txtStore.Location = new System.Drawing.Point(141, 86);
            this.txtStore.MaxLength = 50;
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(437, 23);
            this.txtStore.TabIndex = 8;
            this.txtStore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStore_KeyPress);
            // 
            // txtPurchaseCost
            // 
            this.txtPurchaseCost.BackColor = System.Drawing.Color.White;
            this.txtPurchaseCost.Location = new System.Drawing.Point(477, 114);
            this.txtPurchaseCost.Name = "txtPurchaseCost";
            this.txtPurchaseCost.Size = new System.Drawing.Size(101, 23);
            this.txtPurchaseCost.TabIndex = 9;
            this.txtPurchaseCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchaseCost_KeyPress);
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.Color.White;
            this.txtSerialNumber.Location = new System.Drawing.Point(141, 143);
            this.txtSerialNumber.MaxLength = 50;
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(437, 23);
            this.txtSerialNumber.TabIndex = 10;
            this.txtSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerialNumber_KeyPress);
            // 
            // chkEngraved
            // 
            this.chkEngraved.AutoSize = true;
            this.chkEngraved.Location = new System.Drawing.Point(23, 174);
            this.chkEngraved.Name = "chkEngraved";
            this.chkEngraved.Size = new System.Drawing.Size(75, 19);
            this.chkEngraved.TabIndex = 11;
            this.chkEngraved.Text = "Engraved";
            this.chkEngraved.UseVisualStyleBackColor = true;
            // 
            // lblPhoteFile
            // 
            this.lblPhoteFile.BackColor = System.Drawing.Color.LightYellow;
            this.lblPhoteFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhoteFile.Location = new System.Drawing.Point(336, 353);
            this.lblPhoteFile.Name = "lblPhoteFile";
            this.lblPhoteFile.Size = new System.Drawing.Size(242, 35);
            this.lblPhoteFile.TabIndex = 12;
            // 
            // picItem
            // 
            this.picItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem.Location = new System.Drawing.Point(336, 174);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(242, 176);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem.TabIndex = 13;
            this.picItem.TabStop = false;
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.Location = new System.Drawing.Point(414, 391);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(92, 23);
            this.btnLoadPhoto.TabIndex = 14;
            this.btnLoadPhoto.Text = "Load Photo";
            this.btnLoadPhoto.UseVisualStyleBackColor = true;
            this.btnLoadPhoto.Click += new System.EventHandler(this.btnLoadPhoto_Click);
            // 
            // dtpDatePurchased
            // 
            this.dtpDatePurchased.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePurchased.Location = new System.Drawing.Point(141, 114);
            this.dtpDatePurchased.Name = "dtpDatePurchased";
            this.dtpDatePurchased.Size = new System.Drawing.Size(189, 23);
            this.dtpDatePurchased.TabIndex = 15;
            this.dtpDatePurchased.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDatePurchased_KeyPress);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFirst.Location = new System.Drawing.Point(23, 211);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(51, 23);
            this.btnFirst.TabIndex = 16;
            this.btnFirst.TabStop = false;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(80, 211);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(49, 23);
            this.btnPrevious.TabIndex = 17;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLast.Location = new System.Drawing.Point(185, 213);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(51, 23);
            this.btnLast.TabIndex = 18;
            this.btnLast.TabStop = false;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(135, 212);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(44, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.TabStop = false;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(4, 240);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(95, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(185, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "jpg";
            this.dlgOpen.Filter = "Photos (*.jpg) | *.jpg";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(40, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(135, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(40, 298);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dlgPreview
            // 
            this.dlgPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dlgPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dlgPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.dlgPreview.Enabled = true;
            this.dlgPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPreview.Icon")));
            this.dlgPreview.Name = "dlgPreview";
            this.dlgPreview.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(135, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 433);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.dtpDatePurchased);
            this.Controls.Add(this.btnLoadPhoto);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.lblPhoteFile);
            this.Controls.Add(this.chkEngraved);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.txtPurchaseCost);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInventory_FormClosing);
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.TextBox txtPurchaseCost;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.CheckBox chkEngraved;
        private System.Windows.Forms.Label lblPhoteFile;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Button btnLoadPhoto;
        private System.Windows.Forms.DateTimePicker dtpDatePurchased;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog dlgPreview;
        private System.Windows.Forms.Button btnExit;
    }
}

