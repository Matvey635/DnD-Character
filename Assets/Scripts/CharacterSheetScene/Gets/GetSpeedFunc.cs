using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSpeedFunc : MonoBehaviour
{
    public GameObject GetSheet;
    public GameObject InputField;
    public GameObject SpeedField;

    public void SetSpeed()
    {
        SpeedField.GetComponent<Text>().text = InputField.GetComponent<InputField>().text;
        DataHandler.Data.Speed = int.Parse(InputField.GetComponent<InputField>().text);
        GetSheet.SetActive(false);
        InputField.GetComponent<InputField>().text = "";

    }

    public void Cancel()
    {
        GetSheet.SetActive(false);
    }
}
