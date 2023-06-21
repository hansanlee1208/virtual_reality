using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Collider : MonoBehaviour
{
    // Start is called before the first frame update

    public Block_Set blockSet;
    


    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Problem")
        {
            transform.gameObject.layer = 14;
        }
    }
    
}
