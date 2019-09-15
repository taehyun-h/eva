using UnityEngine;
using UnityEngine.UI;

public class InputBlocker : SingletonMonoBehaviour<InputBlocker>
{
    [SerializeField] private Image _inputBlock;

    public void BlockInput()
    {
        _inputBlock.enabled = true;
    }

    public void UnblockInput()
    {
        _inputBlock.enabled = false;
    }
}
