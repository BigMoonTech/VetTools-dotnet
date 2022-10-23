using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeStructures.Nodes
{
    public class QueryNode
    {
        public QueryNode(int id, int? parentId, string question)
        {
            Id = id;
            ParentId = parentId;
            Question = question;
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Question { get; set; }


        public override string ToString()
        {
            return Question;
        }
    }
}
