using HmsPlugin;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loginHMS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HMSAccountManager.Instance.SignIn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
