using UnityEngine;
using Unity.VisualScripting;

public class Turret : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    Transform bulletSpawnPos;
    GameObject tempBullet;
    float timer;
    bool canShoot;

    private void OnTriggerEnter(Collider other){
        if (!other.CompareTag("Ground")) {
            //transform.LookAt(other.transform.position);
            if (canShoot) {
                tempBullet = Instantiate(bulletPrefab, bulletSpawnPos.position, transform.rotation);
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
        transform.Rotate(new Vector3(0f, 1f , 0f), 20*Time.deltaTime);
        if (Input.GetKey(KeyCode.RightControl)) {
            tempBullet = Instantiate(bulletPrefab, bulletSpawnPos.position, transform.rotation);
            Destroy(tempBullet, 5f);
        }
    }
}
