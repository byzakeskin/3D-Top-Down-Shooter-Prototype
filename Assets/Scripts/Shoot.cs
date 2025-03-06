using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab; //mermi objesinin tanýmý
    public Transform firePoint; //ateþ edilecek nokta
    public float bulletSpeed = 20f; //mermi hýzý
    public float bulletLifeTime = 2f; //merminin sahne üzerinde bulunma süresi
    public Animator animator; // ateþ etme animasyonu için animator tanýmý
    public AudioSource audioSource; // ateþ etme sesi için ses kaynaðý tanýmý
    public GameObject shootEffect; // ateþ etme efekti 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))//farede sol týk ile ateþ etme
        {
            ShootBullet();//ateþ etme fonksiyonunun tanýmý
        }
    }

    void ShootBullet()
    {
        if (animator != null)
        {
            animator.SetBool("shoot", true);
            Invoke("StopShootAnimation", 0.1f);//Invoke >> seçilen metodun belli bir süre sonra çaðrýlmasýný saðlama
            audioSource.Play();
        }

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);//mermi için spawner

        Rigidbody rb = bullet.GetComponent<Rigidbody>();//mermi için fizik
        rb.velocity = firePoint.forward * bulletSpeed;//merminin ileri doðru ateþlenmesi

        Destroy(bullet, bulletLifeTime);//oyunumun biriken mermilerden dolayý kasmamasý için mermilerin sahne üzerinden silinmesi 

        if (shootEffect != null)
        {
            GameObject Shooting = Instantiate(shootEffect, firePoint.position, firePoint.rotation);//ateþ etme efekti için spawner
        }
    }

    void StopShootAnimation()
    {
        if (animator != null)//ateþ edilmiyorsa animasyonu durdur
        {
            animator.SetBool("shoot", false);
        }
    }
}
