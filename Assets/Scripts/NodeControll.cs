using System.Collections;
using System.Collections.Generic;
using System.Threading;

using UnityEngine;

public class NodeControll:MonoBehaviour
{
    public DoubleLinkList<NodeControll> listAdjacentsNodes = new DoubleLinkList<NodeControll>();

    public void AddAdjacentNode (NodeControll node)
    {
        listAdjacentsNodes.InsertAtEnd (node);
    }

   /* public NodeControll GetAdjacentNode()
    {
        return listAdjacentsNodes.GetValueAtPosition(Random.Range(0, listAdjacentsNodes.count));
    }
   */
}
