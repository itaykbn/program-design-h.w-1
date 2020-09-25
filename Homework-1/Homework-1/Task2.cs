using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1
{
    class Task2
    {
        public List<RangeNode> CreateRangeList(List<int> sourceList)
        {
            List<RangeNode> result = new List<RangeNode>();
            bool seq = false;
            int min = sourceList[0];
            int max = 0;
            for (int i = 0; i < sourceList.Count; i++)
            {
                if (sourceList.Count - 1 == i)
                {
                    if (seq == true)
                    {
                        max = sourceList[i];
                        result.Add(new RangeNode(min, max));
                    }
                    else
                    {
                        result.Add(new RangeNode(sourceList[i], sourceList[i]));
                    }
                }


                else if (sourceList[i] + 1 == sourceList[i + 1])
                    {
                        max = sourceList[i];
                        seq = true;
                    }
               
                else
                {
                    if (seq == true)
                    {
                        max = sourceList[i];
                        result.Add(new RangeNode(min, max));
                        seq = false;
                    }
                    else
                    {
                        result.Add(new RangeNode(sourceList[i], sourceList[i]));
                    }

                        min = sourceList[i + 1];
                    


                }
            }
            return result;
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
