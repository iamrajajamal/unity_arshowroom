using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static string CurrentSelectedCar = "myLamboConvert";
    public static GameController Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Quit() =>
        Application.Quit();

    public void ChangeLevel(string sceneName) => 
        SceneManager.LoadScene(sceneName);
}
