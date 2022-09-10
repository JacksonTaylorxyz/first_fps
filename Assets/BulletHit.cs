using UnityEngine;

public class BulletHit : MonoBehaviour
{
    void onCollisionEnter() {
        gameObject.SetActive(false);
    }
}
