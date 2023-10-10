using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MirrorworldSDK.Models;
using System;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float m_RotationAngle = 0.0f;
    [SerializeField] GameObject m_MirrorObject;

    private void Start()
    {
        Debug.Log($"[LOGINHANDLER] MONO Start?");
    }

    public void OnStartLogin()
    {
        //Moved the Init and StartLogin calls to a button press.
//        MirrorSDK.InitSDK("mw_i5icAfiPIST6Nbz0b2wAbJbGBNZelCU9F4d", m_MirrorObject, MirrorworldSDK.MirrorChain.Solana, false, MirrorworldSDK.MirrorEnv.Devnet);
        Debug.Log($"[LOGINHANDLER] OnStartLogin?");
        MirrorSDK.StartLogin(LoginHandler);
    }

    void Update()
    {
        gameObject.transform.rotation = Quaternion.AngleAxis(m_RotationAngle, gameObject.transform.up);
        m_RotationAngle = m_RotationAngle + 1;
    }

    private void LoginHandler(LoginResponse _LoginResponse)
    {
        Debug.Log($"[LOGINHANDLER] Logged in?");
        Debug.Log($"[LOGINHANDLER] {_LoginResponse.user.email}");
    }
}
