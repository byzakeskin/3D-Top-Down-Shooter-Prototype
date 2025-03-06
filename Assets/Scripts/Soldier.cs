using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    [SerializeField]
    private float speed; // karakterimin hareket hýzý
    [SerializeField]
    private float rotationSpeed; //karakterimin kendi etrafýnda dönüþ hýzý
    private Rigidbody rb; // karakterimin fiziksel hareketi için rigidbody bileþininin tanýmlanmasý
    public Animator animator; //animasyonlarýn çalýþabilmesi için animator tanýmý
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // oyun baþlangýcýnda rigidbody ve animator çaðýrýlmasý
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal"); // karakterimin w,a,s,d tuþlarýndan gelen kullanýcý inputlarý ile hareketinin saðlanmasý
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); // hareket vektörlerinin oluþturulmasý

        if (movement != Vector3.zero) // karakterim hareket halindeyken gerçekleþecek eylemler
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up); // karakterimin baktýðý yöne doðru dönmesi, rotasyon deðiþtirmesi
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime); //rotasyonu belirlediðim hýz ile deðiþtirmesi
            animator.SetBool("run", true); // karakterim hareket halinde ise çalýþacak yürüme animasyonu
        }
        else
        {
            animator.SetBool("run", false); // karakterim duruyorsa idle animasyonuna geri dönmesi
        }

        rb.MovePosition(transform.position + movement * speed * Time.deltaTime); // karakterimin rigidbody ile hareketi
    }
}
