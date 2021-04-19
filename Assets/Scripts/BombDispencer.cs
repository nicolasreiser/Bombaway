using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDispencer : MonoBehaviour, IAffectable
{
    [SerializeField] GameObject shootDirection;
    [SerializeField] GameObject bombPrefab;
    [SerializeField] int force = 1;
    [SerializeField] bool instntiateFused = false;
    public void OnActivate()
    {
        Debug.Log("Activation completed");

        GameObject bomb = Instantiate(bombPrefab, shootDirection.transform.position, shootDirection.transform.rotation);
        
        if(instntiateFused)
        {
            StartCoroutine(FuseBombCoroutine(bomb));
        }

        bomb.GetComponent<Rigidbody2D>().AddForce(GetDirection()* force, ForceMode2D.Impulse);
    }

    private Vector2 GetDirection()
    {
        Vector2 res = new Vector2(shootDirection.transform.position.x - this.transform.position.x,
            shootDirection.transform.position.y - this.transform.position.y);

        return res.normalized;
    }

    IEnumerator FuseBombCoroutine(GameObject bomb)
    {
        yield return new WaitForEndOfFrame();

        bomb.GetComponent<Bomb>().TriggerFuse();

    }
}
