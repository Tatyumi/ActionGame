using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private float width;


    // Use this for initialization
    void Start()
    {
        //this.gameObject.AddComponent<BoxCollider2D>();
        //this.gameObject.AddComponent<Rigidbody>();
        width = this.gameObject.GetComponent<RectTransform>().sizeDelta.x / 2 + 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        //Ray ray

        Vector2 hitPos = new Vector2(this.transform.position.x + width, this.transform.position.y - this.gameObject.GetComponent<RectTransform>().sizeDelta.y / 2);

        RaycastHit2D hit = Physics2D.Raycast(hitPos, new Vector2(0, 1), 100);

        Debug.DrawRay(hitPos, new Vector2(0, 100), Color.blue, 1);

        // 自身にヒットしている可能性がある
        if (hit.collider)
        {
            Debug.Log("Ray");
        }
    }

    /// <summary>
    /// 衝突判定
    /// </summary>
    /// <param name="col">衝突コライダー</param>
    void OnTriggerEnter2D(Collider2D col)
    {
        // コンポーネント確認


        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
    }
}
