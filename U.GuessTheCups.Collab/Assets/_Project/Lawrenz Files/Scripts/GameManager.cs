using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ddr.GuessTheCup.All
{
    public class GameManager : MonoBehaviour
    {
        
        [Header("Object to instantiate")]
        [SerializeField]
         GameObject Cup;

        [SerializeField]
         List<GameObject> CupsCount;
         
            [SerializeField]
            int numberOfCups = 3;
        [SerializeField]
            List<Transform> vectorRandom;
            private void OnValidate() {
        
            }
            public int returnCupCount(){

                    return numberOfCups;

            }

            public void SpawnCups(){
               for(int i = 0; i<=numberOfCups-1;i++){

                    int vectorPosition = Random.Range(0,vectorRandom.Count);
                    GameObject current = (GameObject)Instantiate(Cup,vectorRandom[vectorPosition]);
                     CupsCount.Add(current);
         
                  
               }

            }
    }
}
