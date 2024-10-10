using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    public Text msg;
    public bool validRegister = false; //USED IN BTN CLASS

    // creation of account email address domains
    private string adminDomain = "@cofc.edu";
    private string studentDomain = "@g.cofc.edu";

    // USED FOR LOGIN BTN CLASS
    public bool correctInfo = false;

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

    public void Login()
    {
        string email = loginEmailField.text;
        string password = loginPassField.text;

        //if (!IsValidEmailDomain(email))
        //{
        //    msg.text = "Email must be from a valid CofC email address";
        //    return;
        //}

        if (PlayerPrefs.HasKey(email + "_password"))
        {
            string savedPassword = PlayerPrefs.GetString(email + "_password");
            string userRole = PlayerPrefs.GetString(email + "_role");

            if (savedPassword == password)
            {
                msg.text = "Login successful!";
                if (userRole == "Admin")
                {
                    SceneManager.LoadScene("AdminLocationHandle");
                }
                else
                {
                    SceneManager.LoadScene("MainScene");
                }
            }
            else
            {
                msg.text = "Incorrect password. Try again.";
            }
        }
        else
        {
            msg.text = "Email not found. Please register or try again.";
        }
    }

    public bool getLoginValidity()
    {
        return correctInfo;
    }


    public void Register()
    {
        string name = registerNameField.text;
        string email = registerEmailField.text;
        string password = registerPassField.text;
        string confirmPassword = registerConfirmPassField.text;
        string role = "Student";

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
        {
            msg.text = "Please fill in all fields.";
            return;
        }

        // password confirmation
        if (password != confirmPassword)
        {
            msg.text = "Registration Failed: Passwords do not match. Try again?";
            return;
        }

        // email check if admin or student
        if (email.EndsWith(adminDomain))
        {
            role = "Admin";
        }
        else if (email.EndsWith(studentDomain))
        {
            role = "Student";
        }
        else
        {
            msg.text = "Email address is not allowed for registration. Please try again with a valid CofC email address.";
            return;
        }

        if (PlayerPrefs.HasKey(email))
        {
            msg.text = "Email already exists. Try again with a different CofC email.";
        }
        else
        {
            PlayerPrefs.SetString(email + "_password", password);
            PlayerPrefs.SetString(email + "_role", role);
            msg.text = "Regstration successful as " + role + "!";
        }
    }

    public bool getRegValidity() //ADD BOOL CHANGE IN REGISTER ATTEMPT
    {
        return validRegister;
    }

    //// Start is called before the first frame update
    //void Start()
    //{
    //    ShowLogin();
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
