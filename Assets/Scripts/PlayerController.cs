using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Parametros de movimiento"), Space]
    [Tooltip("Velocidad de movimiento")]
    public float speed;

    //Referencia al valor del input axis horizontal
    private float h;

    //Referencia al valor del input axis vertical
    private float v;

    //vector de movimiento 
    private Vector2 movement;

    [Header("Limite de pantalla"), Space]
    [Tooltip("Limite de movimiento en el eje X")]
    public float xLimit;

    [Tooltip("Limite de movimiento en el eje Y")]
    public float yLimit;


    //Referencias
    //Referencia al rigidbody 2D
    private Rigidbody2D rb2d;

    private void Awake() {

        rb2d = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region
        //recuperamos los valores de los axis horizontal y vertical
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        #endregion
    }

    private void FixedUpdate() {

        Movement();
    }

    /// <summary>
    /// Metodo qye se encargara de realizar el movimiento del jugador
    /// </summary>
    private void Movement() {

        //Generamos un vector de movimientp y lo normalizamos
        movement = new Vector2(h, v).normalized;

        //Aplicamos el movimiento sobre el jugador 
        rb2d.MovePosition((Vector2)transform.position + movement * speed * Time.deltaTime);
        
        //si la nave 
        if(true) {


        }

    }

}
