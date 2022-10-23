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
            // these are the question nodes to be used to create the binary tree on the QueryPage
            // Note when creating the question nodes, the yes answers must be the last child.
            new QueryNode(1, null, "Is the animal a Canine? (yes for dog, no for cat)"),
            new QueryNode(2, 1, commonQuery.isYoungerThan6Months),  // first child of 1 is no answer
            new QueryNode(3, 1, commonQuery.isLargeBreed),          // last child of 1 is yes answer
            new QueryNode(4, 3, commonQuery.isYoungerThan6Months),  // and so on...
            new QueryNode(5, 3, commonQuery.longerThan2Weeks),
            new QueryNode(6, 2, commonQuery.seenIn3Months),
            new QueryNode(7, 2, commonQuery.longerThan2Weeks),
            new QueryNode(8, 7, commonQuery.wcNearby),
            new QueryNode(9, 7, commonQuery.reweigh),
            new QueryNode(10, 5, commonQuery.wcNearby),
            new QueryNode(11, 5, commonQuery.reweigh),
            new QueryNode(12, 4, commonQuery.seenIn3Months),
            new QueryNode(13, 4, commonQuery.longerThan2Weeks),
            new QueryNode(14, 6, commonQuery.wcNearby),
            new QueryNode(15, 6, commonQuery.reweigh),
            new QueryNode(16, 14, commonQuery.ccNearby),
            new QueryNode(17, 14, commonQuery.takeToWC),
            new QueryNode(18, 8, commonQuery.ccNearby),
            new QueryNode(19, 8, commonQuery.takeToWC),
            new QueryNode(20, 13, commonQuery.wcNearby),
            new QueryNode(21, 13, commonQuery.reweigh),
            new QueryNode(22, 10, commonQuery.ccNearby),
            new QueryNode(23, 10, commonQuery.takeToWC),
            new QueryNode(24, 12, commonQuery.wcNearby),
            new QueryNode(25, 12, commonQuery.reweigh),
            new QueryNode(26, 16, commonQuery.isUrgent),
            new QueryNode(27, 16, commonQuery.takeToCC),
            new QueryNode(28, 18, commonQuery.isUrgent),
            new QueryNode(29, 18, commonQuery.takeToCC),
            new QueryNode(30, 20, commonQuery.ccNearby),
            new QueryNode(31, 20, commonQuery.takeToWC),
            new QueryNode(32, 22, commonQuery.isUrgent),
            new QueryNode(33, 22, commonQuery.takeToCC),
            new QueryNode(34, 24, commonQuery.ccNearby),
            new QueryNode(35, 24, commonQuery.takeToWC),
            new QueryNode(36, 26, commonQuery.roundwormTx),
            new QueryNode(37, 26, commonQuery.roundwormER),
            new QueryNode(38, 28, commonQuery.roundwormTx),
            new QueryNode(39, 28, commonQuery.roundwormER),
            new QueryNode(40, 30, commonQuery.isUrgent),
            new QueryNode(41, 30, commonQuery.takeToCC),
            new QueryNode(42, 32, commonQuery.roundwormTx),
            new QueryNode(43, 32, commonQuery.roundwormER),
            new QueryNode(44, 34, commonQuery.isUrgent),
            new QueryNode(45, 34, commonQuery.takeToCC),
            new QueryNode(46, 40, commonQuery.roundwormTx),
            new QueryNode(47, 40, commonQuery.roundwormER),
            new QueryNode(48, 44, commonQuery.roundwormTx),
            new QueryNode(49, 44, commonQuery.roundwormER)
        };
    }
}