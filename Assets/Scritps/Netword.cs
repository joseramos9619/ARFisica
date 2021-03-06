using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Netword : MonoBehaviour
{
    public void Guardar(string user, string email, string pass, Action<Response> response)
    {
        StartCoroutine(CO_Guardar(user, email, pass, response));
    }

    private IEnumerator CO_Guardar(string user, string email, string pass, Action<Response> response)
    {
        WWWForm form = new WWWForm();
        form.AddField("user", user);
        form.AddField("email", email);
        form.AddField("pass", pass);
        WWW w = new WWW("https://developmentontime.000webhostapp.com/User/Guardar.php", form);

        yield return w;
 
         response(JsonUtility.FromJson<Response>(w.text));
    }

    public void Validar(string user, string pass, Action<Response> response)
    {
        StartCoroutine(CO_Validar(user, pass, response));
    }

    private IEnumerator CO_Validar(string user, string pass, Action<Response> response)
    {
        WWWForm form = new WWWForm();
        form.AddField("user", user);
        form.AddField("pass", pass);
        WWW w = new WWW("https://developmentontime.000webhostapp.com/User/Validar.php", form);

        yield return w;
        
         response(JsonUtility.FromJson<Response>(w.text));
    }
}
[Serializable]
public class Response
{
    public bool done = false;
    public string mens = "";
}