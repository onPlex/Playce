using UnityEngine;

public class VideoClipManager : MonoBehaviour
{
    public string[] videoURLname;

    public void PlayVideoByURL(int urlIndex)
    {
        string currentUrl = videoURLname[urlIndex];

        if(currentUrl != "")
        {
            Application.OpenURL(currentUrl);
        }
    }
}
