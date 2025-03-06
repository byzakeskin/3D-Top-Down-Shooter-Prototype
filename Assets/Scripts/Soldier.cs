using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    [SerializeField]
    private float speed; // karakterimin hareket h�z�
    [SerializeField]
    private float rotationSpeed; //karakterimin kendi etraf�nda d�n�� h�z�
    private Rigidbody rb; // karakterimin fiziksel hareketi i�in rigidbody bile�ininin tan�mlanmas�
    public Animator animator; //animasyonlar�n �al��abilmesi i�in animator tan�m�
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // oyun ba�lang�c�nda rigidbody ve animator �a��r�lmas�
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal"); // karakterimin w,a,s,d tu�lar�ndan gelen kullan�c� inputlar� ile hareketinin sa�lanmas�
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); // hareket vekt�rlerinin olu�turulmas�

        if (movement != Vector3.zero) // karakterim hareket halindeyken ger�ekle�ecek eylemler
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up); // karakterimin bakt��� y�ne do�ru d�nmesi, rotasyon de�i�tirmesi
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime); //rotasyonu belirledi�im h�z ile de�i�tirmesi
            animator.SetBool("run", true); // karakterim hareket halinde ise �al��acak y�r�me animasyonu
        }
        else
        {
            animator.SetBool("run", false); // karakterim duruyorsa idle animasyonuna geri d�nmesi
        }

        rb.MovePosition(transform.position + movement * speed * Time.deltaTime); // karakterimin rigidbody ile hareketi
    }
}
