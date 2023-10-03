using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    float moving;
    // Start is called before the first frame update
    void Start()
    {
        moving = Time.deltaTime *0.5f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        moving = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = new Vector3(0, 0, moving);
        gameObject.transform.Translate(pos);
    }
}
