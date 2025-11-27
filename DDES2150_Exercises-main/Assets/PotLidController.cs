using UnityEngine;

public class PotLidController : MonoBehaviour
{
    public bool isHeld = false;

    private Rigidbody rb;
    private Collider col;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
    }

    // 拿起时调用
    public void OnLidPickedUp()
    {
        isHeld = true;
        rb.isKinematic = true;
        col.enabled = false;

        Debug.Log("🔥 Lid picked up");
    }

    // 放下时调用
    public void OnLidDropped()
    {
        isHeld = false;
        rb.isKinematic = false;
        col.enabled = true;

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        Debug.Log("🟢 Lid dropped (isHeld = false)");
    }
}