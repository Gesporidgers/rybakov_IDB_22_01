using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    //cube = GameObject.Find("Cube_spec");
        //    inst();
        //}
    }
    public void inst()
    {
        int moveX = 0;
        int moveY = 2;
        for(int i=0; i < 5; i++)
        {
            moveX = 0;
            for (int j = 0; j < 5; j++)
            {
                Vector3 nv = new Vector3(moveX, moveY, 0);
                Instantiate(gameObject, nv, gameObject.transform.rotation);
                moveX += 2;
            }
            moveY += 2;
        }
    }
}
