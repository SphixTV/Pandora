using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemListe : MonoBehaviour
{
    [SerializeField]
    private List<ItemList> itemliste;




    public GameObject GetObject(int ID)
    {
        for (int i = 0; i < itemliste.Count; i++)
        {

            if (itemliste[i].blockID == ID)
            {
                return itemliste[i].BlockObject;
            }
        }
        return null;
    }
    public string GetName(int ID)
    {
        for (int i = 0; i < itemliste.Count; i++)
        {

            if (itemliste[i].blockID == ID)
            {
                return itemliste[i].BlockName;
            }
        }
        return null;
    }

    public int GetID(string Name)
    {
        for (int i = 0; i < itemliste.Count; i++)
        {

            if (itemliste[i].BlockName == Name)
            {
                return itemliste[i].blockID;
            }


        }
        return 0;
    }





}

[System.Serializable]

public class ItemList
{
    [SerializeField]
    public string BlockName;
    [SerializeField]
    public int blockID;
    [SerializeField]
    public GameObject BlockObject;






}


