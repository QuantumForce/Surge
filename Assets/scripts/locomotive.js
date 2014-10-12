#pragma strict

var speed = 5.0;
var rotate = 5.0;
function Start () {

}

function Update () {

var x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
var z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
transform.Translate(x,0,z);
if (Input.GetKey("a")){
transform.Rotate(Vector3.down * rotate);
}
if (Input.GetKey("d")){
transform.Rotate(Vector3.up * rotate);
}
}