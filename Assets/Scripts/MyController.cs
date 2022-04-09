using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Line.LineSDK;

public class MyController : MonoBehaviour
{
    public void LoginButtonClicked()
    {
        var scopes = new string[] { "profile", "openid" };
        LineSDK.Instance.Login(scopes, result => {
            result.Match(
                value => {
                    Debug.Log("Login OK. User display name: " + value.UserProfile.DisplayName);
                },
                error => {
                    Debug.Log("Login failed, reason: " + error.Message);
                }
            );
        });
    }
}