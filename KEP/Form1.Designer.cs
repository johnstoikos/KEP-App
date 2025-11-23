using System;
using System.Windows.Forms;

namespace KEP
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.leftLayout = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCitizen = new System.Windows.Forms.GroupBox();
            this.tableCitizen = new System.Windows.Forms.TableLayoutPanel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxRequest = new System.Windows.Forms.GroupBox();
            this.tableRequest = new System.Windows.Forms.TableLayoutPanel();
            this.lblReqType = new System.Windows.Forms.Label();
            this.cmbRequestType = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblReqDate = new System.Windows.Forms.Label();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tableTopButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExportTxt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.groupBoxCitizen.SuspendLayout();
            this.tableCitizen.SuspendLayout();
            this.groupBoxRequest.SuspendLayout();
            this.tableRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.panelTopBar.SuspendLayout();
            this.tableTopButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
           
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            
            this.splitContainer1.Panel1.Controls.Add(this.leftLayout);
            
            this.splitContainer1.Panel2.Controls.Add(this.dgvRequests);
            this.splitContainer1.Panel2.Controls.Add(this.panelTopBar);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 698);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
           
            this.leftLayout.ColumnCount = 1;
            this.leftLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftLayout.Controls.Add(this.groupBoxCitizen, 0, 0);
            this.leftLayout.Controls.Add(this.btnSave, 0, 2);
            this.leftLayout.Controls.Add(this.groupBoxRequest, 0, 1);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLayout.Location = new System.Drawing.Point(0, 0);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.RowCount = 3;
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.leftLayout.Size = new System.Drawing.Size(400, 698);
            this.leftLayout.TabIndex = 0;
            
            this.groupBoxCitizen.Controls.Add(this.tableCitizen);
            this.groupBoxCitizen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCitizen.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCitizen.Name = "groupBoxCitizen";
            this.groupBoxCitizen.Size = new System.Drawing.Size(394, 343);
            this.groupBoxCitizen.TabIndex = 0;
            this.groupBoxCitizen.TabStop = false;
            this.groupBoxCitizen.Text = "Στοιχεία πολίτη";
            
            this.tableCitizen.ColumnCount = 2;
            this.tableCitizen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableCitizen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableCitizen.Controls.Add(this.lblFullName, 0, 0);
            this.tableCitizen.Controls.Add(this.txtFullName, 1, 0);
            this.tableCitizen.Controls.Add(this.lblEmail, 0, 1);
            this.tableCitizen.Controls.Add(this.txtEmail, 1, 1);
            this.tableCitizen.Controls.Add(this.lblPhone, 0, 2);
            this.tableCitizen.Controls.Add(this.txtPhone, 1, 2);
            this.tableCitizen.Controls.Add(this.lblBirth, 0, 3);
            this.tableCitizen.Controls.Add(this.dtpBirthDate, 1, 3);
            this.tableCitizen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCitizen.Location = new System.Drawing.Point(3, 18);
            this.tableCitizen.Name = "tableCitizen";
            this.tableCitizen.RowCount = 4;
            this.tableCitizen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCitizen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCitizen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCitizen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCitizen.Size = new System.Drawing.Size(388, 322);
            this.tableCitizen.TabIndex = 0;
            
            this.lblFullName.Location = new System.Drawing.Point(3, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(124, 20);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Ονοματεπώνυμο:";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            this.txtFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFullName.Location = new System.Drawing.Point(133, 3);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(252, 22);
            this.txtFullName.TabIndex = 1;
            
            this.lblEmail.Location = new System.Drawing.Point(3, 20);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(133, 23);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 22);
            this.txtEmail.TabIndex = 3;
            
            this.lblPhone.Location = new System.Drawing.Point(3, 40);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Τηλέφωνο:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhone.Location = new System.Drawing.Point(133, 43);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(252, 22);
            this.txtPhone.TabIndex = 5;
           
            this.lblBirth.Location = new System.Drawing.Point(3, 60);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(100, 20);
            this.lblBirth.TabIndex = 6;
            this.lblBirth.Text = "Ημ/νία γέννησης:";
            this.lblBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
             
            this.dtpBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBirthDate.Location = new System.Drawing.Point(133, 63);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(252, 22);
            this.dtpBirthDate.TabIndex = 7;
             
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(3, 655);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(394, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Καταχώρηση";
            
            this.groupBoxRequest.Controls.Add(this.tableRequest);
            this.groupBoxRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRequest.Location = new System.Drawing.Point(3, 352);
            this.groupBoxRequest.Name = "groupBoxRequest";
            this.groupBoxRequest.Size = new System.Drawing.Size(394, 273);
            this.groupBoxRequest.TabIndex = 1;
            this.groupBoxRequest.TabStop = false;
            this.groupBoxRequest.Text = "Αίτημα";
           
            this.tableRequest.ColumnCount = 2;
            this.tableRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRequest.Controls.Add(this.lblReqType, 0, 0);
            this.tableRequest.Controls.Add(this.cmbRequestType, 1, 0);
            this.tableRequest.Controls.Add(this.lblAddress, 0, 1);
            this.tableRequest.Controls.Add(this.lblReqDate, 0, 2);
            this.tableRequest.Controls.Add(this.dtpRequestDate, 1, 2);
            this.tableRequest.Controls.Add(this.txtAddress, 1, 1);
            this.tableRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableRequest.Location = new System.Drawing.Point(3, 18);
            this.tableRequest.Name = "tableRequest";
            this.tableRequest.RowCount = 3;
            this.tableRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableRequest.Size = new System.Drawing.Size(388, 252);
            this.tableRequest.TabIndex = 0;
             
            this.lblReqType.Location = new System.Drawing.Point(3, 0);
            this.lblReqType.Name = "lblReqType";
            this.lblReqType.Size = new System.Drawing.Size(100, 23);
            this.lblReqType.TabIndex = 0;
            this.lblReqType.Text = "Είδος αιτήματος:";
            this.lblReqType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            this.cmbRequestType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRequestType.Items.AddRange(new object[] {
                "Βεβαίωση",
                "Πιστοποιητικό",
                "Αίτηση",
                "Άλλο"
                }
            );
            this.cmbRequestType.Location = new System.Drawing.Point(133, 3);
            this.cmbRequestType.Name = "cmbRequestType";
            this.cmbRequestType.Size = new System.Drawing.Size(252, 24);
            this.cmbRequestType.TabIndex = 1;
           
            this.lblAddress.Location = new System.Drawing.Point(3, 30);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Διεύθυνση:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           
            this.lblReqDate.Location = new System.Drawing.Point(3, 60);
            this.lblReqDate.Name = "lblReqDate";
            this.lblReqDate.Size = new System.Drawing.Size(100, 23);
            this.lblReqDate.TabIndex = 3;
            this.lblReqDate.Text = "Ημ/νία αιτήματος:";
            this.lblReqDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            this.dtpRequestDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpRequestDate.Location = new System.Drawing.Point(133, 63);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(252, 22);
            this.dtpRequestDate.TabIndex = 4;
            
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(133, 34);
            this.txtAddress.MaximumSize = new System.Drawing.Size(0, 22);
            this.txtAddress.MinimumSize = new System.Drawing.Size(0, 22);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(252, 22);
            this.txtAddress.TabIndex = 5;
            
            this.dgvRequests.ColumnHeadersHeight = 29;
            this.dgvRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequests.Location = new System.Drawing.Point(0, 80);
            this.dgvRequests.Margin = new System.Windows.Forms.Padding(5);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.RowHeadersWidth = 51;
            this.dgvRequests.Size = new System.Drawing.Size(796, 618);
            this.dgvRequests.TabIndex = 0;
            this.dgvRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellContentClick);
            
            this.panelTopBar.Controls.Add(this.txtSearch);
            this.panelTopBar.Controls.Add(this.tableTopButtons);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Padding = new System.Windows.Forms.Padding(5);
            this.panelTopBar.Size = new System.Drawing.Size(796, 80);
            this.panelTopBar.TabIndex = 1;
            
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(5, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(426, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Αναζήτηση...";
            this.txtSearch.GotFocus += new System.EventHandler(this.txtSearch_GotFocus);
            this.txtSearch.LostFocus += new System.EventHandler(this.txtSearch_LostFocus);
            
            this.tableTopButtons.ColumnCount = 3;
            this.tableTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableTopButtons.Controls.Add(this.btnSearch, 0, 0);
            this.tableTopButtons.Controls.Add(this.btnLoad, 1, 0);
            this.tableTopButtons.Controls.Add(this.btnExportTxt, 2, 0);
            this.tableTopButtons.Controls.Add(this.btnDelete, 0, 1);
            this.tableTopButtons.Controls.Add(this.btnEdit, 1, 1);
            this.tableTopButtons.Controls.Add(this.btnExportPdf, 2, 1);
            this.tableTopButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableTopButtons.Location = new System.Drawing.Point(431, 5);
            this.tableTopButtons.Name = "tableTopButtons";
            this.tableTopButtons.RowCount = 2;
            this.tableTopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTopButtons.Size = new System.Drawing.Size(360, 70);
            this.tableTopButtons.TabIndex = 1;
            
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.MinimumSize = new System.Drawing.Size(90, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 30);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Αναζήτηση";
            
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(123, 3);
            this.btnLoad.MinimumSize = new System.Drawing.Size(90, 30);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(114, 30);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Φόρτωση";
            
            this.btnExportTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportTxt.Location = new System.Drawing.Point(243, 3);
            this.btnExportTxt.MinimumSize = new System.Drawing.Size(90, 30);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.Size = new System.Drawing.Size(114, 30);
            this.btnExportTxt.TabIndex = 2;
            this.btnExportTxt.Text = "Εξαγωγή TXT";
             
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(3, 38);
            this.btnDelete.MinimumSize = new System.Drawing.Size(90, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Διαγραφή";
            
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(123, 38);
            this.btnEdit.MinimumSize = new System.Drawing.Size(90, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Επεξεργασία";
           
            this.btnExportPdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPdf.Location = new System.Drawing.Point(243, 38);
            this.btnExportPdf.MinimumSize = new System.Drawing.Size(90, 30);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(114, 30);
            this.btnExportPdf.TabIndex = 5;
            this.btnExportPdf.Text = "Εξαγωγή PDF";
             
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 698);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip1.TabIndex = 1;
            
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 16);
            
            this.errorProvider1.ContainerControl = this;
             
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "ΚΕΠ - Καταγραφή αιτημάτων";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.leftLayout.ResumeLayout(false);
            this.groupBoxCitizen.ResumeLayout(false);
            this.tableCitizen.ResumeLayout(false);
            this.tableCitizen.PerformLayout();
            this.groupBoxRequest.ResumeLayout(false);
            this.tableRequest.ResumeLayout(false);
            this.tableRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.tableTopButtons.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel leftLayout;
        private System.Windows.Forms.GroupBox groupBoxCitizen;
        private System.Windows.Forms.TableLayoutPanel tableCitizen;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;

        private System.Windows.Forms.GroupBox groupBoxRequest;
        private System.Windows.Forms.TableLayoutPanel tableRequest;
        private System.Windows.Forms.Label lblReqType;
        private System.Windows.Forms.ComboBox cmbRequestType;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblReqDate;
        private System.Windows.Forms.DateTimePicker dtpRequestDate;

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.TableLayoutPanel tableTopButtons;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Button btnExportPdf;

        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
