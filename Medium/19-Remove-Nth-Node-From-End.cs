/**
* Time complexity: O(n)

* Auxiliary Space : O(1) using constant space
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummyHead = new ListNode(-1);
        dummyHead.next = head;
        ListNode p1 = dummyHead;
        ListNode p2 = dummyHead;
        //Mode the p1 to total -n position which is to the nth place
        for(int i =0;i<n;i++)
        {
            p1 = p1.next;
        }   
    
         
        //Now Momve p1 and p2 together, when p1 hits the end then p2 will reach at the position from where the next node need to be deleted
        while(p1?.next!=null)
        {
            p1 = p1.next;
            p2 = p2.next;
        }
  
        p2.next = p2.next.next;
        return dummyHead.next;

    }
}

//Traverse full list to calculate the number of nodes
//DeleteNode Position = totalNodes - n (5-2)
//Change the pointer of position 3 to next.next