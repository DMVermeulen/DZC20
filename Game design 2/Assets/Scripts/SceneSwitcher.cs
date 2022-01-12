using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    //[Tooltip("In-game UI that shows current highlighted scene.")]
    //[SerializeField] private TextMeshProUGUI text;

    // The selected scene
    private int scene;
    private string sceneName;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SelectScene(int buildIndex)
    {
        string pathToScene = SceneUtility.GetScenePathByBuildIndex(buildIndex);
        sceneName = System.IO.Path.GetFileNameWithoutExtension(pathToScene);

        Debug.Log($"Selecting scene at index {buildIndex}: {sceneName}");
        
        scene = buildIndex;

        //text.text = sceneName;
    }

    // Load scene at buildIndex parameter
    public void Load(int buildIndex)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        Debug.Log($"Loading scene {buildIndex}, leaving scene {currentScene}");

        ProgressData.PreviousScene = currentScene;
        SceneManager.LoadScene(buildIndex);
    }

    // Load previous scene
    public void LoadPrevious()
    {
        Load(ProgressData.PreviousScene);
    }
}
