using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int StagePoint = 0;
    public int goal_Point;
    public Image[] UI_Image;
    public TMP_Text UI_Point;
    public TMP_Text UI_GoalPoint;
    public Button Next_Button;
    public Button Main_Button;
    public string Next_Scene_name;
    public Button End_Button;
    void Awake()
    {
        UI_Point.text = StagePoint.ToString();
        UI_GoalPoint.text = goal_Point.ToString();
        if (Next_Button != null)
        {
            Next_Button.onClick.AddListener(Next_Stage);
        }
        Invoke("SetActivebutton", 5);
    }

    private void FixedUpdate()
    {
        UI_Point.text = StagePoint.ToString();
        if (StagePoint == goal_Point)
        {
            UI_Image[0].gameObject.SetActive(false);
            UI_Image[1].gameObject.SetActive(true);
        }
    }

    void Next_Stage()
    {
        SceneManager.LoadScene(Next_Scene_name);
    }

    void SetActivebutton()
    {
        End_Button.gameObject.SetActive(true);
    }

}