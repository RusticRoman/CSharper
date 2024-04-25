namespace ConsoleApp2;

/**
 * Definition for singly-linked list.
 */

public class DeleteMiddleNodeLinkedList
{
    public ListNode? DeleteMiddle(ListNode? head) {
        if (head == null || head.next == null) {
            return null;  // If list is empty or has only one element, return null
        }
        ListNode slow = head;
        ListNode fast = head;
        ListNode ? prev = null;  // To keep track of the node before slow
        // Find the middle node
        while (fast != null && fast.next != null) {
            prev = slow;            // Keep track of the node before slow
            slow = slow.next;       // Slow moves one step
            fast = fast.next.next;  // Fast moves two steps
        }
        // Remove the middle node
        if (prev != null) {
            prev.next = slow.next;  // Bypass the middle node
        }
        return head;
    }
}