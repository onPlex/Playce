using TMPro;
using UnityEngine;


public class ARTargetInfo : MonoBehaviour
{
    [Tooltip("0 = Name, 1 = Category, 2= SingatureDishInfo, 3= OpeninghoursInfo, 4 = ReviewsInfo")]
    public string[] infos;

    [SerializeField]
    TextMeshProUGUI Name;

    [SerializeField]
    TextMeshProUGUI Category;

    [SerializeField]
    TextMeshProUGUI SingatureDishInfo;

    [SerializeField]
    TextMeshProUGUI OpeninghoursInfo;

    [SerializeField]
    TextMeshProUGUI ReviewsInfo;


    private void Start()
    {
        InitData();
    }

    void InitData()
    {
        if (infos[0] != null) Name.text = infos[0];
        else { Debug.Log("Need to Fill Text"); }
        if (infos[1] != null) Category.text = infos[1];
        else { Debug.Log("Need to Fill Text"); }
        if (infos[2] != null) SingatureDishInfo.text = infos[2];
        else { Debug.Log("Need to Fill Text"); }
        if (infos[3] != null) OpeninghoursInfo.text = infos[3];
        else { Debug.Log("Need to Fill Text"); }
        if (infos[4] != null) ReviewsInfo.text = infos[4];
        else { Debug.Log("Need to Fill Text"); }
    }

}
