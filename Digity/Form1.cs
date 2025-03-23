using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;
using LibreHardwareMonitor.Hardware;
using LiveCharts.Wpf;
using LiveCharts;

namespace Digity
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private Timer timer;
        private Timer processTimer;
        private Computer _computer;
        private HashSet<int> lastProcessIds = new HashSet<int>();
        private LiveCharts.Wpf.CartesianChart chartCPU;
        private LiveCharts.Wpf.CartesianChart chartRAM;
        private LiveCharts.Wpf.CartesianChart chartDisk;
        private LiveCharts.Wpf.CartesianChart chartNet;
        private PerformanceCounter diskCounter;
        private List<double> cpuHistory = new List<double>();
        private List<double> ramHistory = new List<double>();
        private List<double> diskHistory = new List<double>();
        private List<double> tempHistory = new List<double>();
        private bool tmavyRezim = false;
        private PerformanceCounter netDownloadCounter;
        private PerformanceCounter netUploadCounter;
        private List<double> downloadHistory = new List<double>();
        private List<double> uploadHistory = new List<double>();

        public Form1()
        {
            InitializeComponent();
            InitializeHardwareMonitor();
            InitializeProcessGrid();
            LoadProcesses();
            InitializeHardwareInfo();

            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            diskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");

            netDownloadCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", GetNetworkAdapter());
            netUploadCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", GetNetworkAdapter());

            timer = new Timer { Interval = 1000 };
            timer.Tick += Timer_Tick;
            timer.Start();

            processTimer = new Timer { Interval = 1000 };
            processTimer.Tick += ProcessTimer_Tick;
            processTimer.Start();

            chartCPU = new LiveCharts.Wpf.CartesianChart();
            chartRAM = new LiveCharts.Wpf.CartesianChart();
            chartDisk = new LiveCharts.Wpf.CartesianChart();
            
            chartNet = new LiveCharts.Wpf.CartesianChart();

            elementHostCPU.Child = chartCPU;
            elementHostRAM.Child = chartRAM;
            elementHostDisk.Child = chartDisk;
            elementHostNetwork.Child = chartNet;

            InitializeCharts();
        }

        private void InitializeCharts()
        {
            chartCPU.Series = new LiveCharts.SeriesCollection
            {
                new LiveCharts.Wpf.LineSeries
                {
                    Title = "CPU Usage",
                    Values = new LiveCharts.ChartValues<double>(),
                    LineSmoothness = 0, // ostré hrany
                    PointGeometry = null, // bez bodů
                    StrokeThickness = 2
                }
            };

            chartCPU.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Čas (sekundy)"
            });

            chartCPU.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "CPU (%)",
                MinValue = 0,
                MaxValue = 100
            });

            chartRAM.Series = new LiveCharts.SeriesCollection
            {
                new LiveCharts.Wpf.LineSeries
                {
                    Title = "RAM Usage",
                    Values = new LiveCharts.ChartValues<double>(),
                    LineSmoothness = 0,
                    PointGeometry = null,
                    StrokeThickness = 2
                }
            };

            chartRAM.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Čas (sekundy)"
            });

            chartRAM.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "RAM (%)",
            });

            chartDisk.Series = new LiveCharts.SeriesCollection
            {
                new LiveCharts.Wpf.LineSeries
                {
                    Title = "Disk Usage",
                    Values = new LiveCharts.ChartValues<double>(),
                    LineSmoothness = 0,
                    PointGeometry = null,
                    StrokeThickness = 2
                }
            };

            chartDisk.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Čas (sekundy)"
            });

            chartDisk.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Disky (%)",
            });
    
            chartNet.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                    {
                        Title = "Download (Mb/s)",
                        Values = new ChartValues<double>(),
                        LineSmoothness = 0,
                        PointGeometry = null,
                        StrokeThickness = 2
                    },
                new LineSeries
                    {
                        Title = "Upload (Mb/s)",
                        Values = new ChartValues<double>(),
                        LineSmoothness = 0,
                        PointGeometry = null,
                        StrokeThickness = 2
                    }
            };

            chartNet.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Čas (s)"
            });

            chartNet.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Rychlost (Mb/s)",
                MinValue = 0
            });
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            float cpuUsage = cpuCounter.NextValue();
            float ramAvailable = ramCounter.NextValue();
            float ramUsage = 100 - (ramAvailable / GetTotalRAM() * 100);
            float cpuTemp = GetCPUTemperature();
            float diskUsage = diskCounter.NextValue();
            float diskUsage2 = GetDiskUsage2();
            float downloadSpeed = netDownloadCounter.NextValue() / (1024 * 1024); // Mb/s
            float uploadSpeed = netUploadCounter.NextValue() / (1024 * 1024); // Mb/s

            lblCPU.Text = $"CPU Usage: {cpuUsage:F1}%";
            progressBarCPU.Value = (int)cpuUsage;

            lblRAM.Text = $"RAM Usage: {ramUsage:F1}%";
            progressBarRAM.Value = (int)ramUsage;

            lblTemp.Text = cpuTemp > 0 ? $"CPU Temp: {cpuTemp:F1}°C" : "CPU Temp: N/A";

            lblDisk.Text = $"Disk Usage: {diskUsage:F1}%";
            progressBarDisk.Value = (int)Math.Min(diskUsage, 100);

            lblDownload.Text = $"Download: {downloadSpeed:F1} Mb/s";
            lblUpload.Text = $"Upload: {uploadSpeed:F1} Mb/s";

            lblLocalIP.Text = "Lokální IP: " + GetLocalIPAddress();
            lblPublicIP.Text = "Veřejná IP: " + GetPublicIPAddress();

            lblDown2.Text = $"↓ {downloadSpeed:F1} Mb/s";
            lblUp2.Text = $"↑ {uploadSpeed:F1} Mb/s";

            cpuHistory.Add(cpuUsage);
            ramHistory.Add(ramUsage);
            diskHistory.Add(diskUsage);
            tempHistory.Add(cpuTemp);
            downloadHistory.Add(downloadSpeed);
            uploadHistory.Add(uploadSpeed);

            if (cpuHistory.Count > 60) cpuHistory.RemoveAt(0);
            if (ramHistory.Count > 60) ramHistory.RemoveAt(0);
            if (diskHistory.Count > 60) diskHistory.RemoveAt(0);
            if (tempHistory.Count > 60) tempHistory.RemoveAt(0);
            if (downloadHistory.Count > 60) downloadHistory.RemoveAt(0);
            if (uploadHistory.Count > 60) uploadHistory.RemoveAt(0);

            chartCPU.Series[0].Values.Add((double)cpuUsage);
            chartRAM.Series[0].Values.Add((double)ramUsage);
            chartDisk.Series[0].Values.Add((double)diskUsage);
            
            chartNet.Series[0].Values.Add((double)downloadSpeed);
            chartNet.Series[1].Values.Add((double)uploadSpeed);

            if (chartCPU.Series[0].Values.Count > 60)
                chartCPU.Series[0].Values.RemoveAt(0);

            if (chartRAM.Series[0].Values.Count > 60)
                chartRAM.Series[0].Values.RemoveAt(0);

            if (chartDisk.Series[0].Values.Count > 60)
                chartDisk.Series[0].Values.RemoveAt(0);

            if (chartDisk.Series[0].Values.Count > 60)
                chartDisk.Series[0].Values.RemoveAt(0);

            UpdateDiskUsageInfo();
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private float GetDiskUsage2()
        {
            var diskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
            return diskCounter.NextValue();
        }

        private void UpdateDiskUsageInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            StringBuilder diskInfo = new StringBuilder();

            foreach (DriveInfo drive in allDrives)
            {
                if (drive.IsReady)
                {
                    double totalSpaceGB = drive.TotalSize / (1024.0 * 1024.0 * 1024.0);
                    double freeSpaceGB = drive.AvailableFreeSpace / (1024.0 * 1024.0 * 1024.0);
                    double usedSpaceGB = totalSpaceGB - freeSpaceGB;
                    double usagePercent = (usedSpaceGB / totalSpaceGB) * 100;

                    diskInfo.AppendLine($"{drive.Name} {usagePercent:F1}% ({usedSpaceGB:F1} GB / {totalSpaceGB:F1} GB)");
                }
            }

            lblDiskInfo.Text = diskInfo.ToString();
        }

        private float GetTotalRAM()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem"))
            {
                foreach (var obj in searcher.Get())
                {
                    return float.Parse(obj["TotalPhysicalMemory"].ToString()) / (1024 * 1024);
                }
            }
            return 0;
        }

        private string GetNetworkAdapter()
        {
            var category = new PerformanceCounterCategory("Network Interface");
            string[] instanceNames = category.GetInstanceNames();

            foreach (string name in instanceNames)
            {
                if (!name.Contains("Loopback") && !name.Contains("Teredo")) // Vynecháme interní adaptéry
                {
                    return name;
                }
            }
            return instanceNames.Length > 0 ? instanceNames[0] : "";
        }

        private void InitializeHardwareMonitor()
        {
            _computer = new Computer { IsCpuEnabled = true };
            _computer.Open();
        }

        private float GetCPUTemperature()
        {
            if (_computer == null) return 0;

            foreach (var hardware in _computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Value.HasValue)
                        {
                            return sensor.Value.Value;
                        }
                    }
                }
            }
            return 0;
        }

        private void InitializeHardwareInfo()
        {
            lblCPUInfo.Text = GetCPUInfo();
            lblRAMInfo.Text = GetRAMInfo();
        }

        private string GetCPUInfo()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT Name, NumberOfCores FROM Win32_Processor"))
            {
                foreach (var obj in searcher.Get())
                {
                    string name = obj["Name"].ToString().Trim();
                    int cores = Convert.ToInt32(obj["NumberOfCores"]);
                    return $"{name} ({cores} jader)";
                }
            }
            return "Procesor: Neznámý";
        }

        private string GetRAMInfo()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem"))
            {
                foreach (var obj in searcher.Get())
                {
                    double totalRam = Convert.ToDouble(obj["TotalPhysicalMemory"]) / (1024 * 1024 * 1024);
                    return $"RAM: {totalRam:F1} GB";
                }
            }
            return "RAM: Neznámá";
        }

        private string GetLocalIPAddress()
        {
            string localIP = "Nenalezeno";
            var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) 
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

        private string GetPublicIPAddress()
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    return webClient.DownloadString("https://api64.ipify.org").Trim();
                }
            }
            catch (Exception)
            {
                return "0.0.0.0"; 
            }
        }

        private void InitializeProcessGrid()
        {
            gridProcesy.Columns.Clear();
            gridProcesy.Columns.Add("ProcessName", "Název procesu");
            gridProcesy.Columns.Add("ProcessId", "ID");
            gridProcesy.Columns.Add("MemoryUsage", " Využití RAM (MB)");

            StylizujDataGridView();
        }
        
        private void StylizujDataGridView()
        {
            if (tmavyRezim)
            {
                gridProcesy.EnableHeadersVisualStyles = false;
                gridProcesy.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
                gridProcesy.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gridProcesy.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
                gridProcesy.DefaultCellStyle.ForeColor = Color.White;
                gridProcesy.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
                gridProcesy.DefaultCellStyle.SelectionForeColor = Color.White;
                gridProcesy.GridColor = Color.FromArgb(50, 50, 50);
                gridProcesy.BackgroundColor = Color.FromArgb(30, 30, 30);
            }
            else
            {
                gridProcesy.EnableHeadersVisualStyles = false;
                gridProcesy.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                gridProcesy.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                gridProcesy.DefaultCellStyle.BackColor = Color.White;
                gridProcesy.DefaultCellStyle.ForeColor = Color.Black;
                gridProcesy.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                gridProcesy.DefaultCellStyle.SelectionForeColor = Color.Black;
                gridProcesy.GridColor = Color.Silver;
                gridProcesy.BackgroundColor = Color.White;
            }

            foreach (DataGridViewRow row in gridProcesy.Rows)
            {
                row.DefaultCellStyle.BackColor = tmavyRezim ? Color.FromArgb(50, 50, 50) : Color.White;
                row.DefaultCellStyle.ForeColor = tmavyRezim ? Color.White : Color.Black;
            }
        }

        private void LoadProcesses()
        {
            var currentProcesses = Process.GetProcesses();
            var currentProcessIds = new HashSet<int>(currentProcesses.Select(p => p.Id));
            bool processCountChanged = !currentProcessIds.SetEquals(lastProcessIds);

            DataGridViewColumn sortedColumn = gridProcesy.SortedColumn;
            ListSortDirection sortDirection = ListSortDirection.Ascending;
            if (sortedColumn != null && gridProcesy.SortOrder != SortOrder.None)
            {
                sortDirection = gridProcesy.SortOrder == SortOrder.Descending
                    ? ListSortDirection.Descending
                    : ListSortDirection.Ascending;
            }

            if (processCountChanged)
            {
                gridProcesy.Rows.Clear();
                foreach (var process in currentProcesses)
                {
                    try
                    {
                        gridProcesy.Rows.Add(process.ProcessName, process.Id,
                            (process.WorkingSet64 / 1024.0 / 1024.0).ToString("F1") + " MB");
                    }
                    catch (Exception) { }
                }

                StylizujDataGridView();
            }
            else
            {  
                foreach (DataGridViewRow row in gridProcesy.Rows)
                {
                    try
                    {
                        if (row.Cells[1].Value == null || row.Cells[2].Value == null)
                            continue;

                        if (int.TryParse(row.Cells[1].Value.ToString(), out int processId))
                        {
                            var process = Array.Find(currentProcesses, p => p.Id == processId);
                            if (process != null)
                            {
                                string newRamUsage = (process.WorkingSet64 / 1024.0 / 1024.0).ToString("F1") + " MB";

                                if (row.Cells[2].Value.ToString() != newRamUsage)
                                {
                                    row.Cells[2].Value = newRamUsage;
                                }
                            }
                        }
                    }
                    catch (Exception) { }
                }

            }

            if (sortedColumn != null)
            {
                gridProcesy.Sort(sortedColumn, sortDirection);
            }

            lastProcessIds = currentProcessIds;

            foreach (DataGridViewRow row in gridProcesy.Rows)
            {
                if (row.Cells[1].Value == null)
                    continue;

                string processName = row.Cells[0].Value?.ToString() ?? "";
                int processId;

                if (!int.TryParse(row.Cells[1].Value.ToString(), out processId))
                    continue;

                Color backColor = Color.White;
                Color foreColor = Color.Black;

                if (processName.ToLower().Contains("system") || processName.ToLower().Contains("service"))
                {
                    backColor = Color.LightGreen;
                }
                else if (processName.ToLower().Contains("chrome") || processName.ToLower().Contains("firefox") || processName.ToLower().Contains("explorer"))
                {
                    backColor = Color.LightCoral;
                }

                row.DefaultCellStyle.BackColor = backColor;
                row.DefaultCellStyle.ForeColor = foreColor;
            }
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digity - Monitorovací aplikace\nVerze 1.0", "O aplikaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuitem1s_Click(object sender, EventArgs e)
        {
            timer.Interval = 1000;
        }

        private void MenuItem2s_Click(object sender, EventArgs e)
        {
            timer.Interval = 2000;
        }

        private void MenuItem5s_Click(object sender, EventArgs e)
        {
            timer.Interval = 5000;
        }

        private void MenuItemSvetlyRezim_Click(object sender, EventArgs e)
        {
            tmavyRezim = false; 
            this.BackColor = Color.White;
            ForeColor = Color.Black;
            tabPageVykon.BackColor = Color.White;
            tabPageProcesy.BackColor = Color.White;
            tabPageSit.BackColor = Color.White;
            lblUp2.ForeColor = Color.Black;    
            lblDown2.ForeColor = Color.Black;
            StylizujDataGridView();
        }

        private void MenuItemTmavyRezim_Click(object sender, EventArgs e)
        {
            tmavyRezim = true; 
            this.BackColor = Color.FromArgb(30, 30, 30);
            ForeColor = Color.White;
            tabPageVykon.BackColor = Color.FromArgb(30, 30, 30);
            tabPageProcesy.BackColor = Color.FromArgb(30, 30, 30);
            tabPageSit.BackColor = Color.FromArgb(30, 30, 30);
            lblUp2.ForeColor = Color.White;    
            lblDown2.ForeColor = Color.White;
            StylizujDataGridView();
        }

        private void UpdateProcessView()
        {
            foreach (DataGridViewRow row in gridProcesy.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                string processName = row.Cells[0].Value.ToString().ToLower();
                bool jeSystemovy = processName.Contains("system") || processName.Contains("service");
                bool jeNarocny = processName.Contains("chrome") || processName.Contains("firefox") || processName.Contains("explorer");

                // Logika filtrování podle zaškrtnutých checkboxů
                bool zobrazit = true;

                if (chkSystemoveProcesy.Checked && !jeSystemovy)
                    zobrazit = false;

                if (chkNarocneProcesy.Checked && !jeNarocny)
                    zobrazit = false;

                row.Visible = zobrazit;
            }
        }

        private void ukončitProcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridProcesy.SelectedRows.Count > 0)
            {
                try
                {
                    int processId = (int)gridProcesy.SelectedRows[0].Cells[1].Value;
                    string processName = gridProcesy.SelectedRows[0].Cells[0].Value.ToString();

                    DialogResult result = MessageBox.Show($"Opravdu chcete ukončit proces '{processName}'?",
                                                          "Potvrzení", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Process process = Process.GetProcessById(processId);
                        process.Kill();
                        process.WaitForExit();

                        LoadProcesses(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Nelze ukončit proces: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vyberte proces, který chcete ukončit.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ProcesyTab = (tabControl.SelectedTab == tabPageProcesy);

            chkSystemoveProcesy.Visible = ProcesyTab;
            chkNarocneProcesy.Visible = ProcesyTab;
        }

        private void chkSystemoveProcesy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProcessView();
        }

        private void chkNarocneProcesy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProcessView();
        }

        private void ExportToCsv()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.Title = "Uložit CSV soubor";
                saveFileDialog.FileName = "performance_data.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine("Digity log; ");
                    sb.AppendLine($"Datum a čas: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    sb.AppendLine("");
                    sb.AppendLine($"Lokální ;IP: ;{GetLocalIPAddress()}");
                    sb.AppendLine($"Veřejná ;IP: ;{GetPublicIPAddress()}");
                    sb.AppendLine("");                    
                    sb.AppendLine("Čas (s);CPU (%);RAM (%);Disk (%);CPU TEMP (°C);Stahování (Mb/s);Odesílání (Mb/s)");
                 
                    for (int i = 0; i < cpuHistory.Count; i++)
                    {
                        sb.AppendLine($"{i + 1};{cpuHistory[i]:F1};{ramHistory[i]:F1};{diskHistory[i]:F1};{tempHistory[i]:F1};{downloadHistory[i]:F2};{uploadHistory[i]:F2}");
                    }

                    File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Export dokončen!", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void exportovatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToCsv();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
         DialogResult result = MessageBox.Show("Opravdu chcete ukončit aplikaci?","Potvrzení ukončení", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
