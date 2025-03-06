using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] 
    private float speed; // düþmanýn hareket hýzý
    private Transform soldier; //düþmanýn karakteri takip etmesi için, karakterin transformunun alýnmasý
    private Rigidbody rb; 

    void Start()
    {
        soldier = GameObject.FindGameObjectWithTag("Soldier").transform; // karakteri tag ile bulma
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = (soldier.position - transform.position).normalized; //karakter neredeyse düþmanýn onun üzerine gelmesi için iki pozisyon arasýndaki farký hesaplama
        rb.MovePosition(transform.position + direction * speed * Time.deltaTime); 
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) //düþmanýn mermi ile etkileþime girmesi sonucu sahneden silinmesi
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);

            if (GameManager.instance != null)//eðer düþman ölmüþse skorumuz artmasýý bunun için GameMnager classýný kullanma
            {
                GameManager.instance.AddPoint();
            }
        }
    }
}
