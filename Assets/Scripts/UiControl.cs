using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiControl : MonoBehaviour
{
    [SerializeField] private  Button nextButton;
    [SerializeField] private Button prevButton;
    //[SerializeField] private Button arButton;
    [SerializeField] private Button backButton;
    //[SerializeField] private Button clearButton;


    [SerializeField] private GameObject[] images;

    [SerializeField] private int totalImages = 3;
    [SerializeField] public int counter = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void nextPress()
    {
        if (counter < totalImages-1)
        {
            counter++;
            images[counter - 1].SetActive(false);
            images[counter].SetActive(true);
        }
        if(counter == totalImages-1)
        {
            counter = 0;
            images[totalImages - 1].SetActive(false);
            images[counter].SetActive(true);
        }    


    }
    public void prevPress()
    {
        if (counter > 0)
        {
            counter--;
            images[counter + 1].SetActive(false);
            images[counter].SetActive(true);
        }
        if (counter == 0)
        {
            counter = totalImages-1;
            images[0].SetActive(false);
            images[counter].SetActive(true);
        }
    }
    public void back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
