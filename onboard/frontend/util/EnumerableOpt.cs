using System.Collections;
using System.Collections.Generic;

namespace onboard.util; 

public class OptList<T> : IList<T> {
    public IEnumerator<T> GetEnumerator() {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }

    public void Add(T item) {
        throw new System.NotImplementedException();
    }

    public void Clear() {
        throw new System.NotImplementedException();
    }

    public bool Contains(T item) {
        throw new System.NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex) {
        throw new System.NotImplementedException();
    }

    public bool Remove(T item) {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(T item) {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, T item) {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index) {
        throw new System.NotImplementedException();
    }

    public T this[int index] {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}