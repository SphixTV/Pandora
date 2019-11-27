using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    [SerializeField]
    private List<Block> blocklist;
    Block block;
    public BlockListe blockListe;
    Block blockNew;

    public void PlaceBlock(Block block, GameObject gameObject, Transform child)
    {
        
        Debug.Log("LOL");
        for (int i = 0; i < blocklist.Count; i++)
        {
          
            if(block.BlockPos != blocklist[i].BlockPos)
            {
                if (block.BlockPos.y + 1 == blocklist[i].BlockPos.y)
                {
                    blocklist[i].nabourTop = true;
                }
                else if (block.BlockPos.y - 1 == blocklist[i].BlockPos.y)
                {
                    blocklist[i].nabourBottom = true;
                }
                else if (block.BlockPos.x + 1 == blocklist[i].BlockPos.x)
                {
                    blocklist[i].nabourRight = true;
                }
                else if (block.BlockPos.x - 1 == blocklist[i].BlockPos.x)
                {
                    blocklist[i].nabourLeft = true;
                }
                else
                {
                    blocklist[i].nabourTop = false;
                    blocklist[i].nabourBottom = false;
                    blocklist[i].nabourRight = false;
                    blocklist[i].nabourLeft = false;
                }
            }
            
            
        }

        blockNew = null;
        blockNew.blockID = block.blockID;
        blockNew.BlockName = block.BlockName;
        blockNew.BlockPos = block.BlockPos;
        blocklist.Add(blockNew);
        
       
        Instantiate(gameObject, block.BlockPos, Quaternion.identity, child);

    }
}
[System.Serializable]

public class Block
{
    [SerializeField]
    public string BlockName;
    [SerializeField]
    public int blockID;
    [SerializeField]
    public Vector3 BlockPos;
    [SerializeField]
    public bool nabourTop;
    [SerializeField]
    public bool nabourBottom;
    [SerializeField]
    public bool nabourLeft;
    [SerializeField]
    public bool nabourRight;
 

    


}

