using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController1 : MonoBehaviour
{
    public float speed = 4.0f;
    private Rigidbody2D rb;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private Vector3 charPos;
    [SerializeField] private GameObject _camera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();//Karakterimizin geriye giderkenki animasyonunu düzeltmek için.
        _animator = GetComponent<Animator>();
        charPos = transform.position;
    }
    /*
    void FixedUpdate()//Fiziksel Hesaplamalar Burada Yapýlýr.
    {
        rb.velocity = new Vector2(speed, 0);
    }*/

    void Update()
    {
        charPos = new Vector3(charPos.x + (Input.GetAxis("Horizontal") * Time.deltaTime), charPos.y);
        transform.position = charPos; // Hesapladigim pozisyon karakterime esitlensin.
        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            _animator.SetFloat("Speed", 0.0f);

        }
        else
        {
            _animator.SetFloat("Speed", 1.0f);//Animatordeki speed ile eþitledik.
        }

        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            _spriteRenderer.flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < -0.01f)
        {
            _spriteRenderer.flipX = true;
        }
    }
    private void LateUpdate()
    {
        _camera.transform.position = new Vector3(charPos.x, charPos.y, charPos.z - 1.0f);
    }
}
