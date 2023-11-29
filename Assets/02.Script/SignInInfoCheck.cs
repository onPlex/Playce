using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SignInInfoCheck : MonoBehaviour
{
    [Header("InputField")]
    [SerializeField]
    TMP_InputField firstName;
    [SerializeField]
    TMP_InputField lastName;
    [SerializeField]
    TMP_InputField email;
    [SerializeField]
    TMP_InputField pw;
    [SerializeField]
    TMP_InputField pwConfirm;
    [Header("Buttons")]
    [SerializeField]
    Button confirm;
    [SerializeField]
    Image checkImage;

    // [SerializeField] is just for debug
    //Check the correct information
    [SerializeField]
    private bool isCorrectPassword;
    [SerializeField]
    private bool isCorrectEmail;
    [SerializeField]
    private bool isCorrectfirstName;
    [SerializeField]
    private bool isCorrectlastName;

    private string _firstNameData;
    private string _lastNameData;
    private string _eMailData;

    private void Start()
    {
        isCorrectPassword = false;
        confirm.interactable = false;
        checkImage.color = Color.gray;
    }





    #region UI-Linked

    //all inputfield has when finish editing
    public void ConfirmButtonActive()
    {
        if (isCorrectPassword && isCorrectEmail && isCorrectfirstName && isCorrectlastName)
        {
            confirm.interactable = true;
            checkImage.color = new Color(0.2078431f, 0.9921569f, 0.5019608f, 1);
        }
    }

    public void OnFinishCheckPassword() //GroupSignIn-Inputfield_PW
    {
        if (pw.text != "")
        {
            //TODO :: check Length & has special Character & combine Character And numbers
        }
        else
        {
            //TODO:: Pop Up message for input text
        }
    }

    public void OnFinishCheckPasswordConfirm() //GroupSignIn-Inputfield_PWconfirm
    {
        if (pw.text == pwConfirm.text)
        {
            isCorrectPassword = true;
        }
        else
        {
            isCorrectPassword = false;
        }
    }

    public void OnFinishCheckFirstName() //GroupSignIn- Name -Inputfield_FirstName
    {
        if (firstName.text != "")
        {
            _firstNameData = firstName.text;
            isCorrectfirstName = true;
        }
        else
        {
            isCorrectfirstName = false;
            //TODO:: Pop Up message for input text
        }
    }
    public void OnFinishCheckLastName() //GroupSignIn- Name -Inputfield_LastName
    {
        if (lastName.text != "")
        {
            _lastNameData = lastName.text;
            isCorrectlastName = true;
        }
        else
        {
            isCorrectlastName = false;
            //TODO:: Pop Up message for input text
        }
    }
    public void OnFinishCheckEmail() //GroupSignIn - Inputfield_Email
    {
        if (email.text != "")
        {
            _eMailData = email.text;
            isCorrectEmail = true;
        }
        else
        {
            isCorrectEmail = false;
            //TODO:: Pop Up message for input text
        }
    }

    public void OnClickConfirm()
    {
        CreateUser();
    }
    #endregion

    public void CreateUser()
    {
        //TODO :: 
    }
}
