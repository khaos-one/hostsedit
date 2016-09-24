using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace HostsEdit {
    public sealed class HostsFile {
        public static string FilePath
            => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers", "etc", "hosts");

        public static readonly Regex ActiveEntryRegex = new Regex(@"^\s*(?<IP>[0-9\.]+)\s+(?<HOST>[a-zA-Z0-9\-\:\/\.]+)", RegexOptions.Compiled);

        public static readonly Regex DisabledEntryRegex =
            new Regex(@"^\s*#\s*(?<IP>[0-9\.]+)\s+(?<HOST>[a-zA-Z0-9\-\:\/\.]+)", RegexOptions.Compiled);

        public static readonly Regex DullLineRegex = new Regex(@"^\s*#.*", RegexOptions.Compiled);

        public List<HostsEntry> Lines { get; private set; }

        public ExtendedBindingList<HostsEntry> RelevantEntries { get; private set; }

        public void Load() {
            string[] content;

            try {
                content = File.ReadAllLines(FilePath);
            }
            catch (Exception) {
                throw;
            }

            Lines = new List<HostsEntry>(content.Length);

            foreach (var line in content) {
                var match = ActiveEntryRegex.Match(line);

                if (match.Success) {
                    Lines.Add(new HostsEntry {
                        Ip = match.Groups["IP"].Value,
                        Host = match.Groups["HOST"].Value,
                        IsActive = true,
                        IsDull = false
                    });
                }
                else {
                    match = DisabledEntryRegex.Match(line);

                    if (match.Success) {
                        Lines.Add(new HostsEntry {
                            Ip = match.Groups["IP"].Value,
                            Host = match.Groups["HOST"].Value,
                            IsActive = false,
                            IsDull = false
                        });
                    }
                    else {
                        match = DullLineRegex.Match(line);

                        if (match.Success) {
                            Lines.Add(new HostsEntry {
                                IsActive = false,
                                IsDull = true,
                                RawContent = match.Groups[0].Value
                            });
                        }
                        else {
                            // Line is invalid, omit it.
                        }
                    }
                }
            }

            RelevantEntries = new ExtendedBindingList<HostsEntry>(Lines.Where(x => !x.IsDull).ToList()) {
                AllowEdit = true,
                AllowNew = true,
                AllowRemove = true,
                RaiseListChangedEvents = true
            };
            RelevantEntries.ItemAdding += RelevantEntriesOnItemAdding;
            RelevantEntries.ItemRemoving += RelevantEntriesOnItemRemoving;
        }

        private void RelevantEntriesOnItemRemoving(HostsEntry hostsEntry, int i) {
            Lines.Remove(hostsEntry);
        }

        private void RelevantEntriesOnItemAdding(HostsEntry hostsEntry, int i) {
            Lines.Add(hostsEntry);
        }

        public void Save() {
            var content = new List<string>(Lines.Count);

            foreach (var entry in Lines) {
                content.Add(entry.ToString());
            }

            try {
                File.WriteAllLines(FilePath, content);
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
