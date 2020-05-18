using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWaitState : IPlayerState
{
    /// <summary>プレイヤーマネージャ</summary>
    private PlayerManager pM;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public PlayerWaitState(PlayerManager pM)
    {
        this.pM = pM;
        Debug.Log("Wait!!!!!!!");

        Initialize();
    }

    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Initialize()
    {
    }


    /// <summary>
    /// 待機状態での実行処理
    /// </summary>
    public void Execute()
    {
        Debug.Log("WaitExe");

        // スペースキー入力判別
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 入力があった場合

            // ジャンプ状態に切り替え
            pM.SwitchState(PlayerManager.STATE.JUMP);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //pM.gameObject.transform.//
        }
    }
}
