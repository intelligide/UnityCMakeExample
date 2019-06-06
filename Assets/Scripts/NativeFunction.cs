using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class NativeFunction : MonoBehaviour
{

    [DllImport("Hello")]
    private static extern int ReturnNumber();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ReturnNumber());
    }
}
