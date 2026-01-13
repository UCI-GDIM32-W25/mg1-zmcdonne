using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;
     public GameObject spritePrefab;
    private int _numSeedsLeft;
    private Rigidbody2D _rigidbody;
    private int _numSeedsPlanted;

    private void Start ()
  {
    _rigidbody = GetComponent<Rigidbody2D>();
    _numSeedsLeft = _numSeeds;
  _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

  }

    private void Update() 
    {
    _rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * _speed;

    if(Input.GetKeyDown(KeyCode.Space) && _numSeedsLeft > 0)
     {
       PlantSeed();
       _numSeedsLeft--;
       _numSeedsPlanted++;
      _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
    }


    public void PlantSeed ()

  {
    Instantiate( spritePrefab, _playerTransform.position, Quaternion.identity);
    }
    
}

