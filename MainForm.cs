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
            _hosts.Load();
            dataGridView.DataSource = _hosts.RelevantEntries;
        }

        private void saveButton_Click(object sender, EventArgs e) {
            dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            _hosts.Save();
        }

        private void reloadButton_Click(object sender, EventArgs e) {
            _hosts.Load();
            dataGridView.DataSource = _hosts.RelevantEntries;
        }
    }
}
