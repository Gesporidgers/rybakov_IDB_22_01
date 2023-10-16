using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            //cube = GameObject.Find("Cube_spec");
            inst();
        }
    }
    public void inst()
    {
        for(int i=0; i < 10; i++)
        {
            Vector3 nv = new Vector3(i, 2, 0);
            Instantiate(gameObject, nv,gameObject.transform.rotation);
        }
    }
}
