using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    
    public static Material skyboxMaterial;
    
    void Awake()
    {
        // 머티리얼 등록
        RenderSettings.skybox = skyboxMaterial;
    }

}
