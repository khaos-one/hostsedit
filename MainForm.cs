using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostsEdit {
    public partial class MainForm : Form {
        private HostsFile _hosts = new HostsFile();

        public MainForm() {
            InitializeComponent();

            KeyPreview = true;
            dataGridView.AutoGenerateColumns = false;

            LoadAll(null, null);
        }

        private void SaveAll(object sender, EventArgs e) {
            dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            _hosts.Save();
        }

        private void LoadAll(object sender, EventArgs e) {
            try {
                _hosts.Load();
            }
            catch {
                MessageBox.Show("Failed to open hosts file.", "Failed to open hosts file.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            dataGridView.DataSource = _hosts.RelevantEntries;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.S) {
                SaveAll(null, null);
            }
        }
    }
}
