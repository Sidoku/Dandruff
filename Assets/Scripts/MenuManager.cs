using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject controlPanal;
    public GameObject MenuPanel;
    // Start is called before the first frame update
    void Start()
    {
        controlPanal.SetActive(false);  
    }



   public void onClickControls()
    {
        MenuPanel.SetActive(false);
        controlPanal.SetActive(true);
    }

    public void BackButton()
    {
        MenuPanel.SetActive(true);
        controlPanal.SetActive(false);
    }

    public void OnStartClick()
    {

        SceneManager.LoadScene("Playground");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
