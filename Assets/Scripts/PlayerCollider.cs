using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    /// <summary>横幅の半値</summary>
    private float halfWidth;
    /// <summary>縦幅の半値</summary>
    private float halfHeight;

    /// <summary>余白</summary>
    private const float SPACE = 0.1f;

    // Use this for initialization
    void Start()
    {
        halfWidth = this.gameObject.GetComponent<RectTransform>().sizeDelta.x / 2;
        halfHeight = this.gameObject.GetComponent<RectTransform>().sizeDelta.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // 衝突判定生成
        Vector2 hitPos = new Vector2(this.transform.position.x + (halfWidth + SPACE), this.transform.position.y - halfHeight);
        RaycastHit2D hit = Physics2D.Raycast(hitPos, new Vector2(0, 1), 100);

        // 衝突判定の描画
        Debug.DrawRay(hitPos, new Vector2(0, 100), Color.blue, 1);

        // 衝突の有無
        if (hit.collider)
        {
            // 衝突している場合

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
