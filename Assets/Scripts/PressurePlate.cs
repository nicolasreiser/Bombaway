using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] float sphereRadius = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            Debug.Log("An Object entered the trigger");
            Vector2 center = new Vector2(this.transform.position.x, this.transform.position.y);
            Collider2D[] colliders = Physics2D.OverlapCircleAll(center, sphereRadius);
            Debug.Log("Affectable list size : " + colliders.Length);
            foreach (Collider2D collider in colliders)
            {
                IAffectable affectable = collider.gameObject.GetComponent<IAffectable>();
                Debug.Log("Collider Name : " + collider.gameObject.name);

            if (affectable != null)
                {
                    affectable.OnActivate();
                }

            }
    }

    private void OnDrawGizmos()
    {
        Vector2 center = new Vector2(this.transform.position.x, this.transform.position.y);

        Gizmos.DrawWireSphere(center, sphereRadius);
    }
}
