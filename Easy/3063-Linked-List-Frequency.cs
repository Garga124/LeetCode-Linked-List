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
    public ListNode FrequenciesOfElements(ListNode head) {
        Dictionary<int, int> linkedListValues = new Dictionary<int, int>();
        ListNode currentHead = head;
        while(head != null)
        {
            if(linkedListValues.ContainsKey(head.val))
            {
                linkedListValues[head.val] = linkedListValues[head.val] +1; 
            }
            else
            {
                linkedListValues[head.val] =1;
            }
            head = head.next;

        }
        ListNode prev = null;
        ListNode curr = null;
        foreach(var item in linkedListValues)
        {
            if(prev == null)
            {
                prev = new ListNode(item.Value);
                curr = prev;
            }else
            {
                prev.next = new ListNode(item.Value);
                prev = prev.next;
            }

        }
        return curr;
        
        
    }
}




