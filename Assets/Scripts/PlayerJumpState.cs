using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : IPlayerState
{
    /// <summary>プレイヤーマネージャ</summary>
    private PlayerManager pM;
    /// <summary>経過時間</summary>
    private float deltaTime;
    /// <summary>ジャンプ時間</summary>
    private float JUMP_TIME = 2.0f;


    /// <summary>
    /// コンストラクタ
    /// </summary>
    public PlayerJumpState(PlayerManager pM)
    {
        this.pM = pM;
        Debug.Log("Jump!!!!!");

        Initialize();
    }


    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Initialize()
    {
        deltaTime = 0.0f;
    }

    /// <summary>
    /// ジャンプ状態で実行する処理
    /// </summary>
    public void Execute()
    {

        Debug.Log("JumpExeCute");

        // 計測
        deltaTime += Time.deltaTime;

        // ジャンプ時間に達したか判別
        if(deltaTime > JUMP_TIME)
        {
            // 待機状態に切り替え
            pM.SwitchState(PlayerManager.STATE.WAIT);
        }
    }
}
