using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager1 : MonoBehaviour
{
    public TMP_InputField inputField;

    public void SaveUsername() 
    {
        string inputText = inputField.text; //Save username
        if (inputText == "")
        {
            dataPersistence.sharedInstance.username = inputField.placeholder.GetComponent<TextMeshProUGUI>().text;
        }
        else {
            dataPersistence.sharedInstance.username = inputText;
        }
    }
}
