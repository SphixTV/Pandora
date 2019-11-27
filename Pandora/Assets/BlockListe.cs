using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockListe : MonoBehaviour
{
    [SerializeField]
    private List<Liste> liste;


    GameObject GetObject;


}
[System.Serializable]
public class Liste
{
    [SerializeField]
    private string BlockName;
    [SerializeField]
    private int blockID;
    [SerializeField]
    private GameObject BlockObject;
}