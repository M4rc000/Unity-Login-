using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class LoginScript : MonoBehaviour
{
    // Start is called before the first frame update

    public string URL;
    public TMPro.TMP_InputField username;
    public TMPro.TMP_InputField password;
    public TextMeshProUGUI Status;
    string vText;

    WWW php_login;
    WWWForm php_form;

    void Start() {  }

    // Update is called once per frame
    void Update() {  }

    IEnumerator PostLogin()
    {
        php_form = new WWWForm();
        php_form.AddField("unity_user", username.text);
        php_form.AddField("unity_pass", password.text);

        php_login = new WWW(URL, php_form);
        yield return php_login;
        vText = php_login.text;
        if (vText != "" && vText != "what the f are you doing?")
        {
            Status.text = "";
            Status.text = "Welcome, " + vText;
        }
    }

    public void FusionLogin(){
        StartCoroutine(PostLogin());
    }
    
}
