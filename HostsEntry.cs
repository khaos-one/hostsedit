using System;
using System.Net;

namespace HostsEdit {
    [Serializable]
    public sealed class HostsEntry {
        public string Ip { get; set; }
        public string Host { get; set; }
        public bool IsActive { get; set; }
        public bool IsDull { get; set; }
        public string RawContent { get; set; }

        public override string ToString() {
            if (IsDull) {
                return RawContent;
            }

            if (!IsActive) {
                return $"# {Ip} {Host}";
            }
            else {
                return $"{Ip} {Host}";
            }
        }
    }
}
