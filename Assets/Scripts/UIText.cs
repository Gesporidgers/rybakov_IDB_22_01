using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    public Text rrrr;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int i;
    // Update is called once per frame
    void Update()
    {
        string txt = i.ToString();
        i++;
        rrrr.text = txt;
    }
}
