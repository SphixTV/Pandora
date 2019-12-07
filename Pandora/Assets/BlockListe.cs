using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockListe : MonoBehaviour
{
    [SerializeField]
    private List<BlockList> blockliste;
    



    public GameObject GetObject(int ID)
    {
        for (int i = 0; i < blockliste.Count; i++)
        {

            if (blockliste[i].blockID == ID)
            {
                return blockliste[i].BlockObject;
            }
        }
        return null;
    }
    public string GetName(int ID)
    {
        for (int i = 0; i < blockliste.Count; i++)
        {

            if (blockliste[i].blockID == ID)
            {
                return blockliste[i].BlockName;
            }
        }
        return null;
    }

    public int GetID(string Name)
    {
        for (int i = 0; i < blockliste.Count; i++)
        {

            if (blockliste[i].BlockName == Name)
            {
                return blockliste[i].blockID;
            }
        }
        return 0;
    }





}

[System.Serializable]

public class BlockList
{
    [SerializeField]
    public string BlockName;
    [SerializeField]
    public int blockID;
    [SerializeField]
    public GameObject BlockObject;
   





}




