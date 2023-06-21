using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Set : MonoBehaviour
{

    public float rotate_x;
    public float rotate_y;
    public float rotate_z;
    public float pos_x;
    public float pos_y;
    public float pos_z;
    private Rigidbody rigid;
    public bool isIn;

    // Start is called before the first frame update
    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        isInProblem();
    }
    // Update is called once per frame

    //blockSet.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    public void isInProblem()
    {
        isIn = false;
        foreach (Transform child in transform)
        {
            if (child.gameObject.tag == "Block")
            {
                if(child.gameObject.layer == 15)
                {
                    isIn = true;
                }

            }
            
        }

        if (isIn == false)
        {
            rigid.useGravity = true;
            rigid.constraints = RigidbodyConstraints.None;

        }
    }

}
