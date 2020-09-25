using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1
{
    class Task48
    {
        public Node<string> GetRepresentation(Node<TupleStrInt> sourceNode)
        {
            Node<string> Representation = new Node<string>();
            Node<string> currentObj = Representation;
            int sourceLlength = sourceNode.GetSize();

            for (int i = 0; i < sourceLlength; i++)
            {
                for (int j = 0; j < sourceNode.GetValue().Num; j++)
                {
                    currentObj.SetNext(new Node<string>(sourceNode.GetValue().Tav));
                    currentObj = currentObj.GetNext();
                }
                sourceNode = sourceNode.GetNext();
            }
            return Representation.GetNext();
        }
        public class TupleStrInt
        {
            public TupleStrInt(string Tav, int Num)
            {
                this.Tav = Tav;
                this.Num = Num;
                
            }

            public string Tav { get; set; }
            public int Num { get; set; }


        }
        

    }
}
