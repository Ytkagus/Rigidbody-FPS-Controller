using UnityEngine;
using TMPro;

public class Version : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<TMP_Text>().text = Application.version;
    }
}
