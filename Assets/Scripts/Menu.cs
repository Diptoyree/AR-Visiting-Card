using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public string Mail, Address, Phone, Web;

    // Jump to mail
    public void GotoMail()
    {
        Application.OpenURL("mailto:" + Mail);
    }

    // jump to browser - google map
    public void GotoAddress()
    {
        Application.OpenURL(Address);
    }


    // jump to call
    public void GotoPhone()
    {
        Application.OpenURL("tel://" + Phone);
    }


    // jump to websire
    public void GotoWebsite()
    {
        Application.OpenURL(Web);
    }

}
