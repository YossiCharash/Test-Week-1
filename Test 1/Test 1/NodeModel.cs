using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    public class NodeModel
    {
        public NodeDTO Node { get; set; }
        public NodeModel? Left { get; set; }

        public NodeModel? Right { get; set; }

        public NodeModel(NodeDTO node)
        {
            Node = node;
            Left = null;
            Right = null;
        }


    }
}
