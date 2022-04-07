using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject aboutPage;
    public GameObject backButton;
    //Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void enterAR()
    {
        SceneManager.LoadScene("AR view");
        
    }
    public void about()
    {
        button1.SetActive(false);
        button2.SetActive(false);
        aboutPage.SetActive(true);
        backButton.SetActive(true);
    }
    public void back()
    {
        aboutPage.SetActive(false);
        backButton.SetActive(false);
        button1.SetActive(true);
        button2.SetActive(true);
        
    }
}
