using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {
        
          //Definition for singly-linked list.
         public class ListNode {
              public int val;
              public ListNode next;
              public ListNode(int val=0, ListNode next=null) {
                  this.val = val;
                  this.next = next;
             }
          }
         
        public class Solution
        {
            public ListNode ReverseList(ListNode head)
            {
                ListNode list = null;
                ListNode curr = head;
                while (curr != null)
                {
                    ListNode next = curr.next;
                    curr.next = list;
                    list = curr;
                    curr = next;
                }
                return list;
            }
        }
    }
}
