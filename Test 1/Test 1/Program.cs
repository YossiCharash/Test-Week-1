using Newtonsoft.Json;
using Test_1;


//DI
DefenceStrategiesBST d = new DefenceStrategiesBST();
Theats t = new Theats();
string defenc = File.ReadAllText(Path.Combine("C:\\Users\\c0548\\OneDrive\\שולחן העבודה\\Tests\\Test Week 1\\Test 1\\Test 1\\defenceStrategiesBalanced.json"));
List<NodeDTO>? defenclist = JsonConvert.DeserializeObject<List<NodeDTO>>(defenc);
foreach(NodeDTO node in defenclist)
{
    //insert node
    d.InsertNode(node);
}
d.preorderTraversal();
string threats = File.ReadAllText(Path.Combine("C:\\Users\\c0548\\OneDrive\\שולחן העבודה\\Tests\\Test Week 1\\Test 1\\Test 1\\threats.json"));
List<ThreatsDTO>? theatslist = JsonConvert.DeserializeObject<List<ThreatsDTO>>(threats);


foreach(ThreatsDTO threat in theatslist)
{
    //what is the threat
    int theatsvalue = 0;
    if(threat.Target == "Web Server")
    {
        theatsvalue = 15;
    }
    if(threat.Target == "Database")
    {
        theatsvalue = 20;
    }
    if(threat.Target == "User Credentials")
    {
        theatsvalue = 10;
    }
    int severity = (threat.Value * threat.Sophistication) + theatsvalue;




    t.preorderTraversal(d.Root, severity, threat);

}




