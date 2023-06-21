using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Main_Button : MonoBehaviour
{
    
    public Button Next_Button;
    public string Next_Scene_name;

    void Awake()
    {
        if (Next_Button != null)
        {
            Next_Button.onClick.AddListener(Next_Stage);
        }
    }

    private void FixedUpdate()
    {
        
    }

    void Next_Stage()
    {
        SceneManager.LoadScene(Next_Scene_name);
    }
}
