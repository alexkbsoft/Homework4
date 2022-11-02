using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Comparator : MonoBehaviour
{
    public TMP_InputField operand1;
    public TMP_InputField operand2;
    public TextMeshProUGUI resultText;

    public void Compare() {
      var op1 = float.Parse(operand1.text);
      var op2 = float.Parse(operand2.text);

      if (op1 > op2)
      {
        resultText.text = operand1.text;
      } else if (op2 > op1) {
        resultText.text = operand2.text;
      } else {
        resultText.text = "Равны";
      }
    }

}
