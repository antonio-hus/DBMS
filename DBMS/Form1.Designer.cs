namespace DBMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Main layout panel that fills the form
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;

        // GroupBoxes for the two sections
        private System.Windows.Forms.GroupBox groupBoxStaff;
        private System.Windows.Forms.GroupBox groupBoxVehicles;

        // ---------------------------
        // Staff (Parent Table) controls
        // ---------------------------
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStaff;
        private System.Windows.Forms.DataGridView parentTableDataGridView;
        private System.Windows.Forms.Panel panelStaffInputs;
        private System.Windows.Forms.Label lblStaffFirstName;
        private System.Windows.Forms.TextBox txtStaffFirstName;
        private System.Windows.Forms.Label lblStaffLastName;
        private System.Windows.Forms.TextBox txtStaffLastName;
        private System.Windows.Forms.Label lblStaffDOB;
        private System.Windows.Forms.TextBox txtStaffDOB;
        private System.Windows.Forms.Label lblStaffHireDate;
        private System.Windows.Forms.TextBox txtStaffHireDate;
        private System.Windows.Forms.Label lblStaffDepartment;
        // Department dropdown instead of textbox
        private System.Windows.Forms.ComboBox cmbStaffDepartment;
        private System.Windows.Forms.Panel panelStaffButtons;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnRefreshStaff;

        // ---------------------------
        // Vehicles (Child Table) controls
        // ---------------------------
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVehicles;
        private System.Windows.Forms.DataGridView childTableDataGridView;
        private System.Windows.Forms.Panel panelVehicleInputs;
        private System.Windows.Forms.Label lblVehicleID;
        // Vehicle dropdown instead of textbox
        private System.Windows.Forms.ComboBox cmbVehicleID;
        private System.Windows.Forms.Label lblVehicleRegPlate;
        private System.Windows.Forms.TextBox txtVehicleRegPlate;
        private System.Windows.Forms.Label lblVehicleLastService;
        private System.Windows.Forms.TextBox txtVehicleLastService;
        private System.Windows.Forms.Panel panelVehicleButtons;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnRefreshVehicle;

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
        ///  Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanelMain = new TableLayoutPanel();
            groupBoxStaff = new GroupBox();
            tableLayoutPanelStaff = new TableLayoutPanel();
            parentTableDataGridView = new DataGridView();
            panelStaffInputs = new Panel();
            inputTableLayoutPanelStaff = new TableLayoutPanel();
            lblStaffFirstName = new Label();
            txtStaffFirstName = new TextBox();
            lblStaffLastName = new Label();
            txtStaffLastName = new TextBox();
            lblStaffDOB = new Label();
            txtStaffDOB = new TextBox();
            lblStaffHireDate = new Label();
            txtStaffHireDate = new TextBox();
            lblStaffDepartment = new Label();
            cmbStaffDepartment = new ComboBox();
            panelStaffButtons = new Panel();
            buttonFlowLayoutPanelStaff = new FlowLayoutPanel();
            btnAddStaff = new Button();
            btnUpdateStaff = new Button();
            btnDeleteStaff = new Button();
            btnRefreshStaff = new Button();
            groupBoxVehicles = new GroupBox();
            tableLayoutPanelVehicles = new TableLayoutPanel();
            childTableDataGridView = new DataGridView();
            panelVehicleInputs = new Panel();
            inputTableLayoutPanelVehicles = new TableLayoutPanel();
            lblVehicleID = new Label();
            cmbVehicleID = new ComboBox();
            lblVehicleRegPlate = new Label();
            txtVehicleRegPlate = new TextBox();
            lblVehicleLastService = new Label();
            txtVehicleLastService = new TextBox();
            panelVehicleButtons = new Panel();
            buttonFlowLayoutPanelVehicles = new FlowLayoutPanel();
            btnAddVehicle = new Button();
            btnUpdateVehicle = new Button();
            btnDeleteVehicle = new Button();
            btnRefreshVehicle = new Button();
            tableLayoutPanelMain.SuspendLayout();
            groupBoxStaff.SuspendLayout();
            tableLayoutPanelStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parentTableDataGridView).BeginInit();
            panelStaffInputs.SuspendLayout();
            inputTableLayoutPanelStaff.SuspendLayout();
            panelStaffButtons.SuspendLayout();
            buttonFlowLayoutPanelStaff.SuspendLayout();
            groupBoxVehicles.SuspendLayout();
            tableLayoutPanelVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)childTableDataGridView).BeginInit();
            panelVehicleInputs.SuspendLayout();
            inputTableLayoutPanelVehicles.SuspendLayout();
            panelVehicleButtons.SuspendLayout();
            buttonFlowLayoutPanelVehicles.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(groupBoxStaff, 0, 0);
            tableLayoutPanelMain.Controls.Add(groupBoxVehicles, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMain.Size = new Size(1263, 600);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxStaff
            // 
            groupBoxStaff.Controls.Add(tableLayoutPanelStaff);
            groupBoxStaff.Dock = DockStyle.Fill;
            groupBoxStaff.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxStaff.Location = new Point(3, 3);
            groupBoxStaff.Name = "groupBoxStaff";
            groupBoxStaff.Size = new Size(625, 594);
            groupBoxStaff.TabIndex = 0;
            groupBoxStaff.TabStop = false;
            groupBoxStaff.Text = "Staff (Parent Table)";
            // 
            // tableLayoutPanelStaff
            // 
            tableLayoutPanelStaff.ColumnCount = 1;
            tableLayoutPanelStaff.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelStaff.Controls.Add(parentTableDataGridView, 0, 0);
            tableLayoutPanelStaff.Controls.Add(panelStaffInputs, 0, 1);
            tableLayoutPanelStaff.Controls.Add(panelStaffButtons, 0, 2);
            tableLayoutPanelStaff.Dock = DockStyle.Fill;
            tableLayoutPanelStaff.Location = new Point(3, 26);
            tableLayoutPanelStaff.Name = "tableLayoutPanelStaff";
            tableLayoutPanelStaff.RowCount = 3;
            tableLayoutPanelStaff.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelStaff.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanelStaff.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelStaff.Size = new Size(619, 565);
            tableLayoutPanelStaff.TabIndex = 0;
            // 
            // parentTableDataGridView
            // 
            parentTableDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            parentTableDataGridView.ColumnHeadersHeight = 29;
            parentTableDataGridView.Dock = DockStyle.Fill;
            parentTableDataGridView.Location = new Point(3, 3);
            parentTableDataGridView.Name = "parentTableDataGridView";
            parentTableDataGridView.RowHeadersWidth = 51;
            parentTableDataGridView.Size = new Size(613, 276);
            parentTableDataGridView.TabIndex = 0;
            parentTableDataGridView.CellContentClick += parentTableDataGridView_CellContentClick;
            // 
            // panelStaffInputs
            // 
            panelStaffInputs.BorderStyle = BorderStyle.FixedSingle;
            panelStaffInputs.Controls.Add(inputTableLayoutPanelStaff);
            panelStaffInputs.Dock = DockStyle.Fill;
            panelStaffInputs.Location = new Point(3, 285);
            panelStaffInputs.Name = "panelStaffInputs";
            panelStaffInputs.Size = new Size(613, 163);
            panelStaffInputs.TabIndex = 1;
            // 
            // inputTableLayoutPanelStaff
            // 
            inputTableLayoutPanelStaff.ColumnCount = 2;
            inputTableLayoutPanelStaff.ColumnStyles.Add(new ColumnStyle());
            inputTableLayoutPanelStaff.ColumnStyles.Add(new ColumnStyle());
            inputTableLayoutPanelStaff.Controls.Add(lblStaffFirstName, 0, 0);
            inputTableLayoutPanelStaff.Controls.Add(txtStaffFirstName, 1, 0);
            inputTableLayoutPanelStaff.Controls.Add(lblStaffLastName, 0, 1);
            inputTableLayoutPanelStaff.Controls.Add(txtStaffLastName, 1, 1);
            inputTableLayoutPanelStaff.Controls.Add(lblStaffDOB, 0, 2);
            inputTableLayoutPanelStaff.Controls.Add(txtStaffDOB, 1, 2);
            inputTableLayoutPanelStaff.Controls.Add(lblStaffHireDate, 0, 3);
            inputTableLayoutPanelStaff.Controls.Add(txtStaffHireDate, 1, 3);
            inputTableLayoutPanelStaff.Controls.Add(lblStaffDepartment, 0, 4);
            inputTableLayoutPanelStaff.Controls.Add(cmbStaffDepartment, 1, 4);
            inputTableLayoutPanelStaff.Dock = DockStyle.Fill;
            inputTableLayoutPanelStaff.Location = new Point(0, 0);
            inputTableLayoutPanelStaff.Name = "inputTableLayoutPanelStaff";
            inputTableLayoutPanelStaff.RowCount = 5;
            inputTableLayoutPanelStaff.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            inputTableLayoutPanelStaff.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            inputTableLayoutPanelStaff.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            inputTableLayoutPanelStaff.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            inputTableLayoutPanelStaff.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            inputTableLayoutPanelStaff.Size = new Size(611, 161);
            inputTableLayoutPanelStaff.TabIndex = 0;
            // 
            // lblStaffFirstName
            // 
            lblStaffFirstName.Location = new Point(3, 0);
            lblStaffFirstName.Name = "lblStaffFirstName";
            lblStaffFirstName.Size = new Size(100, 20);
            lblStaffFirstName.TabIndex = 0;
            lblStaffFirstName.Text = "First Name:";
            // 
            // txtStaffFirstName
            // 
            txtStaffFirstName.Dock = DockStyle.Fill;
            txtStaffFirstName.Location = new Point(148, 3);
            txtStaffFirstName.Name = "txtStaffFirstName";
            txtStaffFirstName.Size = new Size(460, 30);
            txtStaffFirstName.TabIndex = 1;
            // 
            // lblStaffLastName
            // 
            lblStaffLastName.Location = new Point(3, 20);
            lblStaffLastName.Name = "lblStaffLastName";
            lblStaffLastName.Size = new Size(100, 20);
            lblStaffLastName.TabIndex = 2;
            lblStaffLastName.Text = "Last Name:";
            // 
            // txtStaffLastName
            // 
            txtStaffLastName.Dock = DockStyle.Fill;
            txtStaffLastName.Location = new Point(148, 23);
            txtStaffLastName.Name = "txtStaffLastName";
            txtStaffLastName.Size = new Size(460, 30);
            txtStaffLastName.TabIndex = 3;
            // 
            // lblStaffDOB
            // 
            lblStaffDOB.Location = new Point(3, 40);
            lblStaffDOB.Name = "lblStaffDOB";
            lblStaffDOB.Size = new Size(139, 20);
            lblStaffDOB.TabIndex = 4;
            lblStaffDOB.Text = "Date of Birth:";
            // 
            // txtStaffDOB
            // 
            txtStaffDOB.Dock = DockStyle.Fill;
            txtStaffDOB.Location = new Point(148, 43);
            txtStaffDOB.Name = "txtStaffDOB";
            txtStaffDOB.Size = new Size(460, 30);
            txtStaffDOB.TabIndex = 5;
            // 
            // lblStaffHireDate
            // 
            lblStaffHireDate.Location = new Point(3, 60);
            lblStaffHireDate.Name = "lblStaffHireDate";
            lblStaffHireDate.Size = new Size(100, 20);
            lblStaffHireDate.TabIndex = 6;
            lblStaffHireDate.Text = "Hire Date:";
            // 
            // txtStaffHireDate
            // 
            txtStaffHireDate.Dock = DockStyle.Fill;
            txtStaffHireDate.Location = new Point(148, 63);
            txtStaffHireDate.Name = "txtStaffHireDate";
            txtStaffHireDate.Size = new Size(460, 30);
            txtStaffHireDate.TabIndex = 7;
            // 
            // lblStaffDepartment
            // 
            lblStaffDepartment.Location = new Point(3, 80);
            lblStaffDepartment.Name = "lblStaffDepartment";
            lblStaffDepartment.Size = new Size(100, 23);
            lblStaffDepartment.TabIndex = 8;
            lblStaffDepartment.Text = "Department:";
            // 
            // cmbStaffDepartment
            // 
            cmbStaffDepartment.Dock = DockStyle.Fill;
            cmbStaffDepartment.Location = new Point(148, 83);
            cmbStaffDepartment.Name = "cmbStaffDepartment";
            cmbStaffDepartment.Size = new Size(460, 31);
            cmbStaffDepartment.TabIndex = 9;
            // 
            // panelStaffButtons
            // 
            panelStaffButtons.BorderStyle = BorderStyle.FixedSingle;
            panelStaffButtons.Controls.Add(buttonFlowLayoutPanelStaff);
            panelStaffButtons.Dock = DockStyle.Fill;
            panelStaffButtons.Location = new Point(3, 454);
            panelStaffButtons.Name = "panelStaffButtons";
            panelStaffButtons.Size = new Size(613, 108);
            panelStaffButtons.TabIndex = 2;
            // 
            // buttonFlowLayoutPanelStaff
            // 
            buttonFlowLayoutPanelStaff.Controls.Add(btnAddStaff);
            buttonFlowLayoutPanelStaff.Controls.Add(btnUpdateStaff);
            buttonFlowLayoutPanelStaff.Controls.Add(btnDeleteStaff);
            buttonFlowLayoutPanelStaff.Controls.Add(btnRefreshStaff);
            buttonFlowLayoutPanelStaff.Dock = DockStyle.Fill;
            buttonFlowLayoutPanelStaff.Location = new Point(0, 0);
            buttonFlowLayoutPanelStaff.Name = "buttonFlowLayoutPanelStaff";
            buttonFlowLayoutPanelStaff.Size = new Size(611, 106);
            buttonFlowLayoutPanelStaff.TabIndex = 0;
            buttonFlowLayoutPanelStaff.WrapContents = false;
            // 
            // btnAddStaff
            // 
            btnAddStaff.AutoSize = true;
            btnAddStaff.Location = new Point(3, 3);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(75, 33);
            btnAddStaff.TabIndex = 0;
            btnAddStaff.Text = "Add";
            // 
            // btnUpdateStaff
            // 
            btnUpdateStaff.AutoSize = true;
            btnUpdateStaff.Location = new Point(84, 3);
            btnUpdateStaff.Name = "btnUpdateStaff";
            btnUpdateStaff.Size = new Size(79, 33);
            btnUpdateStaff.TabIndex = 1;
            btnUpdateStaff.Text = "Update";
            // 
            // btnDeleteStaff
            // 
            btnDeleteStaff.AutoSize = true;
            btnDeleteStaff.Location = new Point(169, 3);
            btnDeleteStaff.Name = "btnDeleteStaff";
            btnDeleteStaff.Size = new Size(75, 33);
            btnDeleteStaff.TabIndex = 2;
            btnDeleteStaff.Text = "Delete";
            // 
            // btnRefreshStaff
            // 
            btnRefreshStaff.AutoSize = true;
            btnRefreshStaff.Location = new Point(250, 3);
            btnRefreshStaff.Name = "btnRefreshStaff";
            btnRefreshStaff.Size = new Size(80, 33);
            btnRefreshStaff.TabIndex = 3;
            btnRefreshStaff.Text = "Refresh";
            // 
            // groupBoxVehicles
            // 
            groupBoxVehicles.Controls.Add(tableLayoutPanelVehicles);
            groupBoxVehicles.Dock = DockStyle.Fill;
            groupBoxVehicles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxVehicles.Location = new Point(634, 3);
            groupBoxVehicles.Name = "groupBoxVehicles";
            groupBoxVehicles.Size = new Size(626, 594);
            groupBoxVehicles.TabIndex = 1;
            groupBoxVehicles.TabStop = false;
            groupBoxVehicles.Text = "Vehicles (Child Table)";
            // 
            // tableLayoutPanelVehicles
            // 
            tableLayoutPanelVehicles.ColumnCount = 1;
            tableLayoutPanelVehicles.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelVehicles.Controls.Add(childTableDataGridView, 0, 0);
            tableLayoutPanelVehicles.Controls.Add(panelVehicleInputs, 0, 1);
            tableLayoutPanelVehicles.Controls.Add(panelVehicleButtons, 0, 2);
            tableLayoutPanelVehicles.Dock = DockStyle.Fill;
            tableLayoutPanelVehicles.Location = new Point(3, 26);
            tableLayoutPanelVehicles.Name = "tableLayoutPanelVehicles";
            tableLayoutPanelVehicles.RowCount = 3;
            tableLayoutPanelVehicles.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelVehicles.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanelVehicles.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelVehicles.Size = new Size(620, 565);
            tableLayoutPanelVehicles.TabIndex = 0;
            // 
            // childTableDataGridView
            // 
            childTableDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            childTableDataGridView.ColumnHeadersHeight = 29;
            childTableDataGridView.Dock = DockStyle.Fill;
            childTableDataGridView.Location = new Point(3, 3);
            childTableDataGridView.Name = "childTableDataGridView";
            childTableDataGridView.RowHeadersWidth = 51;
            childTableDataGridView.Size = new Size(614, 276);
            childTableDataGridView.TabIndex = 0;
            // 
            // panelVehicleInputs
            // 
            panelVehicleInputs.BorderStyle = BorderStyle.FixedSingle;
            panelVehicleInputs.Controls.Add(inputTableLayoutPanelVehicles);
            panelVehicleInputs.Dock = DockStyle.Fill;
            panelVehicleInputs.Location = new Point(3, 285);
            panelVehicleInputs.Name = "panelVehicleInputs";
            panelVehicleInputs.Size = new Size(614, 163);
            panelVehicleInputs.TabIndex = 1;
            // 
            // inputTableLayoutPanelVehicles
            // 
            inputTableLayoutPanelVehicles.ColumnCount = 2;
            inputTableLayoutPanelVehicles.ColumnStyles.Add(new ColumnStyle());
            inputTableLayoutPanelVehicles.ColumnStyles.Add(new ColumnStyle());
            inputTableLayoutPanelVehicles.Controls.Add(lblVehicleID, 0, 0);
            inputTableLayoutPanelVehicles.Controls.Add(cmbVehicleID, 1, 0);
            inputTableLayoutPanelVehicles.Controls.Add(lblVehicleRegPlate, 0, 1);
            inputTableLayoutPanelVehicles.Controls.Add(txtVehicleRegPlate, 1, 1);
            inputTableLayoutPanelVehicles.Controls.Add(lblVehicleLastService, 0, 2);
            inputTableLayoutPanelVehicles.Controls.Add(txtVehicleLastService, 1, 2);
            inputTableLayoutPanelVehicles.Dock = DockStyle.Fill;
            inputTableLayoutPanelVehicles.Location = new Point(0, 0);
            inputTableLayoutPanelVehicles.Name = "inputTableLayoutPanelVehicles";
            inputTableLayoutPanelVehicles.RowCount = 3;
            inputTableLayoutPanelVehicles.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            inputTableLayoutPanelVehicles.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            inputTableLayoutPanelVehicles.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            inputTableLayoutPanelVehicles.Size = new Size(612, 161);
            inputTableLayoutPanelVehicles.TabIndex = 0;
            // 
            // lblVehicleID
            // 
            lblVehicleID.Location = new Point(3, 0);
            lblVehicleID.Name = "lblVehicleID";
            lblVehicleID.Size = new Size(100, 20);
            lblVehicleID.TabIndex = 0;
            lblVehicleID.Text = "Vehicle ID:";
            // 
            // cmbVehicleID
            // 
            cmbVehicleID.Dock = DockStyle.Fill;
            cmbVehicleID.Location = new Point(135, 3);
            cmbVehicleID.Name = "cmbVehicleID";
            cmbVehicleID.Size = new Size(474, 31);
            cmbVehicleID.TabIndex = 1;
            // 
            // lblVehicleRegPlate
            // 
            lblVehicleRegPlate.Location = new Point(3, 20);
            lblVehicleRegPlate.Name = "lblVehicleRegPlate";
            lblVehicleRegPlate.Size = new Size(100, 20);
            lblVehicleRegPlate.TabIndex = 2;
            lblVehicleRegPlate.Text = "Reg Plate:";
            // 
            // txtVehicleRegPlate
            // 
            txtVehicleRegPlate.Dock = DockStyle.Fill;
            txtVehicleRegPlate.Location = new Point(135, 23);
            txtVehicleRegPlate.Name = "txtVehicleRegPlate";
            txtVehicleRegPlate.Size = new Size(474, 30);
            txtVehicleRegPlate.TabIndex = 3;
            // 
            // lblVehicleLastService
            // 
            lblVehicleLastService.Location = new Point(3, 40);
            lblVehicleLastService.Name = "lblVehicleLastService";
            lblVehicleLastService.Size = new Size(126, 23);
            lblVehicleLastService.TabIndex = 4;
            lblVehicleLastService.Text = "Last Serviced:";
            // 
            // txtVehicleLastService
            // 
            txtVehicleLastService.Dock = DockStyle.Fill;
            txtVehicleLastService.Location = new Point(135, 43);
            txtVehicleLastService.Name = "txtVehicleLastService";
            txtVehicleLastService.Size = new Size(474, 30);
            txtVehicleLastService.TabIndex = 5;
            // 
            // panelVehicleButtons
            // 
            panelVehicleButtons.BorderStyle = BorderStyle.FixedSingle;
            panelVehicleButtons.Controls.Add(buttonFlowLayoutPanelVehicles);
            panelVehicleButtons.Dock = DockStyle.Fill;
            panelVehicleButtons.Location = new Point(3, 454);
            panelVehicleButtons.Name = "panelVehicleButtons";
            panelVehicleButtons.Size = new Size(614, 108);
            panelVehicleButtons.TabIndex = 2;
            // 
            // buttonFlowLayoutPanelVehicles
            // 
            buttonFlowLayoutPanelVehicles.Controls.Add(btnAddVehicle);
            buttonFlowLayoutPanelVehicles.Controls.Add(btnUpdateVehicle);
            buttonFlowLayoutPanelVehicles.Controls.Add(btnDeleteVehicle);
            buttonFlowLayoutPanelVehicles.Controls.Add(btnRefreshVehicle);
            buttonFlowLayoutPanelVehicles.Dock = DockStyle.Fill;
            buttonFlowLayoutPanelVehicles.Location = new Point(0, 0);
            buttonFlowLayoutPanelVehicles.Name = "buttonFlowLayoutPanelVehicles";
            buttonFlowLayoutPanelVehicles.Size = new Size(612, 106);
            buttonFlowLayoutPanelVehicles.TabIndex = 0;
            buttonFlowLayoutPanelVehicles.WrapContents = false;
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.AutoSize = true;
            btnAddVehicle.Location = new Point(3, 3);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(75, 33);
            btnAddVehicle.TabIndex = 0;
            btnAddVehicle.Text = "Add";
            // 
            // btnUpdateVehicle
            // 
            btnUpdateVehicle.AutoSize = true;
            btnUpdateVehicle.Location = new Point(84, 3);
            btnUpdateVehicle.Name = "btnUpdateVehicle";
            btnUpdateVehicle.Size = new Size(79, 33);
            btnUpdateVehicle.TabIndex = 1;
            btnUpdateVehicle.Text = "Update";
            // 
            // btnDeleteVehicle
            // 
            btnDeleteVehicle.AutoSize = true;
            btnDeleteVehicle.Location = new Point(169, 3);
            btnDeleteVehicle.Name = "btnDeleteVehicle";
            btnDeleteVehicle.Size = new Size(75, 33);
            btnDeleteVehicle.TabIndex = 2;
            btnDeleteVehicle.Text = "Delete";
            // 
            // btnRefreshVehicle
            // 
            btnRefreshVehicle.AutoSize = true;
            btnRefreshVehicle.Location = new Point(250, 3);
            btnRefreshVehicle.Name = "btnRefreshVehicle";
            btnRefreshVehicle.Size = new Size(80, 33);
            btnRefreshVehicle.TabIndex = 3;
            btnRefreshVehicle.Text = "Refresh";
            // 
            // Form1
            // 
            ClientSize = new Size(1263, 600);
            Controls.Add(tableLayoutPanelMain);
            Name = "Form1";
            Text = "Logistics Co. Management System";
            Load += Form1_Load;
            tableLayoutPanelMain.ResumeLayout(false);
            groupBoxStaff.ResumeLayout(false);
            tableLayoutPanelStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)parentTableDataGridView).EndInit();
            panelStaffInputs.ResumeLayout(false);
            inputTableLayoutPanelStaff.ResumeLayout(false);
            inputTableLayoutPanelStaff.PerformLayout();
            panelStaffButtons.ResumeLayout(false);
            buttonFlowLayoutPanelStaff.ResumeLayout(false);
            buttonFlowLayoutPanelStaff.PerformLayout();
            groupBoxVehicles.ResumeLayout(false);
            tableLayoutPanelVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)childTableDataGridView).EndInit();
            panelVehicleInputs.ResumeLayout(false);
            inputTableLayoutPanelVehicles.ResumeLayout(false);
            inputTableLayoutPanelVehicles.PerformLayout();
            panelVehicleButtons.ResumeLayout(false);
            buttonFlowLayoutPanelVehicles.ResumeLayout(false);
            buttonFlowLayoutPanelVehicles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel inputTableLayoutPanelStaff;
        private FlowLayoutPanel buttonFlowLayoutPanelStaff;
        private TableLayoutPanel inputTableLayoutPanelVehicles;
        private FlowLayoutPanel buttonFlowLayoutPanelVehicles;
    }
}
