using UnityEngine;

public class FireAreaTrigger : MonoBehaviour
{
    public firecontroller firecontroller;
    public GameObject fireFX;

    private void OnTriggerEnter(Collider other)
    {
        // 必须是锅盖
        if (!other.CompareTag("pot lid")) return;

        // 获取锅盖控制器
        PotLidController lid = other.GetComponent<PotLidController>();

        // 如果锅盖不存在控制脚本，退出
        if (lid == null) return;

        // 如果锅盖正在被拿着，不灭火
        if (lid.isHeld)
        {
            Debug.Log("Lid held - do not extinguish.");
            return;
        }

        // 🔥 正式灭火
        fireFX.SetActive(false);


        // 通知火焰控制器
        firecontroller.FireExtinguished();

        Debug.Log("Fire extinguished with lid placement.");
    }
}