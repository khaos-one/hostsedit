using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace HostsEdit {
    public sealed class ExtendedBindingList<T> : BindingList<T> {
        public event Action<T, int> ItemAdding;
        public event Action<T, int> ItemRemoving;

        public ExtendedBindingList() 
            : base() { }

        public ExtendedBindingList(IList<T> source)
            : base(source) { }

        protected override void RemoveItem(int index) {
            var item = Items[index];
            ItemRemoving?.Invoke(item, index);
            base.RemoveItem(index);
        }

        //public override void EndNew(int itemIndex) {
        //    //var item = Items[itemIndex];
        //    //NewItemCommited?.Invoke(item, itemIndex);
        //    base.EndNew(itemIndex);
        //}

        //protected override void SetItem(int index, T item) {
        //    base.SetItem(index, item);
        //}

        protected override void InsertItem(int index, T item) {
            ItemAdding?.Invoke(item, index);
            base.InsertItem(index, item);
        }
    }
}
