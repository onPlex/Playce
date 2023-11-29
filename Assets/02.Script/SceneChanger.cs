using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string homeSceneName = "Home";
    public string arSceneName = "AR";

    public void OnClickSceneChangeToAR()
    {
        SceneManager.LoadSceneAsync(arSceneName);
    }

    public void OnClickSceneChangeToHome()
    {
        SceneManager.LoadSceneAsync(homeSceneName);
    }
}
