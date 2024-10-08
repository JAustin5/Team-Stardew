using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginRegisterManager : MonoBehaviour
{
    // Reference to login and register canvases
    public GameObject loginCanvas;
    public GameObject registerCanvas;

    // Login fields
    public InputField loginEmailField;
    public InputField loginPassField;

    // Register fields
    public InputField registerNameField;
    public InputField registerEmailField;
    public InputField registerPassField;
    public InputField registerConfirmPassField;
    
    
    public void ShowRegister()
    {
        loginCanvas.SetActive(false);
        registerCanvas.SetActive(true);
    }

    public void ShowLogin()
    {
        loginCanvas.SetActive(true);
        registerCanvas.SetActive(false);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        ShowLogin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
