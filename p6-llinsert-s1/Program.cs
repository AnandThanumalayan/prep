using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    class SinglyLinkedListNode {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData) {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep) {
        while (node != null) {
            Console.Write(node.data);

            node = node.next;

            if (node != null) {
                Console.Write(sep);
            }
        }
    }

class Result
{

    /*
     * Complete the 'insertNodeAtPosition' function below.
     *
     * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
     * The function accepts following parameters:
     *  1. INTEGER_SINGLY_LINKED_LIST llist
     *  2. INTEGER data
     *  3. INTEGER position
     */

    /*
     * For your reference:
     *
     * SinglyLinkedListNode
     * {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */

    public static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
    {
        int ctr = 0;
        bool positionReached = false;
        
        while (llist != null) {
            if (ctr == position -1){
                positionReached = true;

                llist.next.data = data;
                llist.next.next = llist.next.next.next;
            }
            if(ctr == position){
                nodeToInsert.next = llist;
            }

        llist = llist.next;
        }
    }

    public static SinglyLinkedListNode insertNodeAtPosition_v1(SinglyLinkedListNode llist, int data, int position)
    {
        int ctr = 0;
        SinglyLinkedListNode nodeToInsert = new SinglyLinkedListNode(data);
        SinglyLinkedListNode head = new SinglyLinkedListNode(0);
        
        if (llist == null) {
            head = nodeToInsert;
        }
        else {
            while (llist != null) {
                if (ctr == position -1){
                    llist.next = nodeToInsert;
                }
                if(ctr == position){
                    nodeToInsert.next = llist;
                }

            llist = llist.next;
            }
        }
        return head;
    }

}

    static void Main(string[] args) {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        SinglyLinkedList llist = new SinglyLinkedList();

        int llistCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < llistCount; i++) {
            int llistItem = Convert.ToInt32(Console.ReadLine());
            llist.InsertNode(llistItem);
        }

        int data = Convert.ToInt32(Console.ReadLine());

        int position = Convert.ToInt32(Console.ReadLine());

        // SinglyLinkedListNode llist_head = insertNodeAtPosition_v1(llist.head, data, position);
        SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);
        

        PrintSinglyLinkedList(llist_head, " ");
        Console.WriteLine();

        // textWriter.Flush();
        // textWriter.Close();
    }
}
