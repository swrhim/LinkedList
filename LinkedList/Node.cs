using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<K, T>
    {
        public K Key;
        public T Item;
        public Node<K, T> Next;
        public Node<K, T> Prev;

        public Node()
        {
            this.Key = default(K);
            this.Item = default(T);
            this.Next = null;
        }

        public Node(K key, T item, Node<K, T> next)
        {
            this.Key = key;
            this.Item = item;
            this.Next = next;
        }
    }
}
