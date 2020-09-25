using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1
{
    public class Node<T>
    {
        private T value;
        private Node<T> next;

        public Node(T value)
        {
            this.value = value;
            next = null;
        }

        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }

        public Node()
        {
        }

        public T GetValue()
        {
            return value;
        }

        public void SetValue(T value)
        {
            this.value = value;
        }

        public Node<T> GetNext()
        {
            return next;
        }

        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public bool HasNext()
        {
            return (next != null);
        }

        public void Add(T value)
        {
            Node<T> copy_node = this;
            SetNext(new Node<T>(value, copy_node.GetNext()));
        }
    }

    public static class NodeExtensions
    {
        public static void AddValue<T>(this Node<T> node, int pos, T value)
        {
            Node<T> copy_node = node;
            Node<T> currentObj = node;

            for (int i = 0; i < GetSize(node) + 1; i++)
            {
                if (i == pos)
                {
                    currentObj.SetNext(new Node<T>(value, copy_node.GetNext()));
                    break;
                }

                else
                {
                    currentObj.SetNext(copy_node.GetNext());
                }

                copy_node = copy_node.GetNext();
                currentObj = currentObj.GetNext();
            }
        }

        public static int GetSize<T>(this Node<T> node)
        {
            Node<T> pos = node;
            int size = 0;
            while (pos != null)
            {
                size++;
                pos = pos.GetNext();
            }

            return size;
        }

        public static string GetString<T>(this Node<T> node)
        {
            Node<T> pos = node;
            string finalStr = "";
            while (pos != null)
            {
                finalStr += pos.GetValue() + "-->";
                pos = pos.GetNext();
            }
            finalStr += "Null";
            return finalStr;
        }
    }

}
