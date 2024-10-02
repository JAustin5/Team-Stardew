using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RegisterManager : MonoBehaviour
{
    public InputField emailField;
    public InputField passwordField;
    public Text msg;

    // creation of account email address domains
    private string adminDomain = "@cofc.edu";
    private string studentDomain = "@g.cofc.edu";

    public void Register()
    {
        string email = emailField.text;
        string password = passwordField.text;
        string role = "Student";

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            msg.text = "Please fill in all fields.";
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
}
