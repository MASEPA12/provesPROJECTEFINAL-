using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 


public class GAMEmanager : MonoBehaviour
{
    public GameObject panelPAUSE;

    //dark mode
    public Material darkMaodeMaterial;
    public TextMeshPro txt1;

    private void Start()
    {
        darkMaodeMaterial.color = Color.white;
        txt1.fontSharedMaterial.color = Color.white;
    }
    public void ChangeSceneBttn(int a)
    {
        SceneManager.LoadScene(a);
    }

    public void PauseBttn(bool toggle)
    {
        panelPAUSE.SetActive(toggle);
    }

    public void DarkModeToggle(GameObject panel)
    {
        //panel.GetComponent<Image>= Color.white;
    }
}
