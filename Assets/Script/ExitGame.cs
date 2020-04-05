using UnityEngine;

public class ExitGame : MonoBehaviour
{

    public void exitGame(int exitGameBool)
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
