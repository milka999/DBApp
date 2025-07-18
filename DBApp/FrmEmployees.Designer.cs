namespace DBApp
{
    partial class FrmEmployees
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zaposleniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.projektiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvjestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sviZaposleniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniNaProjektuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sviProjektiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.rtxtSearchText = new System.Windows.Forms.RichTextBox();
            this.lblSalaryFrom = new System.Windows.Forms.Label();
            this.rtxtSalaryFrom = new System.Windows.Forms.RichTextBox();
            this.lblSalaryTo = new System.Windows.Forms.Label();
            this.rtxtSalaryTo = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddToProject = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniToolStripMenuItem,
            this.projektiToolStripMenuItem,
            this.izvjestajiToolStripMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zaposleniToolStripMenuItem
            // 
            this.zaposleniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddEmployee});
            this.zaposleniToolStripMenuItem.Name = "zaposleniToolStripMenuItem";
            this.zaposleniToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.zaposleniToolStripMenuItem.Text = "Zaposleni";
            // 
            // menuItemAddEmployee
            // 
            this.menuItemAddEmployee.Name = "menuItemAddEmployee";
            this.menuItemAddEmployee.Size = new System.Drawing.Size(214, 26);
            this.menuItemAddEmployee.Text = "Dodaj zaposlenog";
            // 
            // projektiToolStripMenuItem
            // 
            this.projektiToolStripMenuItem.Name = "projektiToolStripMenuItem";
            this.projektiToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.projektiToolStripMenuItem.Text = "Projekti";
            // 
            // izvjestajiToolStripMenuItem
            // 
            this.izvjestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sviZaposleniToolStripMenuItem,
            this.zaposleniNaProjektuToolStripMenuItem,
            this.sviProjektiToolStripMenuItem});
            this.izvjestajiToolStripMenuItem.Name = "izvjestajiToolStripMenuItem";
            this.izvjestajiToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.izvjestajiToolStripMenuItem.Text = "Izvjestaji";
            // 
            // sviZaposleniToolStripMenuItem
            // 
            this.sviZaposleniToolStripMenuItem.Name = "sviZaposleniToolStripMenuItem";
            this.sviZaposleniToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.sviZaposleniToolStripMenuItem.Text = "Svi zaposleni";
            // 
            // zaposleniNaProjektuToolStripMenuItem
            // 
            this.zaposleniNaProjektuToolStripMenuItem.Name = "zaposleniNaProjektuToolStripMenuItem";
            this.zaposleniNaProjektuToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.zaposleniNaProjektuToolStripMenuItem.Text = "Zaposleni na projektu";
            // 
            // sviProjektiToolStripMenuItem
            // 
            this.sviProjektiToolStripMenuItem.Name = "sviProjektiToolStripMenuItem";
            this.sviProjektiToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.sviProjektiToolStripMenuItem.Text = "Svi projekti";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(59, 24);
            this.exitMenuItem.Text = "Izadji";
            // 
            // lblEmployeeList
            // 
            this.lblEmployeeList.AutoSize = true;
            this.lblEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeList.Location = new System.Drawing.Point(12, 53);
            this.lblEmployeeList.Name = "lblEmployeeList";
            this.lblEmployeeList.Size = new System.Drawing.Size(185, 29);
            this.lblEmployeeList.TabIndex = 1;
            this.lblEmployeeList.Text = "Lista zaposlenih";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 243);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(911, 323);
            this.dgvEmployees.TabIndex = 2;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployee.Location = new System.Drawing.Point(12, 99);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(168, 65);
            this.btnEditEmployee.TabIndex = 3;
            this.btnEditEmployee.Text = "Izmijeni odabranog";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(200, 99);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(168, 65);
            this.btnDeleteEmployee.TabIndex = 4;
            this.btnDeleteEmployee.Text = "Izbrisi odabranog";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Location = new System.Drawing.Point(14, 195);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(114, 16);
            this.lblSearchText.TabIndex = 5;
            this.lblSearchText.Text = "Tekst za pretragu:";
            // 
            // rtxtSearchText
            // 
            this.rtxtSearchText.Location = new System.Drawing.Point(134, 179);
            this.rtxtSearchText.Name = "rtxtSearchText";
            this.rtxtSearchText.Size = new System.Drawing.Size(217, 32);
            this.rtxtSearchText.TabIndex = 6;
            this.rtxtSearchText.Text = "";
            // 
            // lblSalaryFrom
            // 
            this.lblSalaryFrom.AutoSize = true;
            this.lblSalaryFrom.Location = new System.Drawing.Point(368, 195);
            this.lblSalaryFrom.Name = "lblSalaryFrom";
            this.lblSalaryFrom.Size = new System.Drawing.Size(60, 16);
            this.lblSalaryFrom.TabIndex = 7;
            this.lblSalaryFrom.Text = "Plata od:";
            // 
            // rtxtSalaryFrom
            // 
            this.rtxtSalaryFrom.Location = new System.Drawing.Point(434, 179);
            this.rtxtSalaryFrom.Name = "rtxtSalaryFrom";
            this.rtxtSalaryFrom.Size = new System.Drawing.Size(103, 32);
            this.rtxtSalaryFrom.TabIndex = 8;
            this.rtxtSalaryFrom.Text = "";
            // 
            // lblSalaryTo
            // 
            this.lblSalaryTo.AutoSize = true;
            this.lblSalaryTo.Location = new System.Drawing.Point(543, 195);
            this.lblSalaryTo.Name = "lblSalaryTo";
            this.lblSalaryTo.Size = new System.Drawing.Size(60, 16);
            this.lblSalaryTo.TabIndex = 9;
            this.lblSalaryTo.Text = "Plata do:";
            // 
            // rtxtSalaryTo
            // 
            this.rtxtSalaryTo.Location = new System.Drawing.Point(609, 179);
            this.rtxtSalaryTo.Name = "rtxtSalaryTo";
            this.rtxtSalaryTo.Size = new System.Drawing.Size(103, 32);
            this.rtxtSalaryTo.TabIndex = 10;
            this.rtxtSalaryTo.Text = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(731, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(168, 65);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Pretraga";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddToProject
            // 
            this.btnAddToProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToProject.Location = new System.Drawing.Point(383, 99);
            this.btnAddToProject.Name = "btnAddToProject";
            this.btnAddToProject.Size = new System.Drawing.Size(168, 65);
            this.btnAddToProject.TabIndex = 12;
            this.btnAddToProject.Text = "Dodaj na projekat";
            this.btnAddToProject.UseVisualStyleBackColor = true;
            // 
            // FrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 578);
            this.Controls.Add(this.btnAddToProject);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rtxtSalaryTo);
            this.Controls.Add(this.lblSalaryTo);
            this.Controls.Add(this.rtxtSalaryFrom);
            this.Controls.Add(this.lblSalaryFrom);
            this.Controls.Add(this.rtxtSearchText);
            this.Controls.Add(this.lblSearchText);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.lblEmployeeList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmEmployees";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zaposleniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvjestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sviZaposleniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniNaProjektuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sviProjektiToolStripMenuItem;
        private System.Windows.Forms.Label lblEmployeeList;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.RichTextBox rtxtSearchText;
        private System.Windows.Forms.Label lblSalaryFrom;
        private System.Windows.Forms.RichTextBox rtxtSalaryFrom;
        private System.Windows.Forms.Label lblSalaryTo;
        private System.Windows.Forms.RichTextBox rtxtSalaryTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddToProject;
    }
}

