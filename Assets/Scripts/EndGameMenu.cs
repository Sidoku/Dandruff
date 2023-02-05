using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

using System.Threading;
using Unity.VisualScripting;
using UnityEngine.InputSystem;

namespace StarterAssets
{
    [RequireComponent(typeof(CharacterController))]
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
    [RequireComponent(typeof(PlayerInput))]
#endif
public class EndGameMenu : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI scoreBoard;
    ThirdPersonController va = new ThirdPersonController();

    // Start is called before the first frame update
    void Start()
    {
        scoreBoard.text = "5";

    }

    // Update is called once per frame
    void Update()
    {
        //scoreBoard.text = va.playerScore;

    }

    public void OnStartClick()
    {

        SceneManager.LoadScene("Menu");
    }

    public void OnCLickQuit()
    {
        Application.Quit();
    }
}
}
