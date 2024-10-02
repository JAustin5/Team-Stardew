using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoginManager : MonoBehaviour
{
    [SerializeField]
    public TMP_InputField userNameInputField;
    [SerializeField]
    public TMP_InputField passwordInputField;

    public bool ValidEmailDomain(string email)
    {
        string[] emailDomain = email.Split('@');
        string domain = emailDomain[1];

        string[] validDomains = { "g.cofc.edu", "cofc.edu" };

        foreach (string validDomain in validDomains)
        {
            if (domain == validDomain)
            {
                return true;
            }
        }

        feedbackText.text = "Please use a College of Charleston email address.";
        return false;
    }

    public void SubmitLogin()
    {
        string username = userNameInputField.text;
        string password = passwordInputField.text;

        //Checking 
        Debug.Log("USERNAME: " + username);
        Debug.Log("PASSWORD: " + password);

        string email = userNameInputField.text;

        if (ValidEmailDomain(email))
        {
            feedbackText.text = "Valid email. Proceeding with login...";
        }
        else
        {
            feedbackText.text = "Invalid email domain.";
        }
    }

    private string CheckLoginInfo(string username, string password)
    {
        string returnString = "";

        if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
        {
            returnString = "All fields are empty";
        }
        if (string.IsNullOrEmpty(username))
        {
            returnString = "Username was field empty";
        }
        else if (string.IsNullOrEmpty(password))
        {
            returnString = "Password field was empty";
        }
        else
        {
            returnString = "";
        }
        Debug.Log("RETURN STRING: " + returnString);
        return returnString;
    }
}
