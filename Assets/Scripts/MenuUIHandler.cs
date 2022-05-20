using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bestScore;
    [SerializeField] public TMP_InputField userName;

    public static MenuUIHandler Instance;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        userName = this.GetComponentInChildren<TMP_InputField>();
        userName.text = "";
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
