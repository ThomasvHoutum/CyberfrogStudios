using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    [SerializeField] int SceneNumber;
    public Button UIButton;
    private void Start()
    {
        Button btn = UIButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneNumber);
    }
}
