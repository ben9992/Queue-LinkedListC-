using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   class LinkedList
{
  private Node first;
  private Node last;
  private int listCount = 0;
 
public LinkedList() { }
public void AddItem(int data)//we will pass in an integer to the AddItem function enter in the linkedlist
{
  Node newItem = new Node(data);
  if (first == null)
  {
    first = newItem;
    last = first;
  }
  else
  {
    Node traverse = first;
    while (traverse.next != null)//go through the linked list to find the last node of the list and add a pointer to the new item
    {
      traverse = traverse.next;
    }
    traverse.next = newItem;//adds the new item and makes the last part of the list point the new item
    last = traverse.next;
  }
 listCount++;
}
public void RemoveFirst()//we have RemoveFirst() function to remove the first node
{
 
   Node newFirst = first.next;//set a node to equal the next node in the list
   first = null;//set the current first node to equal null
   first = newFirst;//set the next node to be the first
   listCount--;
   DisplayList();
}
public void RemoveLast()//we also have a RemoveLast() function to remove the last node
{
 
  int index = 1;
  //if we are removing from the back, traverse the list until the last node = traversal and set to null
  Node traversal = first;
  while (traversal.next != null)
  {
    traversal = traversal.next;
    index++;
    if (index == listCount - 1)
    {
       break;
        //break from the loop when the index reaches length-1
        //we do this so that the penultimate item in the list becomes the new last node
    }
  }
  last = traversal;//set last to equal the current traversal node (penultimate)
  traversal.next = null;//set the next node to null
  listCount--;//decrement the number of items inside the list
  DisplayList();//re-write the list
}
public void RemoveItem(int removeValue)
{//the RemoveItem function takes an int parameter, so that it finds something to delete
 
//to remove an item...
//traverse the list
//set a node called nextnext
//assign the nextnext to the current traversal node.next.next
//it looks like this:
//node->current->next->nextnext
//if we delete a middle node
//we look to the next nodes data
//if it checks out, set to null
//set the current node.next (traversal) to nextnext
//it will link the current traversal node to nextnext
//like so: A->B->tranversal(current)->traversal.next (middle)->traversal.next.next (nextnext)
//becomes: A->B->Current->nextnext
 
  Node traversal = first;//a node to traverse the list
  Node nextnext = null;
  while (traversal.next != null)
  {
    nextnext = traversal.next.next;
    if (traversal.next.data == removeValue)
    {
      traversal.next = null;
      traversal.next = nextnext;
      break;
    }
    else
    {
      traversal = traversal.next;
    }
  }
 
  listCount--;//decrement the number of list items
  DisplayList();//re-write the list
}
public void DisplayList()
{
    Node current = first;
    while (current != null)
    {
      Console.WriteLine("{0} ", current.data);
      current = current.next;
 
       if (current == null)
       {
         return;
       }
    }
}
        }
    }


