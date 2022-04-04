using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmenucontroller : MonoBehaviour
{
    [SerializeField]
    private GameObject _helpMenu;
    [SerializeField]
    private GameObject _optionMenu;
    [SerializeField]
    private GameObject[] _panels;
    [SerializeField]
    private GameObject[] _mainMenuBtn;
    private void Awake()
    {
        _panels = GameObject.FindGameObjectsWithTag("Panelmenu");
        _mainMenuBtn = GameObject.FindGameObjectsWithTag("Mainmenubutton");
        foreach (GameObject panels in _panels)
            panels.SetActive(false);
    }
    public void ClosePanel(Button _btn)
    {
        _btn.gameObject.transform.parent.gameObject.SetActive(false);
        foreach (GameObject b in _mainMenuBtn)
            b.SetActive(true);
    }
    public void OpenPanel(Button _btn)
    {
        _btn.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        foreach (GameObject b in _mainMenuBtn)
            if(b != _btn.gameObject)
            b.SetActive(false);
    }
    
    public void LoadScene()
    {
        SceneManager.LoadScene("Scene1",LoadSceneMode.Single);
    }
    public void quitGame()
    {
        Application.Quit();
    }

}
