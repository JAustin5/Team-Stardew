using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    [SerializeField] //Allows for value changes in editor, anything directly under (no line break) will show
    public LoginManager logMan;
    public RegisterManager regMan;
    public bool rightLogin = false;
    public bool validRegister = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void attemptLogin()
    {
        rightLogin = logMan.getLoginValidity(); //Eventually change to call loginCheck func
        if (rightLogin)
        {
            sceneChange("MainScene");
        }
        else
        {
            Debug.Log("Wrong Login Info Given!!!"); //Outputs to consol instead of screen.
        }

    }

    public void attemptRigter()
    {
        validRegister = regMan.getRegValidity(); //Eventually change to call RegCheck func
        if (validRegister)
        {
            sceneChange("Login");
        }
        else
        {
            Debug.Log("Register Info not Valid!!!"); //Outputs to consol instead of screen.
        }
    }

    public void SwitchToLogin()
    {
        sceneChange("Login");
    }

    public void SwitchToRegister()
    {
        sceneChange("Register");
    }

    public void sceneChange(string name)
    {
        SceneManager.LoadScene(name);
    }
}
