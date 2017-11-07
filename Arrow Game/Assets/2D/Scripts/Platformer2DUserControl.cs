using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;



    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D character;
        private bool jump;
		public string loadedLevelName;
		public AudioSource Menu;

        private void Awake()
        {
            character = GetComponent<PlatformerCharacter2D>();
        }

        private void Update()
        {
            if(!jump)
            // Read the jump input in Update so button presses aren't missed.
            jump = CrossPlatformInputManager.GetButtonDown("Jump");

		if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene(loadedLevelName) ;

		if (Input.GetKeyDown (KeyCode.Escape))
			Menu.Play ();
        }

        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            character.Move(h, crouch, jump);
            jump = false;
        }

		void OnCollisionEnter2D(Collision2D other)
		{
			if (other.transform.tag == "MovingPlatform")
			{
				transform.parent = other.transform;
			}
		}

		void OnCollisionExit2D(Collision2D other)
		{
			if (other.transform.tag == "MovingPlatform")
			{
				transform.parent = null;
			}
		}
    }
