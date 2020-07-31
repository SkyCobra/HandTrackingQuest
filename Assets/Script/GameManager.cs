using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScreenManager screen;
    public GameObject drawer;
    private Animator drawerAnimator;
    private string codeValid = "4213";
    private bool valid = false;


    private void Start()
    {
        drawerAnimator = drawer.GetComponent<Animator>();
    }

    public void Log(string message)
    {
        Debug.Log(message);
    }

    public void EnterCode(string code)
    {
        screen.AddCode(code);
        string codeFull = screen.GetText();
        if (codeFull.Length >= 4)
            CheckCode(codeFull);
    }

    private void CheckCode(string code)
    {
        if (code == codeValid)
        {
            Debug.Log("Code Valide");
            screen.ValidText();
            drawerAnimator.SetBool("State", true);
            Debug.Log("Porte Ouverte");
            valid = true;
        }
        else if (!valid)
        {
            screen.WrongText();
        }
    }

    public void ChangeFuse()
    {
        screen.FinalText();
    }
}
