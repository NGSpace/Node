using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Node<T> {
        private T value;
        private Node<T> next;
        public Node(T value, Node<T> next) {
            this.value = value;
            this.next = next;
        }
        public Node(T value) : this(value, null) { }
        public Node() { }
        public T getValue() { return value; }
        public Node<T> getNext() { return next; }
        public void setValue(T value) { this.value = value; }
        public void setNext(Node<T> next) { this.next = next; }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            Node<T> a = this;
            while (a != null) {
                sb.Append(a.getValue() + ",");
                a = a.getNext();
            }
            sb.Append("}");

            return sb.ToString();
        }
        public static Node<int> GenerateRandomList(int size, int limit) {
            Random r = new Random();
            Node<int> a = new Node<int>(r.Next(limit));
            Node<int> b = a;
            for (int i = 0; i < size; i++) {
                b.setNext(new Node<int>(r.Next(limit)));
                b = b.getNext();
            }
            return a;
        }
    }
}
