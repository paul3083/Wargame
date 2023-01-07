using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float health = 10f;
    public float damageperiod = 1f;
    [SerializeField] private float defense = 0.5f;
    private float _delta = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _delta += Time.deltaTime; 
        if( _delta >= damageperiod )
        {
            _delta = 0;
            OnDamaged(5f);
        }
    }
    public void OnDamaged(float demage)
    {
        health -= demage * (1 - defense);
        if(health <= 0)
        {
            OnDeath();
        }
    }
    void OnDeath()
    {

        Destroy(gameObject);
    }
}

