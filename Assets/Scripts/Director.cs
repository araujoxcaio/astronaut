using UnityEngine;

public class Director : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOver;

    private Astronaut astronaut;

    private void Start()
    {
        this.astronaut = GameObject.FindObjectOfType<Astronaut>();
    }

    public void GameOver() {
        Time.timeScale = 0;
        this.gameOver.SetActive(true);
    }

    public void Restart() {
        Debug.Log("Clicou");
        this.gameOver.SetActive(false);
        Time.timeScale = 1;
        this.astronaut.Restart();
        this.DestroyAssets();
    }

    private void DestroyAssets() {
        Rock[] rocks = GameObject.FindObjectsOfType<Rock>();

        foreach (Rock rock in rocks) { 
            rock.Destroy();
        }
    }

    public void OnMouseDown()
    {
        Debug.Log("Clicou");
        this.gameOver.SetActive(false);
        Time.timeScale = 1;
        this.astronaut.Restart();
        this.DestroyAssets();
    }

}
