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
    private int _numSeedsPlanted;

    private void Start ()
    {
    //player movement
    }

    private void Update()
    {
      //check updatate frame every scene count seeds in   
    }

    public void PlantSeed ()
    {
        if(Input.GetKeyDown);
//instatiate the seed when playing space        
    }
}
