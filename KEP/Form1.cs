using iTextSharp.text;
using iTextSharp.text.pdf;
using KEP.Models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KEP
{
    public partial class Form1 : Form
    {
        private int? editingId = null; 

        public Form1()
        {
            InitializeComponent();

           
            this.btnSave.Click += BtnSave_Click;
            this.btnLoad.Click += BtnLoad_Click;
            this.btnSearch.Click += BtnSearch_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnExportTxt.Click += BtnExportTxt_Click;
            this.btnExportPdf.Click += BtnExportPdf_Click;

            this.Load += Form1_Load;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            RequestRepository.InitDatabase();
            LoadGrid();
            NormalizeFormsLayout();
            NormalizeTopBar();
            StyleGrid();
            FixSplit();

            foreach (var b in new[] { btnSearch, btnLoad, btnEdit, btnDelete, btnExportTxt, btnExportPdf })
            {
                if (b != null)
                {
                    b.FlatStyle = FlatStyle.Flat;
                    b.BackColor = Color.WhiteSmoke;
                    b.ForeColor = Color.Black;
                    b.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Regular);
                }
            }
        }


        private void LoadGrid()
        {
            try
            {
                var dt = RequestRepository.GetAll();
                dgvRequests.AutoGenerateColumns = true;
                dgvRequests.DataSource = dt;

                if (dgvRequests.Columns.Contains("Id"))
                    dgvRequests.Columns["Id"].HeaderText = "Κωδ.";
                if (dgvRequests.Columns.Contains("FullName"))
                    dgvRequests.Columns["FullName"].HeaderText = "Ονοματεπώνυμο";
                if (dgvRequests.Columns.Contains("Email"))
                    dgvRequests.Columns["Email"].HeaderText = "E-mail";
                if (dgvRequests.Columns.Contains("Phone"))
                    dgvRequests.Columns["Phone"].HeaderText = "Τηλέφωνο";
                if (dgvRequests.Columns.Contains("BirthDate"))
                    dgvRequests.Columns["BirthDate"].HeaderText = "Ημ/νία Γέννησης";
                if (dgvRequests.Columns.Contains("RequestType"))
                    dgvRequests.Columns["RequestType"].HeaderText = "Είδος Αιτήματος";
                if (dgvRequests.Columns.Contains("Address"))
                    dgvRequests.Columns["Address"].HeaderText = "Διεύθυνση";
                if (dgvRequests.Columns.Contains("RequestDate"))
                    dgvRequests.Columns["RequestDate"].HeaderText = "Ημ/νία Αιτήματος";

                toolStripStatusLabel.Text = $"Σύνολο αιτήσεων: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Σφάλμα κατά τη φόρτωση: " + ex.Message);
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new CitizenRequest
                {
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    BirthDate = dtpBirthDate.Value,
                    RequestType = cmbRequestType.Text,
                    Address = txtAddress.Text.Trim(),
                    RequestDate = dtpRequestDate.Value
                };

                if (editingId == null)
                {
                    int newId = RequestRepository.Insert(model);
                    MessageBox.Show($"Η αίτηση καταχωρήθηκε (Id: {newId}).");
                }
                else
                {
                    model.Id = editingId.Value;
                    RequestRepository.Update(model);
                    MessageBox.Show($"Η αίτηση ενημερώθηκε (Id: {model.Id}).");
                    editingId = null;
                }

                ClearForm();
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Σφάλμα καταχώρησης: " + ex.Message);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadGrid();
                return;
            }

            var dt = RequestRepository.Search(keyword);
            dgvRequests.DataSource = dt;

            if (dt.Rows.Count == 0)
                MessageBox.Show("Δεν βρέθηκαν αιτήσεις.");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvRequests.CurrentRow.Cells["Id"].Value);
            var confirm = MessageBox.Show("Διαγραφή αίτησης;", "Επιβεβαίωση",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                RequestRepository.Delete(id);
                LoadGrid();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow == null) return;

            editingId = Convert.ToInt32(dgvRequests.CurrentRow.Cells["Id"].Value);
            txtFullName.Text = dgvRequests.CurrentRow.Cells["FullName"].Value.ToString();
            txtEmail.Text = dgvRequests.CurrentRow.Cells["Email"].Value.ToString();
            txtPhone.Text = dgvRequests.CurrentRow.Cells["Phone"].Value.ToString();
            dtpBirthDate.Value = Convert.ToDateTime(dgvRequests.CurrentRow.Cells["BirthDate"].Value);
            cmbRequestType.Text = dgvRequests.CurrentRow.Cells["RequestType"].Value.ToString();
            txtAddress.Text = dgvRequests.CurrentRow.Cells["Address"].Value.ToString();
            dtpRequestDate.Value = Convert.ToDateTime(dgvRequests.CurrentRow.Cells["RequestDate"].Value);
        }

        private void BtnExportTxt_Click(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow == null)
            {
                MessageBox.Show("Δεν έχετε επιλέξει αίτηση.");
                return;
            }

            var row = dgvRequests.CurrentRow;
            int id = Convert.ToInt32(row.Cells["Id"].Value);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files|*.txt";
                sfd.FileName = $"aitisi_{id}.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine($"Αίτηση #{id}");
                    sb.AppendLine(new string('-', 40));
                    sb.AppendLine($"Ονοματεπώνυμο:\t{row.Cells["FullName"].Value}");
                    sb.AppendLine($"Email:\t\t{row.Cells["Email"].Value}");
                    sb.AppendLine($"Τηλέφωνο:\t{row.Cells["Phone"].Value}");
                    sb.AppendLine($"Ημ/νία Γέννησης:\t{row.Cells["BirthDate"].Value}");
                    sb.AppendLine($"Είδος Αιτήματος:\t{row.Cells["RequestType"].Value}");
                    sb.AppendLine($"Διεύθυνση:\t{row.Cells["Address"].Value}");
                    sb.AppendLine($"Ημ/νία Αιτήματος:\t{row.Cells["RequestDate"].Value}");

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Το αρχείο TXT δημιουργήθηκε με επιτυχία!");
                }
            }
        }

        private void BtnExportPdf_Click(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow == null)
            {
                MessageBox.Show("Δεν έχετε επιλέξει αίτηση.");
                return;
            }

            var row = dgvRequests.CurrentRow;
            int id = Convert.ToInt32(row.Cells["Id"].Value);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files|*.pdf";
                sfd.FileName = $"aitisi_{id}.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.BLACK);
                    var textFont = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK);

                    doc.Add(new Paragraph($"Αίτηση #{id}", titleFont));
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph($"Ονοματεπώνυμο: {row.Cells["FullName"].Value}", textFont));
                    doc.Add(new Paragraph($"Email: {row.Cells["Email"].Value}", textFont));
                    doc.Add(new Paragraph($"Τηλέφωνο: {row.Cells["Phone"].Value}", textFont));
                    doc.Add(new Paragraph($"Ημ/νία Γέννησης: {row.Cells["BirthDate"].Value}", textFont));
                    doc.Add(new Paragraph($"Είδος Αιτήματος: {row.Cells["RequestType"].Value}", textFont));
                    doc.Add(new Paragraph($"Διεύθυνση: {row.Cells["Address"].Value}", textFont));
                    doc.Add(new Paragraph($"Ημ/νία Αιτήματος: {row.Cells["RequestDate"].Value}", textFont));

                    doc.Close();
                    MessageBox.Show("Το αρχείο PDF δημιουργήθηκε με επιτυχία!");
                }
            }
        }


        private void ClearForm()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            cmbRequestType.SelectedIndex = -1;
            dtpBirthDate.Value = DateTime.Now;
            dtpRequestDate.Value = DateTime.Now;
        }

        private void NormalizeFormsLayout()
        {
            if (tableRequest != null)
            {
                tableRequest.RowStyles.Clear();
                tableRequest.RowCount = 3;
                tableRequest.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));  
                tableRequest.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));  
                tableRequest.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));  

                txtAddress.Multiline = true;
                txtAddress.ScrollBars = ScrollBars.Vertical;
                txtAddress.Dock = DockStyle.Fill;
            }

            if (tableCitizen != null)
            {
                tableCitizen.RowStyles.Clear();
                tableCitizen.RowCount = 4;
                tableCitizen.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                tableCitizen.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                tableCitizen.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                tableCitizen.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            }

            groupBoxCitizen.Padding = new Padding(8);
            groupBoxRequest.Padding = new Padding(8);
        }


        private void NormalizeTopBar()
        {
            if (panelTopBar == null) return;

            txtSearch.Width = 260;
            txtSearch.Top = (panelTopBar.Height - txtSearch.Height) / 2;
            txtSearch.Left = (panelTopBar.Width - txtSearch.Width) / 2; 
        }


        private void StyleGrid()
        {
            var g = dgvRequests;
            if (g == null) return;

            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;

            g.RowHeadersVisible = false;
            g.EnableHeadersVisualStyles = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            g.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            g.RowTemplate.Height = 28;

            
            g.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            g.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            
            g.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
            g.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            
            if (g.Columns.Contains("BirthDate"))
                g.Columns["BirthDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (g.Columns.Contains("RequestDate"))
                g.Columns["RequestDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }


        private void FixSplit()
        {
            if (splitContainer1 == null) return;

            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.SplitterWidth = 6;

            int target = Math.Max(420, Math.Min(520, this.ClientSize.Width / 3));
            if (target > 0 && target < this.ClientSize.Width - 200)
                splitContainer1.SplitterDistance = target;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            FixSplit();
            NormalizeTopBar();
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Αναζήτηση...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Αναζήτηση...";
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void StyleTopButtons()
        {
            foreach (var btn in new[] { btnLoad, btnSearch, btnEdit, btnDelete, btnExportTxt, btnExportPdf })
            {
                btn.Dock = DockStyle.Fill;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Margin = new Padding(5);
                btn.MinimumSize = new Size(100, 35);
            }
        }

    }
}
