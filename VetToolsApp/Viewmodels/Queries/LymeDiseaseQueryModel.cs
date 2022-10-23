using BinaryTreeStructures.Nodes;

namespace VetToolsApp.Viewmodels.Queries;

public class LymeDiseaseQueryModel
{
    List<QueryNode> queryNodes;
    public List<QueryNode> Queries
    {
        get { return queryNodes; }
        set
        {
            if (queryNodes != value)
            {
                queryNodes = value;
            }
        }
    }

    public LymeDiseaseQueryModel()
    {
        queryNodes = new List<QueryNode>
        {
            new QueryNode(0, null, "LymeDisease: Is it a yes or a no?"),
            new QueryNode(1, 0, "Is it circle_yes or square_no?"),
            new QueryNode(2, 0, "Done, it was a no."),
            new QueryNode(3, 1, "It was a circle. Now is it an apple or a pear?"),
            new QueryNode(4, 1, "Done, it's a square."),
            new QueryNode(5, 3, "Done, it was an apple."),
            new QueryNode(6, 3, "Done, it was a pear.")
        };
    }
}