using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Main : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI text;
    string mes = "default message\n(Editor Only!)";
    // Start is called before the first frame update
    void Start()
    {
        GetParameter();
        text.text = mes;
    }

    void GetParameter()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        string url = Application.absoluteURL;
        mes = url;
#endif
    }
}
