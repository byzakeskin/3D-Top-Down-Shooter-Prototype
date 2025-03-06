using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] 
    private float speed; // d��man�n hareket h�z�
    private Transform soldier; //d��man�n karakteri takip etmesi i�in, karakterin transformunun al�nmas�
    private Rigidbody rb; 

    void Start()
    {
        soldier = GameObject.FindGameObjectWithTag("Soldier").transform; // karakteri tag ile bulma
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = (soldier.position - transform.position).normalized; //karakter neredeyse d��man�n onun �zerine gelmesi i�in iki pozisyon aras�ndaki fark� hesaplama
        rb.MovePosition(transform.position + direction * speed * Time.deltaTime); 
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) //d��man�n mermi ile etkile�ime girmesi sonucu sahneden silinmesi
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);

            if (GameManager.instance != null)//e�er d��man �lm��se skorumuz artmas�� bunun i�in GameMnager class�n� kullanma
            {
                GameManager.instance.AddPoint();
            }
        }
    }
}
