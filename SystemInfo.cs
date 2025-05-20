using System;
using System.Management;
using System.Windows.Forms;

namespace System_Info
{
    public partial class SystemInfo : Form
    {
        public SystemInfo()
        {
            InitializeComponent();
        }

        private void SystemInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {


            try
            {
                // Generate and display Machine SID (unique system ID)
                txtMachineSID.Text = GetMachineSID();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving Machine SID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Generate and display UUID (using WMIC)
                txtUUID.Text = GetUUID();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving UUID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Display Hostname (Computer Name)
                txthostname.Text = Environment.MachineName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving hostname: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Display OS Installation ID
                txtOSID.Text = GetOSInstallDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving OS Install Date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Display Processor ID (Unique ID)
                txtProcessorID.Text = GetProcessorId();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving Processor ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Display Physical Address (MAC Address)
                txtPhysicalAddress.Text = GetPhysicalAddress();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving Physical Address: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Method to get the Machine SID (Security Identifier)
        private string GetMachineSID()
        {
            try
            {
                string machineSID = string.Empty;
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");

                foreach (ManagementObject obj in searcher.Get())
                {
                    machineSID = obj["Domain"].ToString(); // Machine SID is typically stored in the domain property
                    break;
                }

                return machineSID;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve Machine SID.", ex);
            }
        }

        // Method to get the UUID (using WMIC)
        private string GetUUID()
        {
            try
            {
                string uuid = string.Empty;
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystemProduct");

                foreach (ManagementObject obj in searcher.Get())
                {
                    uuid = obj["UUID"].ToString();
                    break;
                }

                return uuid;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve UUID.", ex);
            }
        }

        // Method to get the OS Installation ID (using WMIC)
        private string GetOSInstallDate()
        {
            try
            {
                string installDate = string.Empty;
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

                foreach (ManagementObject obj in searcher.Get())
                {
                    installDate = obj["InstallDate"].ToString();
                    break;
                }

                return installDate;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve OS Installation Date.", ex);
            }
        }

        // Method to get Processor ID (Unique Identifier)
        private string GetProcessorId()
        {
            try
            {
                string processorId = string.Empty;
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

                foreach (ManagementObject obj in searcher.Get())
                {
                    processorId = obj["ProcessorId"].ToString();
                    break;
                }

                return processorId;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve Processor ID.", ex);
            }
        }

        // Method to get Physical Address (MAC Address)
        private string GetPhysicalAddress()
        {
            try
            {
                string physicalAddress = string.Empty;
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");

                foreach (ManagementObject obj in searcher.Get())
                {
                    if (obj["MACAddress"] != null)
                    {
                        physicalAddress = obj["MACAddress"].ToString();
                        break;
                    }
                }

                return physicalAddress;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve Physical Address.", ex);
            }
        }

        private void btnExportText_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect the values from the textboxes
                string machineSID = txtMachineSID.Text;
                string uuid = txtUUID.Text;
                string hostname = txthostname.Text;
                string osInstallDate = txtOSID.Text;
                string processorID = txtProcessorID.Text;
                string physicalAddress = txtPhysicalAddress.Text;  // Add physical address

                // Format the content to be written into the file
                string content = $"Machine SID: {machineSID}\n" +
                                 $"UUID: {uuid}\n" +
                                 $"Hostname: {hostname}\n" +
                                 $"OS Install Date: {osInstallDate}\n" +
                                 $"Processor ID: {processorID}\n" +
                                 $"Physical Address: {physicalAddress}\n";  // Include physical address

                // Get the Downloads folder path
                string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

                // Create the file path for the new file
                string filePath = System.IO.Path.Combine(downloadsFolder, "systeminfo(Inventus).txt");

                // Write the content to the file
                System.IO.File.WriteAllText(filePath, content);

                // Notify the user
                MessageBox.Show("System information exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the process
                MessageBox.Show($"Error exporting system information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportText_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Collect the values from the textboxes
                string machineSID = txtMachineSID.Text;
                string uuid = txtUUID.Text;
                string hostname = txthostname.Text;
                string osInstallDate = txtOSID.Text;
                string processorID = txtProcessorID.Text;
                string physicalAddress = txtPhysicalAddress.Text;  // Add physical address

                // Format the content to be written into the file
                string content = $"Machine SID: {machineSID}\n" +
                                 $"UUID: {uuid}\n" +
                                 $"Hostname: {hostname}\n" +
                                 $"OS Install Date: {osInstallDate}\n" +
                                 $"Processor ID: {processorID}\n" +
                                 $"Physical Address: {physicalAddress}\n";  // Include physical address

                // Get the Downloads folder path
                string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

                // Create the file path for the new file
                string filePath = System.IO.Path.Combine(downloadsFolder, "systeminfo(Inventus).txt");

                // Write the content to the file
                System.IO.File.WriteAllText(filePath, content);

                // Notify the user
                MessageBox.Show("System information exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the process
                MessageBox.Show($"Error exporting system information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
