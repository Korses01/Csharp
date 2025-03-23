namespace Digity
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemSoubor = new System.Windows.Forms.ToolStripMenuItem();
            this.exportovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNastaveni = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem1s = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem2s = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem5s = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVzhled = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSvetlyRezim = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTmavyRezim = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageProcesy = new System.Windows.Forms.TabPage();
            this.gridProcesy = new System.Windows.Forms.DataGridView();
            this.contextUkoncit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ukončitProcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageVykon = new System.Windows.Forms.TabPage();
            this.lblDisky = new System.Windows.Forms.Label();
            this.lblOperacniPamet = new System.Windows.Forms.Label();
            this.lblProcesor = new System.Windows.Forms.Label();
            this.lblDiskInfo = new System.Windows.Forms.Label();
            this.elementHostDisk = new System.Windows.Forms.Integration.ElementHost();
            this.lblRAMInfo = new System.Windows.Forms.Label();
            this.lblCPUInfo = new System.Windows.Forms.Label();
            this.elementHostRAM = new System.Windows.Forms.Integration.ElementHost();
            this.elementHostCPU = new System.Windows.Forms.Integration.ElementHost();
            this.tabPageSit = new System.Windows.Forms.TabPage();
            this.lblPublicIP = new System.Windows.Forms.Label();
            this.lblLocalIP = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.elementHostNetwork = new System.Windows.Forms.Integration.ElementHost();
            this.lblDisk = new System.Windows.Forms.Label();
            this.progressBarDisk = new System.Windows.Forms.ProgressBar();
            this.chkSystemoveProcesy = new System.Windows.Forms.CheckBox();
            this.chkNarocneProcesy = new System.Windows.Forms.CheckBox();
            this.lblDown2 = new System.Windows.Forms.Label();
            this.lblUp2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageProcesy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcesy)).BeginInit();
            this.contextUkoncit.SuspendLayout();
            this.tabPageVykon.SuspendLayout();
            this.tabPageSit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCPU.Location = new System.Drawing.Point(271, 531);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(87, 21);
            this.lblCPU.TabIndex = 0;
            this.lblCPU.Text = "CPU Usage";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRAM.Location = new System.Drawing.Point(530, 530);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(91, 21);
            this.lblRAM.TabIndex = 1;
            this.lblRAM.Text = "RAM Usage";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemp.Location = new System.Drawing.Point(12, 494);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(97, 21);
            this.lblTemp.TabIndex = 2;
            this.lblTemp.Text = "Temperature";
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(412, 532);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(100, 20);
            this.progressBarCPU.TabIndex = 3;
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.Location = new System.Drawing.Point(672, 531);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(100, 21);
            this.progressBarRAM.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSoubor,
            this.menuItemNastaveni,
            this.menuItemAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemSoubor
            // 
            this.MenuItemSoubor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportovatToolStripMenuItem,
            this.MenuItemExit});
            this.MenuItemSoubor.Name = "MenuItemSoubor";
            this.MenuItemSoubor.Size = new System.Drawing.Size(57, 20);
            this.MenuItemSoubor.Text = "Soubor";
            // 
            // exportovatToolStripMenuItem
            // 
            this.exportovatToolStripMenuItem.Name = "exportovatToolStripMenuItem";
            this.exportovatToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exportovatToolStripMenuItem.Text = "Exportovat";
            this.exportovatToolStripMenuItem.Click += new System.EventHandler(this.exportovatToolStripMenuItem_Click);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(130, 22);
            this.MenuItemExit.Text = "Ukončit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // menuItemNastaveni
            // 
            this.menuItemNastaveni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemInterval,
            this.MenuItemVzhled});
            this.menuItemNastaveni.Name = "menuItemNastaveni";
            this.menuItemNastaveni.Size = new System.Drawing.Size(71, 20);
            this.menuItemNastaveni.Text = "Nastavení";
            // 
            // MenuItemInterval
            // 
            this.MenuItemInterval.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem1s,
            this.MenuItem2s,
            this.MenuItem5s});
            this.MenuItemInterval.Name = "MenuItemInterval";
            this.MenuItemInterval.Size = new System.Drawing.Size(174, 22);
            this.MenuItemInterval.Text = "Interval aktualizace";
            // 
            // menuitem1s
            // 
            this.menuitem1s.Name = "menuitem1s";
            this.menuitem1s.Size = new System.Drawing.Size(88, 22);
            this.menuitem1s.Text = "1 s";
            this.menuitem1s.Click += new System.EventHandler(this.menuitem1s_Click);
            // 
            // MenuItem2s
            // 
            this.MenuItem2s.Name = "MenuItem2s";
            this.MenuItem2s.Size = new System.Drawing.Size(88, 22);
            this.MenuItem2s.Text = "2 s";
            this.MenuItem2s.Click += new System.EventHandler(this.MenuItem2s_Click);
            // 
            // MenuItem5s
            // 
            this.MenuItem5s.Name = "MenuItem5s";
            this.MenuItem5s.Size = new System.Drawing.Size(88, 22);
            this.MenuItem5s.Text = "5 s";
            this.MenuItem5s.Click += new System.EventHandler(this.MenuItem5s_Click);
            // 
            // MenuItemVzhled
            // 
            this.MenuItemVzhled.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSvetlyRezim,
            this.MenuItemTmavyRezim});
            this.MenuItemVzhled.Name = "MenuItemVzhled";
            this.MenuItemVzhled.Size = new System.Drawing.Size(174, 22);
            this.MenuItemVzhled.Text = "Vzhled";
            // 
            // MenuItemSvetlyRezim
            // 
            this.MenuItemSvetlyRezim.Name = "MenuItemSvetlyRezim";
            this.MenuItemSvetlyRezim.Size = new System.Drawing.Size(141, 22);
            this.MenuItemSvetlyRezim.Text = "Světlý režim";
            this.MenuItemSvetlyRezim.Click += new System.EventHandler(this.MenuItemSvetlyRezim_Click);
            // 
            // MenuItemTmavyRezim
            // 
            this.MenuItemTmavyRezim.Name = "MenuItemTmavyRezim";
            this.MenuItemTmavyRezim.Size = new System.Drawing.Size(141, 22);
            this.MenuItemTmavyRezim.Text = "Tmavý režim";
            this.MenuItemTmavyRezim.Click += new System.EventHandler(this.MenuItemTmavyRezim_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(71, 20);
            this.menuItemAbout.Text = "O aplikaci";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageProcesy);
            this.tabControl.Controls.Add(this.tabPageVykon);
            this.tabControl.Controls.Add(this.tabPageSit);
            this.tabControl.Location = new System.Drawing.Point(29, 38);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(720, 392);
            this.tabControl.TabIndex = 6;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageProcesy
            // 
            this.tabPageProcesy.Controls.Add(this.gridProcesy);
            this.tabPageProcesy.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcesy.Name = "tabPageProcesy";
            this.tabPageProcesy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcesy.Size = new System.Drawing.Size(712, 366);
            this.tabPageProcesy.TabIndex = 0;
            this.tabPageProcesy.Text = "Procesy";
            this.tabPageProcesy.UseVisualStyleBackColor = true;
            // 
            // gridProcesy
            // 
            this.gridProcesy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProcesy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProcesy.ContextMenuStrip = this.contextUkoncit;
            this.gridProcesy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProcesy.Location = new System.Drawing.Point(3, 3);
            this.gridProcesy.Name = "gridProcesy";
            this.gridProcesy.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gridProcesy.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProcesy.Size = new System.Drawing.Size(706, 360);
            this.gridProcesy.TabIndex = 0;
            // 
            // contextUkoncit
            // 
            this.contextUkoncit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukončitProcesToolStripMenuItem});
            this.contextUkoncit.Name = "contextUkoncit";
            this.contextUkoncit.Size = new System.Drawing.Size(154, 26);
            // 
            // ukončitProcesToolStripMenuItem
            // 
            this.ukončitProcesToolStripMenuItem.Name = "ukončitProcesToolStripMenuItem";
            this.ukončitProcesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ukončitProcesToolStripMenuItem.Text = "Ukončit proces";
            this.ukončitProcesToolStripMenuItem.Click += new System.EventHandler(this.ukončitProcesToolStripMenuItem_Click);
            // 
            // tabPageVykon
            // 
            this.tabPageVykon.Controls.Add(this.lblDisky);
            this.tabPageVykon.Controls.Add(this.lblOperacniPamet);
            this.tabPageVykon.Controls.Add(this.lblProcesor);
            this.tabPageVykon.Controls.Add(this.lblDiskInfo);
            this.tabPageVykon.Controls.Add(this.elementHostDisk);
            this.tabPageVykon.Controls.Add(this.lblRAMInfo);
            this.tabPageVykon.Controls.Add(this.lblCPUInfo);
            this.tabPageVykon.Controls.Add(this.elementHostRAM);
            this.tabPageVykon.Controls.Add(this.elementHostCPU);
            this.tabPageVykon.Location = new System.Drawing.Point(4, 22);
            this.tabPageVykon.Name = "tabPageVykon";
            this.tabPageVykon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVykon.Size = new System.Drawing.Size(712, 366);
            this.tabPageVykon.TabIndex = 1;
            this.tabPageVykon.Text = "Výkon";
            this.tabPageVykon.UseVisualStyleBackColor = true;
            // 
            // lblDisky
            // 
            this.lblDisky.AutoSize = true;
            this.lblDisky.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDisky.Location = new System.Drawing.Point(26, 244);
            this.lblDisky.Name = "lblDisky";
            this.lblDisky.Size = new System.Drawing.Size(87, 17);
            this.lblDisky.TabIndex = 8;
            this.lblDisky.Text = "Pevné Disky:";
            // 
            // lblOperacniPamet
            // 
            this.lblOperacniPamet.AutoSize = true;
            this.lblOperacniPamet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOperacniPamet.Location = new System.Drawing.Point(26, 125);
            this.lblOperacniPamet.Name = "lblOperacniPamet";
            this.lblOperacniPamet.Size = new System.Drawing.Size(112, 17);
            this.lblOperacniPamet.TabIndex = 7;
            this.lblOperacniPamet.Text = "Operační paměť:";
            // 
            // lblProcesor
            // 
            this.lblProcesor.AutoSize = true;
            this.lblProcesor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProcesor.Location = new System.Drawing.Point(27, 6);
            this.lblProcesor.Name = "lblProcesor";
            this.lblProcesor.Size = new System.Drawing.Size(66, 17);
            this.lblProcesor.TabIndex = 6;
            this.lblProcesor.Text = "Procesor:";
            // 
            // lblDiskInfo
            // 
            this.lblDiskInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDiskInfo.Location = new System.Drawing.Point(26, 270);
            this.lblDiskInfo.MaximumSize = new System.Drawing.Size(350, 50);
            this.lblDiskInfo.Name = "lblDiskInfo";
            this.lblDiskInfo.Size = new System.Drawing.Size(350, 50);
            this.lblDiskInfo.TabIndex = 5;
            this.lblDiskInfo.Text = "DISK N/A";
            // 
            // elementHostDisk
            // 
            this.elementHostDisk.Location = new System.Drawing.Point(410, 244);
            this.elementHostDisk.Name = "elementHostDisk";
            this.elementHostDisk.Size = new System.Drawing.Size(296, 100);
            this.elementHostDisk.TabIndex = 4;
            this.elementHostDisk.Text = "elementHost1";
            this.elementHostDisk.Child = null;
            // 
            // lblRAMInfo
            // 
            this.lblRAMInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRAMInfo.Location = new System.Drawing.Point(26, 151);
            this.lblRAMInfo.MaximumSize = new System.Drawing.Size(350, 50);
            this.lblRAMInfo.Name = "lblRAMInfo";
            this.lblRAMInfo.Size = new System.Drawing.Size(350, 50);
            this.lblRAMInfo.TabIndex = 3;
            this.lblRAMInfo.Text = "RAM N/A";
            // 
            // lblCPUInfo
            // 
            this.lblCPUInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCPUInfo.Location = new System.Drawing.Point(27, 32);
            this.lblCPUInfo.MaximumSize = new System.Drawing.Size(350, 50);
            this.lblCPUInfo.Name = "lblCPUInfo";
            this.lblCPUInfo.Size = new System.Drawing.Size(350, 50);
            this.lblCPUInfo.TabIndex = 2;
            this.lblCPUInfo.Text = "CPU N/A";
            // 
            // elementHostRAM
            // 
            this.elementHostRAM.Location = new System.Drawing.Point(410, 125);
            this.elementHostRAM.Name = "elementHostRAM";
            this.elementHostRAM.Size = new System.Drawing.Size(296, 100);
            this.elementHostRAM.TabIndex = 1;
            this.elementHostRAM.Text = "elementHost2";
            this.elementHostRAM.Child = null;
            // 
            // elementHostCPU
            // 
            this.elementHostCPU.Location = new System.Drawing.Point(410, 6);
            this.elementHostCPU.Name = "elementHostCPU";
            this.elementHostCPU.Size = new System.Drawing.Size(296, 100);
            this.elementHostCPU.TabIndex = 0;
            this.elementHostCPU.Text = "elementHost1";
            this.elementHostCPU.Child = null;
            // 
            // tabPageSit
            // 
            this.tabPageSit.Controls.Add(this.lblPublicIP);
            this.tabPageSit.Controls.Add(this.lblLocalIP);
            this.tabPageSit.Controls.Add(this.lblUpload);
            this.tabPageSit.Controls.Add(this.lblDownload);
            this.tabPageSit.Controls.Add(this.elementHostNetwork);
            this.tabPageSit.Location = new System.Drawing.Point(4, 22);
            this.tabPageSit.Name = "tabPageSit";
            this.tabPageSit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSit.Size = new System.Drawing.Size(712, 366);
            this.tabPageSit.TabIndex = 2;
            this.tabPageSit.Text = "Síť";
            this.tabPageSit.UseVisualStyleBackColor = true;
            // 
            // lblPublicIP
            // 
            this.lblPublicIP.AutoSize = true;
            this.lblPublicIP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPublicIP.Location = new System.Drawing.Point(376, 335);
            this.lblPublicIP.Name = "lblPublicIP";
            this.lblPublicIP.Size = new System.Drawing.Size(42, 17);
            this.lblPublicIP.TabIndex = 4;
            this.lblPublicIP.Text = "Public";
            // 
            // lblLocalIP
            // 
            this.lblLocalIP.AutoSize = true;
            this.lblLocalIP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLocalIP.Location = new System.Drawing.Point(376, 309);
            this.lblLocalIP.Name = "lblLocalIP";
            this.lblLocalIP.Size = new System.Drawing.Size(38, 17);
            this.lblLocalIP.TabIndex = 3;
            this.lblLocalIP.Text = "Local";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblUpload.ForeColor = System.Drawing.Color.Red;
            this.lblUpload.Location = new System.Drawing.Point(25, 335);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(25, 17);
            this.lblUpload.TabIndex = 2;
            this.lblUpload.Text = "Up";
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDownload.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDownload.Location = new System.Drawing.Point(25, 309);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(41, 17);
            this.lblDownload.TabIndex = 1;
            this.lblDownload.Text = "Down";
            // 
            // elementHostNetwork
            // 
            this.elementHostNetwork.Location = new System.Drawing.Point(6, 6);
            this.elementHostNetwork.Name = "elementHostNetwork";
            this.elementHostNetwork.Size = new System.Drawing.Size(700, 290);
            this.elementHostNetwork.TabIndex = 0;
            this.elementHostNetwork.Text = "elementHost1";
            this.elementHostNetwork.Child = null;
            // 
            // lblDisk
            // 
            this.lblDisk.AutoSize = true;
            this.lblDisk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDisk.Location = new System.Drawing.Point(12, 530);
            this.lblDisk.Name = "lblDisk";
            this.lblDisk.Size = new System.Drawing.Size(87, 21);
            this.lblDisk.TabIndex = 9;
            this.lblDisk.Text = "Disk Usage";
            // 
            // progressBarDisk
            // 
            this.progressBarDisk.Location = new System.Drawing.Point(152, 531);
            this.progressBarDisk.Name = "progressBarDisk";
            this.progressBarDisk.Size = new System.Drawing.Size(100, 20);
            this.progressBarDisk.TabIndex = 10;
            // 
            // chkSystemoveProcesy
            // 
            this.chkSystemoveProcesy.AutoSize = true;
            this.chkSystemoveProcesy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkSystemoveProcesy.Location = new System.Drawing.Point(36, 448);
            this.chkSystemoveProcesy.Name = "chkSystemoveProcesy";
            this.chkSystemoveProcesy.Size = new System.Drawing.Size(164, 17);
            this.chkSystemoveProcesy.TabIndex = 11;
            this.chkSystemoveProcesy.Text = "Systémové procesy ( zeleně )";
            this.chkSystemoveProcesy.UseVisualStyleBackColor = true;
            this.chkSystemoveProcesy.CheckedChanged += new System.EventHandler(this.chkSystemoveProcesy_CheckedChanged);
            // 
            // chkNarocneProcesy
            // 
            this.chkNarocneProcesy.AutoSize = true;
            this.chkNarocneProcesy.ForeColor = System.Drawing.Color.Red;
            this.chkNarocneProcesy.Location = new System.Drawing.Point(209, 448);
            this.chkNarocneProcesy.Name = "chkNarocneProcesy";
            this.chkNarocneProcesy.Size = new System.Drawing.Size(161, 17);
            this.chkNarocneProcesy.TabIndex = 12;
            this.chkNarocneProcesy.Text = "Náročné procesy ( červeně )";
            this.chkNarocneProcesy.UseVisualStyleBackColor = true;
            this.chkNarocneProcesy.CheckedChanged += new System.EventHandler(this.chkNarocneProcesy_CheckedChanged);
            // 
            // lblDown2
            // 
            this.lblDown2.AutoSize = true;
            this.lblDown2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDown2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDown2.Location = new System.Drawing.Point(271, 494);
            this.lblDown2.Name = "lblDown2";
            this.lblDown2.Size = new System.Drawing.Size(51, 21);
            this.lblDown2.TabIndex = 5;
            this.lblDown2.Text = "Down";
            // 
            // lblUp2
            // 
            this.lblUp2.AutoSize = true;
            this.lblUp2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUp2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUp2.Location = new System.Drawing.Point(530, 494);
            this.lblUp2.Name = "lblUp2";
            this.lblUp2.Size = new System.Drawing.Size(30, 21);
            this.lblUp2.TabIndex = 5;
            this.lblUp2.Text = "Up";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblUp2);
            this.Controls.Add(this.lblDown2);
            this.Controls.Add(this.chkNarocneProcesy);
            this.Controls.Add(this.chkSystemoveProcesy);
            this.Controls.Add(this.progressBarDisk);
            this.Controls.Add(this.lblDisk);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.progressBarRAM);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digity - System monitor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageProcesy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProcesy)).EndInit();
            this.contextUkoncit.ResumeLayout(false);
            this.tabPageVykon.ResumeLayout(false);
            this.tabPageVykon.PerformLayout();
            this.tabPageSit.ResumeLayout(false);
            this.tabPageSit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemNastaveni;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageProcesy;
        private System.Windows.Forms.TabPage tabPageVykon;
        private System.Windows.Forms.DataGridView gridProcesy;
        private System.Windows.Forms.Integration.ElementHost elementHostRAM;
        private System.Windows.Forms.Integration.ElementHost elementHostCPU;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInterval;
        private System.Windows.Forms.ToolStripMenuItem menuitem1s;
        private System.Windows.Forms.ToolStripMenuItem MenuItem2s;
        private System.Windows.Forms.ToolStripMenuItem MenuItem5s;
        private System.Windows.Forms.ToolStripMenuItem MenuItemVzhled;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSvetlyRezim;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTmavyRezim;
        private System.Windows.Forms.ContextMenuStrip contextUkoncit;
        private System.Windows.Forms.ToolStripMenuItem ukončitProcesToolStripMenuItem;
        private System.Windows.Forms.Label lblRAMInfo;
        private System.Windows.Forms.Label lblCPUInfo;
        private System.Windows.Forms.Label lblDisk;
        private System.Windows.Forms.ProgressBar progressBarDisk;
        private System.Windows.Forms.Integration.ElementHost elementHostDisk;
        private System.Windows.Forms.Label lblDiskInfo;
        private System.Windows.Forms.Label lblProcesor;
        private System.Windows.Forms.Label lblDisky;
        private System.Windows.Forms.Label lblOperacniPamet;
        private System.Windows.Forms.CheckBox chkSystemoveProcesy;
        private System.Windows.Forms.CheckBox chkNarocneProcesy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSoubor;
        private System.Windows.Forms.ToolStripMenuItem exportovatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.TabPage tabPageSit;
        private System.Windows.Forms.Integration.ElementHost elementHostNetwork;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Label lblPublicIP;
        private System.Windows.Forms.Label lblLocalIP;
        private System.Windows.Forms.Label lblDown2;
        private System.Windows.Forms.Label lblUp2;
    }
}

