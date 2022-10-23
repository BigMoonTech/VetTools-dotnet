using BinaryTreeStructures.Nodes;

namespace VetToolsApp.Viewmodels.Queries;

public class RoundwormQueryModel
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

    public RoundwormQueryModel()
    {
        CommonQuery commonQuery = new CommonQuery();
        queryNodes = new List<QueryNode>
        {
            new QueryNode(0, null, "Is the animal a Canine? (yes for dog, no for cat)"),
            new QueryNode(1, 0, commonQuery.isYoungerThan6Months),                               // no option
            new QueryNode(2, 0, commonQuery.isLargeBreed),                                  // yes option
            new QueryNode(3, 1, commonQuery.longerThan2Weeks),
            new QueryNode(4, 1, commonQuery.longerThan2Weeks),
            new QueryNode(5, 3, commonQuery.isYoungerThan6Months),
            new QueryNode(6, 3, commonQuery.reweigh)
        };
    }
}