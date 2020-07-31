using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    public GameObject ScreenObject;
    public GameObject Instruction;
    private Text screenText;
    private Text CheckingText;

    private void Start()
    {
        screenText = ScreenObject.GetComponent<Text>();
        CheckingText = Instruction.GetComponent<Text>();
        CheckingText.text = "Veuillez tapez le code 4213";
    }

    public void SetText(string text)
    {
        screenText.text = text;
    }

    public void AddCode(string text)
    {
        screenText.text += text;
    }

    public string GetText()
    {
        return screenText.text;
    }

    public void ValidText()
    {
        CheckingText.text = "Veuillez prendre la clef à pipe";
        screenText.enabled = false;
    }

    public void WrongText()
    {
        CheckingText.text = "Erreur Veuillez tapez le code 4213";
        screenText.text = "";
    }

    public void FinalText()
    {
        CheckingText.text = "Merci d'avoir enlevé le fusible grillé";
    }
}
