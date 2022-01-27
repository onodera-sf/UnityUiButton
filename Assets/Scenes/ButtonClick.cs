using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    // �ǉ�

public class ButtonClick : MonoBehaviour
{
  /// <summary>�J�E���g�A�b�v����e�L�X�g�I�u�W�F�N�g�B</summary>
  [SerializeField] Text CountText;

  /// <summary>�N���b�N�J�E���g�B</summary>
  private int _counter = 0;

  public void OnClick()
  {
    // �R���\�[�� ���O���o��
    Debug.Log("�{�^����������܂����I");

    // �J�E���g�𑝂₷
    _counter++;

    // �J�E���g��������\������
    CountText.text = _counter.ToString();
  }
}
