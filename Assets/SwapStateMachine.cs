using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapStateMachine : MonoBehaviour
{
    [SerializeField]
    private GameObject currentScreen;

    public void showNewScreen(GameObject newScreen) {
      if (currentScreen != null)
      {
        currentScreen.SetActive(false);
        currentScreen = newScreen;
        currentScreen.SetActive(true);
      }
    }
}
