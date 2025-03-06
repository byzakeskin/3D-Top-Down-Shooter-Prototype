using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab; //mermi objesinin tan�m�
    public Transform firePoint; //ate� edilecek nokta
    public float bulletSpeed = 20f; //mermi h�z�
    public float bulletLifeTime = 2f; //merminin sahne �zerinde bulunma s�resi
    public Animator animator; // ate� etme animasyonu i�in animator tan�m�
    public AudioSource audioSource; // ate� etme sesi i�in ses kayna�� tan�m�
    public GameObject shootEffect; // ate� etme efekti 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))//farede sol t�k ile ate� etme
        {
            ShootBullet();//ate� etme fonksiyonunun tan�m�
        }
    }

    void ShootBullet()
    {
        if (animator != null)
        {
            animator.SetBool("shoot", true);
            Invoke("StopShootAnimation", 0.1f);//Invoke >> se�ilen metodun belli bir s�re sonra �a�r�lmas�n� sa�lama
            audioSource.Play();
        }

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);//mermi i�in spawner

        Rigidbody rb = bullet.GetComponent<Rigidbody>();//mermi i�in fizik
        rb.velocity = firePoint.forward * bulletSpeed;//merminin ileri do�ru ate�lenmesi

        Destroy(bullet, bulletLifeTime);//oyunumun biriken mermilerden dolay� kasmamas� i�in mermilerin sahne �zerinden silinmesi 

        if (shootEffect != null)
        {
            GameObject Shooting = Instantiate(shootEffect, firePoint.position, firePoint.rotation);//ate� etme efekti i�in spawner
        }
    }

    void StopShootAnimation()
    {
        if (animator != null)//ate� edilmiyorsa animasyonu durdur
        {
            animator.SetBool("shoot", false);
        }
    }
}
