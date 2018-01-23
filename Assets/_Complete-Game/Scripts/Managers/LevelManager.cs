using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace CompleteProject
{
    public class LevelManager : MonoBehaviour
    {

        public static int level;        // The player's score.


        Text text;                      // Reference to the Text component.
        CanvasGroup cg;
        public float smoothTime = 0.3F;

        public static bool showLevelText;

        // Use this for initialization
        void Start()
        {
            showLevelText = true;
            text = GetComponent<Text>();
            cg = GetComponent<CanvasGroup>();

            StartCoroutine(Example());

            level = 1;
           
        }


        IEnumerator Example()
        {
            if(showLevelText)
            {
                cg.alpha = 1;
                yield return new WaitForSeconds(5);
                cg.alpha = 0;
                showLevelText = false;
            }
            
        }

        // Update is called once per frame
        void Update()
        {
            StartCoroutine(Example());
            text.text = "Level: " + level;
        }
    }
}
