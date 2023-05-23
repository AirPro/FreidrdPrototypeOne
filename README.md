# FreidrdPrototypeOne
## Assignment for Module 2 
This is the Unity files for the requirements for Module 2 HJomewoprk Assignment. <br>
For this assignment, we are going to build off of what you created in the tutorials.  <br>
If you are having any issues completing the tutorial please let me know.  <br>
You should submit your PlayerController.cs file (either the file itself or the contents). <br>

We are going to add the ability to jump to our vehicle.  <br>
You must also add code that makes the vehicle move and turn faster while the shift key is pressed.  <br>
Input.GetKey() will return true if the keycode passed to it is currently being held down, false if not.  <br>
Keycodes are accessible through KeyCode.  <br>
Here's an example: <br>


if(Input.GetKey(KeyCode.LeftShift)) <br>
{<br>
    Debug.Log("Maybe we should make some numbers bigger now");<br>
}
