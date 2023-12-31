﻿using RoadmapExercises.LinkedLists.Nodes;

namespace RoadmapExercises.LinkedLists
{
    //https://leetcode.com/problems/merge-two-sorted-lists/
    public static class MergeTwoSortedLists
    {
        //Iterative
        public static ListNode Logic1(ListNode list1, ListNode list2)
        {
            var dummy = new ListNode();
            var tail = dummy;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }

                tail = tail.next;
            }

            if (list1 != null)
                tail.next = list1;
            else if (list2 != null)
                tail.next = list2;

            return dummy.next;
        }

        //recursive sol
        public static ListNode Logic2(ListNode list1, ListNode list2)
        {
            if(list1 == null)
                return list2;
            if(list2 == null)
                return list1;

            if (list1.val <= list2.val)
            { 
                list1.next = Logic2(list1.next, list2);
                return list1;
            }
            else 
            {
                list2.next = Logic2(list1, list2.next);
                return list2;
            }
        }
    }
}