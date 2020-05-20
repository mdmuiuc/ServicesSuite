namespace Services
{
    public class Tree
    {
        public Tree LeftSubtree { get; }
        public Tree RightSubtree { get; }
        public int Value { get; }

        public Tree(Tree leftSubtree, Tree rightSubtree, int value)
        {
            LeftSubtree = leftSubtree;
            RightSubtree = rightSubtree;
            Value = value;
        }
    }
}
