DFS using a Stack for iterative approach. Preorder: root, left, right.
Pop off stack, check current nodes value. Add values to overall sum if between low and high values.
If current nodes value is > low, add left child. If current nodes value is < high, add right child. See drawing of BST to visualize this logic. Left child will always be lower in value, right child will always be higher in value.