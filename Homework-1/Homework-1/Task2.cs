using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1
{
    class Task2
    {
        public Node<RangeNode> CreateRangeList(Node<int> sourceList)
        {
            Node<RangeNode> CurrantObj = new Node<RangeNode>();
            Node<RangeNode> result = CurrantObj;
            
            bool seq = false;
            int min = sourceList.GetValue();
            Node<int> tmp = sourceList;
            while (tmp != null)
            {
                int max;

                if (tmp.GetNext() == null)
                {
                    if (seq == true)
                    {
                        max = tmp.GetValue();
                        CurrantObj.SetNext(new Node<RangeNode>(new RangeNode(min, max)));
                        seq = false;
                    }
                    else
                    {
                        CurrantObj.SetNext(new Node<RangeNode>(new RangeNode(tmp.GetValue(), tmp.GetValue())));
                    }

                }

                else if (tmp.GetValue() + 1 == tmp.GetNext().GetValue())
                {
                    seq = true;
                }

                else
                {

                    if (seq == true)
                    {
                        max = tmp.GetValue();
                        CurrantObj.SetNext(new Node<RangeNode>(new RangeNode(min,max)));
                        seq = false;
                    }
                    else
                    {
                        CurrantObj.SetNext(new Node<RangeNode>(new RangeNode(tmp.GetValue(), tmp.GetValue())));
                    }

                    min = tmp.GetNext().GetValue();
                    CurrantObj = CurrantObj.GetNext();
                }
                tmp = tmp.GetNext();
            }
            return result.GetNext();
        }

        public class RangeNode
        {
            public int From { get; set; }
            public int To { get; set; }

            public RangeNode(int From, int To)
            {
                this.From = From;
                this.To = To;
            }
        }

    }
}
