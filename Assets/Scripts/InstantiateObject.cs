using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    [SerializeField]

    private GameObject _objectToInstance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Instantiate(Transform target)
    {
        Instantiate(_objectToInstance, target.position, Quaternion.identity);
    }

}
