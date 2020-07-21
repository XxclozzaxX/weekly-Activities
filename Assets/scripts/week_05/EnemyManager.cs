using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // an example of using mane spaces

// this is a name space we can encapsulate our code to it, to tell
// people that this class is contained with a certain name space grouping our class together
namespace Level01
{
    public class EnemyManager : MonoBehaviour
    {
        // an instance of our enemy script
        public Enemy enemy01;
        public Enemy enemy02;
        // a dtata storage class, to contain information about my enomy
        public EnemyContactDetails enemyDetails;
        // another data storage class for my main menu
        public MainMenu mainMenu;
        // a data storage class to contain my settings
        public SettingsMenu settingsMenu;

        // Start is called before the first frame update
        void Start()
        {
            // this is how i referance my instance of the enemy class and access variables
            // and functions in it
            enemy01.SetUpEnemy();
            enemy01.myFirstName = "louise";
            // this is an example of accessing another instance
            enemy02.SetUpEnemy();
            enemy02.health = 50;
        }
    }
    // this is [System.Serializable] this lets unity know that i want it visable in thw inspector
    // it basically creates a new dropdown for unity to use - C
    // this is also an example of a data storage class where no runtime instance is required
    [System.Serializable]
    public class EnemyContactDetails
    {
        public string firstName;
        public string lastName;
        public int age;
    }

    [System.Serializable]
    public class MainMenu
    {
        public Button startButton;

        public void PlayButton()
        {
            Debug.Log("Play The Game!");
        }
    }

    [System.Serializable]
    public class SettingsMenu
    {
        public Text settings;
    }
}