using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Called at first frame
    public void Start()
    {
        // Limit framerate so we don't melt GPUs trying to render 500 frames of Audi 7 in 1 second
        Application.targetFrameRate = 60;
    }
    // Load scene at buildIndex parameter
    public void Load(int buildIndex)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        string sceneName = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(buildIndex));
        string currentSceneName = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(currentScene));

        Debug.Log($"Loading scene {buildIndex}:{sceneName}, leaving scene {currentScene}:{currentSceneName}");

        ProgressData.PreviousScene = currentScene;
        SceneManager.LoadScene(buildIndex);
    }

    // Load previous scene
    public void LoadPrevious()
    {
        Load(ProgressData.PreviousScene);
    }
}
