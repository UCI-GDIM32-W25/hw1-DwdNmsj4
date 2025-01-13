using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        
        float moveX = Input.GetAxis("Horizontal");//0.1,-1
        float moveY = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveX, moveY, 0) * _speed * Time.deltaTime;
        
        _playerTransform.position += movement;

       
        if (Input.GetKeyDown(KeyCode.Space) && _numSeedsLeft > 0)
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        
        Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
        _numSeedsLeft--;
        _numSeedsPlanted++;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
