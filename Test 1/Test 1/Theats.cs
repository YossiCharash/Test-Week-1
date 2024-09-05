namespace Test_1
{
    public class Theats
    {
        public NodeModel Root;

        public Theats()
        {
            Root = null;
        }

        public void preorderTraversal(NodeModel root, int taValue, ThreatsDTO theats)
        {
            if(root == null)
            {
                Task.Delay(2000).Wait();
                Console.WriteLine("was defence suitable No found. Brace for impact");
                return;
            }
            if(root.Node.MinSeverity > taValue)
            {
                Task.Delay(2000).Wait();
                Console.WriteLine("is severity Attack below the threshold.Attack is ignored"); return;
            }
            if(root.Node.MaxSeverity == taValue || root.Node.MinSeverity == taValue)
            {
                Task.Delay(2000).Wait();
                Console.WriteLine(theats.ThreatType);
            }
            if(root.Left != null)
            {
                if(root.Left.Node.MaxSeverity >= taValue)
                {
                    preorderTraversal(root.Left, taValue,theats); ;
                }
            }
       
                preorderTraversal(root.Right, taValue,theats);

            }
        }
    }

