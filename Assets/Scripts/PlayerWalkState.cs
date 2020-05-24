using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkState : IPlayerState
{
    /// <summary>プレイヤーステートプロセッサー</summary>
    private PlayerStateProcessor pStateProcessor;
    /// <summary>移動速度</summary>
    private float moveSpeed = -0.3f;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="pSp"></param>
    public PlayerWalkState(PlayerStateProcessor pSp)
    {
        this.pStateProcessor = pSp;

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
            pStateProcessor.SwitchState((int)PlayerStateProcessor.STATE.WAIT);

        }

        // 移動
        pStateProcessor.transform.position += new Vector3(moveSpeed, 0.0f);
    }
}
