using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    [SerializeField]
    private List<Block> blocklist;
    Block block;
    public BlockListe blockListe;
   


    public void PlaceBlock(Block block, int BlockID, Transform child)
    {
        if (blocklist.Contains(block))
        {
            Debug.Log("YA");
        }
        else
        {
            
            blocklist.Add (block);

            
            var Object = Instantiate(blockListe.GetObject(BlockID), block.BlockPos, Quaternion.identity, child);
            Object.name = "Block at " + block.BlockPos;

            for (int i = 0; i < blocklist.Count; i++)
            {

                if (block.BlockPos.y == blocklist[i].BlockPos.y && block.BlockPos.x -1 == blocklist[i].BlockPos.x )
                {
                    blocklist[i].nabourLeft = true;
                    block.nabourRight = true;
                }
                if (block.BlockPos.y == blocklist[i].BlockPos.y && block.BlockPos.x + 1 == blocklist[i].BlockPos.x)
                {
                    blocklist[i].nabourRight = true;
                    block.nabourLeft = true;
                }
                if (block.BlockPos.x  == blocklist[i].BlockPos.x && block.BlockPos.y - 1 == blocklist[i].BlockPos.y)
                {
                    blocklist[i].nabourBottom = true;
                    block.nabourTop = true;
                }
                if (block.BlockPos.x  == blocklist[i].BlockPos.x && block.BlockPos.y + 1 == blocklist[i].BlockPos.y)
                {
                    blocklist[i].nabourTop = true;
                    block.nabourBottom = true;
                }




            }
        }
            

        
        

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


