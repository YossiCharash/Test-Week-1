namespace Test_1
{
    public class DefenceStrategiesBST
    {
        public NodeModel Root;

        public DefenceStrategiesBST()
        {

            Root = null;
        }
        public void InsertNode(NodeDTO node)
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

        public void preorderTraversal()
        {
            if(Root != null)
            {
            string arr = Root.Node.Defenses[0] + Root.Node.Defenses[1];
                Console.WriteLine($"root:[{Root.Node.MinSeverity}-{Root.Node.MaxSeverity}]Defenses:{arr}");
                recursivePreorder(Root,arr);
            }
            else
            {
                Console.WriteLine("There is no tree to process");
            }
        }
        public void recursivePreorder(NodeModel root,string arrstring)
        {

            if(root.Left == null && root.Right == null)
            {
                return;
            }
            Task.Delay(4000).Wait();
            // the name and path by node
            string l = "├ Left";
            string r = "└ Right";

            if(root.Left != null)
            {
                
                Task.Delay(4000).Wait();
                recursivePreorder(root.Left,arrstring);
                Console.WriteLine($"\t{l} child:[{root.Left.Node.MinSeverity}-{root.Left.Node.MaxSeverity}]Defenses:{arrstring}");
                if(root.Right != null)
                {
                    Task.Delay(4000).Wait();
                    recursivePreorder(root.Right,arrstring);
                    Console.WriteLine($"\t{r} child:[{root.Right.Node.MinSeverity}{root.Right.Node.MaxSeverity}]Defenses:{arrstring}");
                }
            }
        }
    }

}


