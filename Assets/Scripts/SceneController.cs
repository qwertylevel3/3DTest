using UnityEngine;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject enemyPrefab;

    private GameObject _enemy;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (_enemy == null)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
        }
    }
}