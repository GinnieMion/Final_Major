namespace EasyPeasyFirstPersonController
{
    using UnityEngine;
    using UnityEngine.ProBuilder.MeshOperations;

    public class InputManagerOld : MonoBehaviour, IInputManager
    {
        public Vector2 moveInput => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        public Vector2 lookInput => new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        public bool jump => Input.GetKey(KeyCode.Space);
        public bool crouch => Input.GetKey(KeyCode.C);
        public bool slide => Input.GetKey(KeyCode.C);
        public bool sprint => Input.GetKey(KeyCode.LeftShift);


    }

}




