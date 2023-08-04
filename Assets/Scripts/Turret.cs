using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;
    GameObject tempBullet;
    float timer;
    bool canShoot;

    private void OnTriggerEnter(Collider other){
        if (!other.CompareTag("Ground")) {
            transform.LookAt(other.transform.position);
            if (canShoot) {
                tempBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                canShoot = false;
            }
            Destroy(tempBullet, 5f);
        }
    }

    private void Update() {
        timer += Time.deltaTime;
        if(timer >= 5f) {
            canShoot = true;
            timer = 0f;
        }
    }
}
