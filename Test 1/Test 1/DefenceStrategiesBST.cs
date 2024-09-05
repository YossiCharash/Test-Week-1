using Newtonsoft.Json;

namespace Test_1
{
    public class DefenceStrategiesBST
    {
        public  NodeModel Root;

        public DefenceStrategiesBST()
        {
            
            Root = null;
        }
        public  void InsertNode(NodeDTO node)
        {
            Root = InsertRecursive(Root, node);
        }

        private NodeModel InsertRecursive(NodeModel nodeModel, NodeDTO value)
        {
            if(nodeModel == null)
            {
                nodeModel = new NodeModel(value);
                return nodeModel;
            }
            int sum = nodeModel.Node.MinSeverity + nodeModel.Node.MaxSeverity;
            if((value.MinSeverity + value.MinSeverity) < sum)
            {
                nodeModel.Left = InsertRecursive(nodeModel.Left, value);
            }
            else
            {
                nodeModel.Right = InsertRecursive(nodeModel.Right, value);
            }
            return nodeModel;
        }


    }
}

