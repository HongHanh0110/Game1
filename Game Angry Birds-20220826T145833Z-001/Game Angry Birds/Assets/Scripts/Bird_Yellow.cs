using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Yellow : MonoBehaviour
{
    Vector3 InitialPos;
    [SerializeField] Transform target;

    bool isMove;
    bool canShoot; // Biến này đẻ check xem có thể bắn con bird đi hay khồng. Khi nó ở vị trí bắn mới cho phép bắn
    [SerializeField] float speed; // Tốc độ di chuyển của con bird đến vị trí bắn
    private void Start()
    {
        InitialPos = target.position;

    }

    //
    private void OnMouseDrag()
    {
        if (!canShoot) // kiếm tra nếu con bird chưa ở vị trí bắn thì không cho phép bắn
        {
            return;
        }
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, 0);
    }

    private void OnMouseDown()
    {
        if (!isMove)
        {
            // cho phép con bird di chuyển
            isMove = true;
        }
    }


    private void Update()
    {
        if (isMove && !canShoot)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, target.position) <= 0.05f) // kiểm tra con bird đã đến vị trí thì cho phep bắn
            {
                canShoot = true;
            }
        }
    }
    private void OnMouseUp()
    {
        if (!canShoot) // kiếm tra nếu con bird chưa ở vị trí bắn thì không cho phép bắn
        {
            return;
        }
        Vector3 vectorForce = InitialPos - transform.position;
        GetComponent<Rigidbody2D>().AddForce(vectorForce * 400);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }
    public float defend;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > defend)
        {
            Destroy(gameObject, 4f);
        }


        else
        {
            defend -= collision.relativeVelocity.magnitude;
        }
    }
}

