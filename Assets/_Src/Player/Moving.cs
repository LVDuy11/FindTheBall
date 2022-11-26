using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody _rigidbody;
    public float thrust = 15f;

    // Start is called before the first frame update
    void Start()
    {
        this._rigidbody = transform.parent.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        this.MoveByRigidbody();
    }

    // Update is called once per frame
    void Update()
    {
        //this.ObjMoving();
    }


    protected virtual void ObjMoving()
    {
        float translationV = InputManager.instance.vertical * this.speed;
        float translationH = InputManager.instance.horizontal * this.speed;
        translationV *= Time.deltaTime;
        translationH *= Time.deltaTime;
        transform.parent.Translate(translationH, 0, translationV);
    }

    protected virtual void MoveByRigidbody()
    {
        float z = InputManager.instance.horizontal;
        float x = InputManager.instance.vertical;
        Vector3 direction = new Vector3(z, 0, x);
        this._rigidbody.AddForce(direction * this.thrust);
    }
}
