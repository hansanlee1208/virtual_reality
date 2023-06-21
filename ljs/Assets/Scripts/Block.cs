using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class Block : MonoBehaviour
{
    public Block_Set blockSet;
    private Rigidbody rigid;
    private SphereCollider spherecollider;
    private BoxCollider boxcollider;
    // Start is called before the first frame update
    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        spherecollider = GetComponent<SphereCollider>();
        boxcollider = GetComponent<BoxCollider>();
    }
    // Update is called once per frame


    public void SetLayerRecursively(Transform transform, int layer_number)
    {
        transform.gameObject.layer = layer_number;
        foreach (Transform child in transform)
        {
            child.gameObject.layer = layer_number;
        }
    }



    

    Vector3 dir = new Vector3(0, 0, 0);
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Problem")
        {
            transform.gameObject.layer = 15;
            blockSet.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            blockSet.transform.GetComponent<Rigidbody>().useGravity = false;
            
            float diff_x = transform.position.x - transform.parent.position.x;
            float diff_y = transform.position.y - transform.parent.position.y;
            float diff_z = transform.position.z - transform.parent.position.z;

            float target_x = collision.gameObject.transform.position.x - diff_x;
            float target_y = collision.gameObject.transform.position.y - diff_y;
            float target_z = collision.gameObject.transform.position.z - diff_z;


            blockSet.transform.position = new Vector3(target_x, target_y, target_z);
            
            

        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Problem")
        {
            transform.gameObject.layer = 14;
        }
        
    }
    

}
