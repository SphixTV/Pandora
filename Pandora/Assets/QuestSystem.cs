using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class QuestSystem : MonoBehaviour
{
    public float typeSpeed;
    public string[] Sentence;
    public TextMeshProUGUI text;
    int x;
  
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TypeText());
        
    }

    // Update is called once per frame
    public void Next()
    {
        if(x < Sentence.Length)
        {
            text.text = "";
            x++;
            StartCoroutine(TypeText());
        }
        
    }
    IEnumerator TypeText()
    {
        
            for (int i = 0; i < Sentence[x].Length; i++)
            {
                text.text += Sentence[x][i];
                yield return new WaitForSeconds(typeSpeed);
            }
          
        
        
       
    }
}
