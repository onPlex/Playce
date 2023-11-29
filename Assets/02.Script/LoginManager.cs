using System.Collections;
using UnityEngine;



//https://www.figma.com/file/XJT7J0mSKfOz3GQXd4jNiA/Untitled?type=design&node-id=0-1&mode=design&t=MXaB6IF2XZsAWTTB-0
public class LoginManager : MonoBehaviour
{

    #region UI_Object
    [SerializeField]
    GameObject RegisterPanel;

    [SerializeField]
    GameObject MainPanel;

    [SerializeField]
    GameObject GroupLogin;

    [SerializeField]
    GameObject GroupSignin;
    #endregion

    private bool isLogined; //check user has been logined
    private bool hasPlayRecord;

    [SerializeField]
    UserInfo userInfo;

    //Singleton
    public static LoginManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

        if (userInfo == null)
        {
            userInfo = GetComponent<UserInfo>();
        }
    }

    //PlayerPrefs


    private void Start()
    {
        //Check has played record
        StartCoroutine(IAppStartCheck()); //Login Process, Check for Essential Checklist When App starts    
    }



    //Check this is the first time as using app
    private void CheckHasPlayRecord()
    {
        if (PlayerPrefs.HasKey("loginID"))
        {
            Debug.Log("CheckHasPlayRecord - O - LoginID");
            hasPlayRecord = true;
        }
        else
        {
            Debug.Log("CheckHasPlayRecord - X - LoginID");
            hasPlayRecord = false;
        }
    }

    private void HasPlayRecord()
    {
        if (hasPlayRecord)
        {
            Debug.Log("HasPlayRecord - TryLogIn");
            TryLogIn();
        }
        else
        {
            Debug.Log("hasPlayRecord - GroupLogin(true)");
            GroupLogin.SetActive(true);
        }
    }

    #region Login
    IEnumerator IAppStartCheck()
    {
        Debug.Log("IAppStartCheck");
        ValueInitialize(); //initialize Values 
        yield return null;
        CheckHasPlayRecord();
        yield return null;
        HasPlayRecord();
    }

    //TODO : SNS Login , Google, Apple , Meta
    public void TryLogIn()
    {
        StartCoroutine(ILogIn());
    }

    IEnumerator ILogIn()
    {
        //TODO :: GET USER INFO
        //wait for userinfo to sync
        //

        yield return null;
        LoginSuccess();
    }
    public void LoginSuccess()
    {
        Debug.Log("LoginSuccess");
        isLogined = true;
        RegisterPanel.SetActive(false);
        MainPanel.SetActive(true);

        PlayerPrefs.SetString("loginID", userInfo.GetValidationKey());
    }

    public void LoginFailed()
    {
        //TODO :: Pop up message for Login Fail
    }

    private void LogOut()
    {
        isLogined = false;
        RegisterPanel.SetActive(true);
        GroupLogin.SetActive(true);
        MainPanel.SetActive(false);
        PlayerPrefs.DeleteAll();
    }
    #endregion

    //for Value Clear When App Start
    private void ValueInitialize()
    {
        Debug.Log("ValueInitialize");
        isLogined = false;
        hasPlayRecord = false;
        MainPanel.SetActive(false);
        RegisterPanel.SetActive(true);
        GroupLogin.SetActive(true);
        GroupSignin.SetActive(false);
    }

    #region UI - Button Action
    public void OnClickSignUp() //RegisterPanel-GroupLogin-SubgroupSignIn-Button
    {
        GroupLogin.SetActive(false);
        GroupSignin.SetActive(true);
    }

    public void OnClickLogOut()
    {
        LogOut();
    }

    public void OnClieckQuitSingIn() //RegisterPanel-GroupSignIn-Group_SignInfo_Inputfield-Btns-Cancle_BackGround
    {
        GroupLogin.SetActive(true);
        GroupSignin.SetActive(false);
    }
    #endregion

    #region TEST
    public void TryLogIn_TEST()
    {
        StartCoroutine(ILogIn());
    }

    IEnumerator ILogIn_TEST()
    {
        //TODO :: GET USER INFO
        //wait for userinfo to sync
        
        userInfo.SetValidationKey("Test Player");
        yield return null;
        LoginSuccess();
    }

    #endregion
}
