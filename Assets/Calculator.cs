using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculator : MonoBehaviour
{
    public TMP_InputField operand1;
    public TMP_InputField operand2;
    public TextMeshProUGUI resultText;

    public void Plus() {
      var result = float.Parse(operand1.text) + float.Parse(operand2.text);
      resultText.text = result.ToString();
    }

    public void Minus() {
      var result = float.Parse(operand1.text) - float.Parse(operand2.text);
      resultText.text = result.ToString();
    }

    public void Mult() {
      var result = float.Parse(operand1.text) * float.Parse(operand2.text);
      resultText.text = result.ToString();
    }

    public void Div() {
      var result = float.Parse(operand1.text) / float.Parse(operand2.text);
      resultText.text = result.ToString();
    }
}
