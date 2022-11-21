using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    [SerializeField] Button UIButton;
    void Start()
    {
        Button btn = UIButton.GetComponent<Button>();
        btn.onClick.AddListener(Quitting);
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    void Quitting()
    {
        Application.Quit();
    }
}
