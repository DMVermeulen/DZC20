using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
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
