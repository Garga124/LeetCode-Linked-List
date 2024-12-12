/**
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummyHead = new ListNode(-1);
        ListNode l3 = dummyHead;
        int carry = 0;
        while(l2 != null || l1 != null)
        {
            int sum = 0;
            if(l1 == null)
            {
                sum += sum + l2.val + carry;
                l2 = l2.next;
            }
            else if (l2 == null)
            {
                sum += sum + l1.val + carry;
                l1 = l1.next;
            }
            else
            {
                sum += sum + l1.val + l2.val + carry;
                l1 = l1.next;
                l2 = l2.next;
            }
            int num = sum %10;
            l3.next = new ListNode(num);
            carry = sum/10;
            l3 = l3.next;
        }
        if(carry == 1)
        {
            l3.next = new ListNode(carry);
            l3 = l3.next;
        }
        return dummyHead.next;
    }
}