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
    public string GameResult(ListNode head) {
        int OddIndexedScore = 0;
        int evenIndexedScore = 0;
        while(head !=null && head.next !=null)
        {
            if(head.val>head.next.val)
            {
                evenIndexedScore++;
            }else if(head.val<head.next.val)
            {
                OddIndexedScore++;
            }
            else
            {
                evenIndexedScore++;
                OddIndexedScore++;
            }
            head = head.next.next;
        }
        if(OddIndexedScore>evenIndexedScore)
        return "Odd";
        else if(evenIndexedScore>OddIndexedScore)
        return "Even";
        else 
        return "Tie";
        
    }
}