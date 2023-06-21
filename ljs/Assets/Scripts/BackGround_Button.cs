using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class BackGround_Button : MonoBehaviour
{
    public Camera Camera;
    public Button button;
    public Material skyboxMaterial1;
    void Awake()
    {
        if (button != null)
        {
            button.onClick.AddListener(Change_Background);
        }
    }



    void Change_Background()
    {
        Camera.skyboxMaterial = skyboxMaterial1;
        Camera.GetComponent<Skybox>().material = skyboxMaterial1;
    }

}
