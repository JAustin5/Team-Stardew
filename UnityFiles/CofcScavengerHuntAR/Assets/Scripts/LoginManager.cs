using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    public InputField emailInput;
    public InputField passwordInput;
    public Text msg;

    public bool correctInfo = false;

    //private string[] validDomains = { "@g.cofc.edu", "@cofc.edu" };

    //private bool IsValidEmailDomain(string email)
    //{
    //    foreach (string domain in validDomains)
    //    {
    //        if (email.Contains(domain))
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}

    public void Login()
    {
        string email = emailInput.text;
        string password = passwordInput.text;

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

    //HEY MAKE SURE LOGIN FUNCTION USES THIS BOOL TO MAKE BUTTON WORK
   public bool getLoginValidity()
    {
        return correctInfo;
    }
    
}
