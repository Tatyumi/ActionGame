using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkState : IPlayerState
{
    /// <summary>プレイヤーマネージャー</summary>
    private PlayerManager pM;
    /// <summary>移動速度</summary>
    private float moveSpeed = -0.3f;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="pM"></param>
    public PlayerWalkState(PlayerManager pM)
    {
        this.pM = pM;

        Initialize();
    }


    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Initialize()
    {

    }


    /// <summary>
    /// 「歩く」状態の処理
    /// </summary>
    public void Execute()
    {
        // ←を離したか判別
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            // 離した場合
            Debug.Log("入力なし");

            // 待機状態に切り替え
            pM.SwitchState(PlayerManager.STATE.WAIT);

        }

        // 移動
        pM.transform.position += new Vector3(moveSpeed, 0.0f);
    }
}
