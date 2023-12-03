using UnityEngine.SceneManagement;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    public bool gameHasEnded = false;

    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
       
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
