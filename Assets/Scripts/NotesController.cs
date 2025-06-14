using UnityEditor.Rendering;
using UnityEngine;

public class NotesController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 50f;

    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }

    private void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }
}
