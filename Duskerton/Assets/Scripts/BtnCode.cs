using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnCode : MonoBehaviour
{
    public Button UiBtn;
    public string scene;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = UiBtn.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
