using UnityEngine;

public class SingletonMonoBehaviour<TypeName> : MonoBehaviour where TypeName : SingletonMonoBehaviour<TypeName>
{
    public static TypeName Instance => _instance;
    private static TypeName _instance;

    public Transform Transform => _transform;
    protected Transform _transform;

    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = (TypeName)this;
            _transform = transform;

            Init();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    protected virtual void Init() { }
}
