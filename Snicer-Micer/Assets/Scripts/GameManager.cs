using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverUI;
    public GameObject ESCMenu;
    public AudioSource GameOverSound;

    void Start()
    {

    }


    void Update()
    {
        ESCMenuStart();
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
        GameOverSound.Play();
    }

    public void ESCMenuStart()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            ESCMenu.SetActive(true);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
