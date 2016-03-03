using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RainbowChicken2016
{
    public class PelletList
    {
        Pellet headPointer = null;
        Pellet tailPointer = null;

        Rectangle boundsRectangle;

        //==============================================================================
        // Ctor
        //==============================================================================
        public PelletList(Rectangle boundsRectangle)
        {
            this.boundsRectangle = boundsRectangle;
        }

        //==============================================================================
        // Add Pellet newPellet at the end of the list.
        //==============================================================================
        public void addPellet(Pellet newPellet)
        {
            if (headPointer == null)
            {
                headPointer = newPellet;
                tailPointer = newPellet;
            }
            else
            {
                //add at the end of the list
                tailPointer.Next = newPellet;
                //change the tailpointer to point at the new end of the list
                tailPointer = newPellet;
            }
        }

        //==============================================================================
        // Walk the list, counting the number of Pellet. Return the count.
        //==============================================================================
        public int Count()
        {
            int count = 0;
            //point the nodewalker to the first entry in the list
            Pellet nodewalker = headPointer;

            
            while (nodewalker != null)
            {
                count++;
                nodewalker = nodewalker.Next;
            }
            return count;
        }

        //==============================================================================
        // Walk the list, calling the Move() method of each Pellet
        //==============================================================================
        public void Move()
        {
            Pellet nodewalker = headPointer;
            while (nodewalker != null)
            {
                nodewalker.Move();
                nodewalker = nodewalker.Next;
            }
        }

        //==============================================================================
        // Walk the list. For each Pellet, call TestOutOfBounds, passing boundsRectangle.
        // For each node that is out of bounds, set its IsAlive property to false.
        //==============================================================================
        public void KillOutOfBounds()
        {
            Pellet nodewalker = headPointer;
            //walk the list
            while (nodewalker != null)
            {
                //find all pellets outside of the screen
                if (nodewalker.TestOutOfBounds(boundsRectangle))
                {
                    //set isAlive so it will be delted next time DeleteNotALive() is called
                    nodewalker.IsAlive = false;
                }
                nodewalker = nodewalker.Next;
            }
        }

        //==============================================================================
        // Delete the argument Pellet pelletToDelete from the list.
        // Be careful to maintain the integrity of the list, including
        // headPointer and tailPointer.
        //==============================================================================
        public void DeleteOne(Pellet pelletToDelete)
        {
            Pellet nodewalker = headPointer;
            //first off check if the headpointer is being deleted
            if (pelletToDelete == headPointer)
            {
                //check to see if there is the list is actually empty
                if (pelletToDelete == tailPointer && headPointer == tailPointer)
                {
                    //if the list is empty set it them both to null
                    headPointer = null;
                    tailPointer = null;
                }
                else
                {
                    //if the list is not empty set the headpointer to the next node in the list
                    headPointer = pelletToDelete.Next;
                }
            }
            else
            {
                Pellet nodeWalker = headPointer;
                //walk the list until the node to be deleted is found
                while (nodeWalker.Next != pelletToDelete)
                { 
                    nodeWalker = nodeWalker.Next; 
                }
                //sets the nodewalker.next to the one after the pelletToDelete, if it is the final node it sets it to null
                nodeWalker.Next = pelletToDelete.Next;
                              
                //checks to see if the tail pointer needs to be moved
                if (tailPointer == pelletToDelete)
                {
                    tailPointer = nodeWalker;
                }
            }
        }

        //==============================================================================
        // Walk the list, deleting all nodes whose IsAlive propoerty is false
        //==============================================================================
        public void DeleteNotAlive()
        {
            Pellet nodewalker = headPointer;
            //walk the list
            while (nodewalker != null)
            {
                //delete each node that isAlive is set to false
                if (nodewalker.IsAlive == false)
                {
                    DeleteOne(nodewalker);
                }
                //move to the next node
                nodewalker = nodewalker.Next;
            }
        }

        //==============================================================================
        // Walk the list, calling each node's Draw method
        //==============================================================================
        public void Draw()
        {
            Pellet nodeWalker = headPointer;

            //walk the list
            while (nodeWalker != null)
            {
                //call each draw method
                nodeWalker.Draw();
                //move on to next node
                nodeWalker = nodeWalker.Next;
            }
        }
    }
}
