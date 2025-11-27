using UnityEngine;

public class successUIController : MonoBehaviour
{
    public GameObject successUIObject;

    public void ShowSuccess()
    {
        successUIObject.SetActive(true);
    }
}