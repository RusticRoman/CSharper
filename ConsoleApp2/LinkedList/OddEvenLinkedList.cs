namespace ConsoleApp2;

/**
 *
 *
    328. Odd Even Linked List (Medium)

    Given the head of a singly linked list, group all the nodes with odd indices together
    followed by the nodes with even indices, and return the reordered list.
    The first node is considered odd, and the second node is even, and so on.
    Note that the relative order inside both the even and odd groups should remain as it was in the input.
    You must solve the problem in O(1) extra space complexity and O(n) time complexity.
 */
public class OddEvenLinkedList
{
    public ListNode? OddEvenList(ListNode? head)
    {
        if (head == null || head.next == null) return head;
        ListNode odd = head;
        ListNode even = head.next;
        ListNode evenHead = even;

        while (even != null && even.next != null)
        {
            odd.next = even.next;
            odd = odd.next;
            even.next = odd.next;
            even = even.next;
        }

        // Connect the end of odd indexed list to the head of even indexed list
        odd.next = evenHead;
        return head;
    }
}

/**
    To group all nodes with odd indices together followed by those with even indices in a singly linked list, while ensuring O(n) time complexity and O(1) space complexity, you can use two pointers—one for odd-indexed nodes and one for even-indexed nodes. This way, you traverse the list once, rearranging links as you go.

    Here's how to approach it:

    Strategy:
        Initialize Pointers: Use two pointers odd and even to keep track of the last node in the current odd-indexed and even-indexed linked lists, respectively. Additionally, use a pointer evenHead to mark the start of the even-indexed list.
        Separate Odd and Even Nodes: Traverse the list with a loop. Adjust the next pointers of the odd and even nodes so that all odd-indexed nodes are linked together followed by even-indexed nodes.
        Connect Odd and Even Lists: After the separation, link the end of the odd list to the head of the even list.

    Explanation:
        Initialization: odd starts at the first node (head) and even starts at the second node. evenHead keeps a reference to the start of the even-indexed list.
        Traversal and Link Adjustment: Iterate while there are at least two more nodes ahead of even. For each pair, adjust the odd and even pointers so that odd links to the next odd node (skipping over even) and similarly for even.
        Connecting Lists: Once the end of the list is reached (either even is null or even.next is null), link the last node of the odd list to the head of the even list.
*/