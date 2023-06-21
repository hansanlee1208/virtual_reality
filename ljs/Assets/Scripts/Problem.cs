using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem : MonoBehaviour
{
    public GameManager gameManager;
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }




    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            meshRenderer.materials[0].color = new Color(0, 0, 1, 0.5f);
            gameManager.StagePoint += 1;

            
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            meshRenderer.materials[0].color = new Color(1, 1, 1, 0.1f);
            gameManager.StagePoint -= 1;

        }
    }
}
