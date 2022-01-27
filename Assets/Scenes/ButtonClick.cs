using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    // 追加

public class ButtonClick : MonoBehaviour
{
  /// <summary>カウントアップするテキストオブジェクト。</summary>
  [SerializeField] Text CountText;

  /// <summary>クリックカウント。</summary>
  private int _counter = 0;

  public void OnClick()
  {
    // コンソール ログを出力
    Debug.Log("ボタンが押されました！");

    // カウントを増やす
    _counter++;

    // カウントした数を表示する
    CountText.text = _counter.ToString();
  }
}
