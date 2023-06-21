using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class BackGround_Button2 : MonoBehaviour
{
    public Camera Camera;
    public Button button;
    public Material skyboxMaterial2;
    void Awake()
    {
        if (button != null)
        {
            button.onClick.AddListener(Change_Background);
        }
    }



    void Change_Background()
    {
        Camera.skyboxMaterial = skyboxMaterial2;
        Camera.GetComponent<Skybox>().material = skyboxMaterial2;
    }

}
