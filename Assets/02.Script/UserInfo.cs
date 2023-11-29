using UnityEngine;

public class UserInfo : MonoBehaviour
{
    [SerializeField]
    string validationKey; //key for check Firebase key 
    //[SerializeField]
    //string firstname;  //user info - firstname
    //[SerializeField]
    //string lastname;  //user info - lastname
    //[SerializeField]
    //string email;  //user info - emailname
    //string password;  //for auto login

    public string  GetValidationKey()
    {
        string val = validationKey;
        return val;
    }

    public void SetValidationKey(string newValue)
    {
        validationKey = newValue;
    }
}
