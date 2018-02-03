using UnityEngine;
using System.Collections;

public class EndGameScript : MonoBehaviour {
public GUIText endGameText;
    private bool bIsGameOver;
    private const int buttonWidth = 120;
    private const int buttonHeight = 60;

    void Start () {
        endGameText.text ="hujj";
        bIsGameOver =false;
    }
   


    void OnTriggerEnter2D(Collider2D other)
    {
       if (other.tag == "Player")
        {
            if (GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2), (1 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Retry!"))
            {
                // Recharge le niveau
                Application.LoadLevel("Scene1");
            }

            if (GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight), "Back to menu"))
            {
                // Retourne au menu
                Application.LoadLevel("Menu");
            }
        }
    }

    public void EndGame()
    {
        endGameText.text = "Congratulation Dante but Beatrice is in another Castle";
        bIsGameOver = true;
    }
}