using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarManeger : MonoBehaviour
{
    bool Active = true;
    public void SetVisible()
    {
        this.gameObject.SetActive(!Active);
        Active = !Active;
        
    }
}

